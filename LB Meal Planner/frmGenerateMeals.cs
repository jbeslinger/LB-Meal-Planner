using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LB_Meal_Planner
{
    public partial class frmGenerateMeals : Form
    {
        #region Members
        SQLiteConnection con;
        string url;
        #endregion

        #region Constructors
        public frmGenerateMeals(SQLiteConnection con)
        {
            InitializeComponent();
            this.con = con;

            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM `userprefs`";
            var rdr = cmd.ExecuteReader();
            rdr.Read();

            url = rdr.GetString(0);
            numGenerateDays.Value = (int)rdr.GetDecimal(1);
            numAlternateMeals.Value = (int)rdr.GetDecimal(2);
            chkGenerateGroceryList.Checked = (rdr.GetInt16(3) == 1) ? true : false;

            int minutes, hours;
            chkBreakfast.Checked = (rdr.GetInt16(4) == 1) ? true : false;
            minutes = rdr.GetInt32(4 + 6); hours = minutes / 60; minutes %= 60;
            timeBreakfast.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsBreakfast.Value = (int)rdr.GetDecimal(4 + 12);
            numServingsBreakfast.Value = (int)rdr.GetDecimal(4 + 18);

            chkBrunch.Checked = (rdr.GetInt16(5) == 1) ? true : false;
            minutes = rdr.GetInt32(5 + 6); hours = minutes / 60; minutes %= 60;
            timeBrunch.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsBrunch.Value = (int)rdr.GetDecimal(5 + 12);
            numServingsBrunch.Value = (int)rdr.GetDecimal(5 + 18);
            
            chkLunch.Checked = (rdr.GetInt16(6) == 1) ? true : false;
            minutes = rdr.GetInt32(6 + 6); hours = minutes / 60; minutes %= 60;
            timeLunch.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsLunch.Value = (int)rdr.GetDecimal(6 + 12);
            numServingsLunch.Value = (int)rdr.GetDecimal(6 + 18);

            chkDinner.Checked = (rdr.GetInt16(7) == 1) ? true : false;
            minutes = rdr.GetInt32(7 + 6); hours = minutes / 60; minutes %= 60;
            timeDinner.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsDinner.Value = (int)rdr.GetDecimal(7 + 12);
            numServingsDinner.Value = (int)rdr.GetDecimal(7 + 18);

            chkSupper.Checked = (rdr.GetInt16(8) == 1) ? true : false;
            minutes = rdr.GetInt32(8 + 6); hours = minutes / 60; minutes %= 60;
            timeSupper.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsSupper.Value = (int)rdr.GetDecimal(8 + 12);
            numServingsSupper.Value = (int)rdr.GetDecimal(8 + 18);

            chkSnack.Checked = (rdr.GetInt16(9) == 1) ? true : false;
            minutes = rdr.GetInt32(9 + 6); hours = minutes / 60; minutes %= 60;
            timeSnack.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsSnack.Value = (int)rdr.GetDecimal(9 + 12);
            numServingsSnack.Value = (int)rdr.GetDecimal(9 + 18);
        }
        #endregion

        #region Methods
        private void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        #endregion

        #region Events
        private void chkBreakfast_CheckedChanged(object sender, EventArgs e)
        { bool v = chkBreakfast.Checked; timeBreakfast.Enabled = v; numPersonsBreakfast.Enabled = v; numServingsBreakfast.Enabled = v; }
        
        private void chkBrunch_CheckedChanged(object sender, EventArgs e)
        { bool v = chkBrunch.Checked; timeBrunch.Enabled = v; numPersonsBrunch.Enabled = v; numServingsBrunch.Enabled = v; }

        private void chkLunch_CheckedChanged(object sender, EventArgs e)
        { bool v = chkLunch.Checked; timeLunch.Enabled = v; numPersonsLunch.Enabled = v; numServingsLunch.Enabled = v; }

        private void chkDinner_CheckedChanged(object sender, EventArgs e)
        { bool v = chkDinner.Checked; timeDinner.Enabled = v; numPersonsDinner.Enabled = v; numServingsDinner.Enabled = v; }

        private void chkSupper_CheckedChanged(object sender, EventArgs e)
        { bool v = chkSupper.Checked; timeSupper.Enabled = v; numPersonsSupper.Enabled = v; numServingsSupper.Enabled = v; }

        private void chkSnack_CheckedChanged(object sender, EventArgs e)
        { bool v = chkSnack.Checked; timeSnack.Enabled = v; numPersonsSnack.Enabled = v; numServingsSnack.Enabled = v; }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dateStartThisDay.Value < DateTime.Today)
            {
                MessageBox.Show("The start date cannot have already passed.", "Date Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                int generateForDays = (int)numGenerateDays.Value;
                int alternateMeals = (int)numAlternateMeals.Value;

                List<Recipe>
                    breakfastRecipes = new List<Recipe>(),
                    brunchRecipes    = new List<Recipe>(),
                    lunchRecipes     = new List<Recipe>(),
                    dinnerRecipes    = new List<Recipe>(),
                    supperRecipes    = new List<Recipe>(),
                    snackRecipes     = new List<Recipe>();

                // Filling the Recipe lists with Recipe structs
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT * FROM `recipes` WHERE PickMe = 1";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Recipe r = new Recipe(
                        rdr.GetString(0), rdr.GetString(7), rdr.GetString(8),
                        rdr.GetInt32(3), rdr.GetInt32(5), rdr.GetInt16(6),
                        (rdr.GetInt16(4) == 1 ? true : false), (Recipe.RecipeType)rdr.GetInt32(1));
                    if (r.Type.HasFlag(Recipe.RecipeType.BREAKFAST))
                        breakfastRecipes.Add(r);
                    if (r.Type.HasFlag(Recipe.RecipeType.BRUNCH))
                        brunchRecipes.Add(r);
                    if (r.Type.HasFlag(Recipe.RecipeType.LUNCH))
                        lunchRecipes.Add(r);
                    if (r.Type.HasFlag(Recipe.RecipeType.DINNER))
                        dinnerRecipes.Add(r);
                    if (r.Type.HasFlag(Recipe.RecipeType.SUPPER))
                        supperRecipes.Add(r);
                    if (r.Type.HasFlag(Recipe.RecipeType.SNACK))
                        snackRecipes.Add(r);
                }

                // Error Checking
                if ((chkBreakfast.Checked  &&  breakfastRecipes.Count == 0) ||
                    (chkBrunch.Checked     &&  brunchRecipes.Count == 0   ) ||
                    (chkLunch.Checked      &&  lunchRecipes.Count == 0    ) ||
                    (chkDinner.Checked     &&  dinnerRecipes.Count == 0   ) ||
                    (chkSupper.Checked     &&  supperRecipes.Count == 0   ) ||
                    (chkSnack.Checked      &&  snackRecipes.Count == 0    ))
                {
                    MessageBox.Show("You don't have enough types of recipes to generate the meals you requested." +
                        "Go back and make sure you have enough types of recipes.",
                        "Not Enough Types of Meals", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((chkBreakfast.Checked  &&  (alternateMeals > breakfastRecipes.Count)) ||
                    (chkBrunch.Checked     &&  (alternateMeals > brunchRecipes.Count   )) ||
                    (chkLunch.Checked      &&  (alternateMeals > lunchRecipes.Count    )) ||
                    (chkDinner.Checked     &&  (alternateMeals > dinnerRecipes.Count   )) ||
                    (chkSupper.Checked     &&  (alternateMeals > supperRecipes.Count   )) ||
                    (chkSnack.Checked      &&  (alternateMeals > snackRecipes.Count    )))
                {
                    MessageBox.Show("There aren't enough meals per category to cover " + alternateMeals + " different alternating meals. " +
                        "Go back and make some more meals for each category you would like to generate or lower your amount of different meals to generate.",
                        "Not Enough Meals to Alternate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get calendar address
                cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT CalendarURL FROM `userprefs` WHERE ROWID = 1";
                rdr = cmd.ExecuteReader();
                rdr.Read();
                string url = rdr.GetString(0);

                // Meal & Calendar Generation
                if (chkBreakfast.Checked)
                {
                    Shuffle<Recipe>(breakfastRecipes);
                    int m = alternateMeals;
                    for (int n = 0; n < generateForDays; n++)
                    {
                        // Alternate through recipes in a linear pattern
                        Recipe r = breakfastRecipes[m % alternateMeals];
                        Event gEvent = new Event();
                        gEvent.Summary = r.Name + " - Breakfast";
                        gEvent.Description += "<ol>";
                        foreach (string s in r.Directions.Split('\n'))
                            gEvent.Description += "<li>" + s + "</li>";
                        gEvent.Description += "</ol>";
                        EventDateTime start = new EventDateTime();
                        DateTime d = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + n,
                            timeBreakfast.Value.Hour, timeBreakfast.Value.Minute, 0);
                        start.DateTime = d;
                        gEvent.Start = start;
                        EventDateTime end = new EventDateTime();
                        d = d.AddHours((double)((int)r.CookTime / 60));
                        d = d.AddMinutes((double)((int)r.CookTime % 60));
                        end.DateTime = d;
                        gEvent.End = end;
                        if (r.RequiresPrep)
                        {
                            EventReminder er = new EventReminder();
                            er.Method = "popup";
                            er.Minutes = r.PrepTime;
                            EventReminder[] reminderOverrides = new EventReminder[] { er };
                            Event.RemindersData remindersData = new Event.RemindersData();
                            remindersData.UseDefault = false;
                            remindersData.Overrides = reminderOverrides;
                            gEvent.Reminders = remindersData;
                        }
                        Program.service.Events.Insert(gEvent, url).Execute();
                        ++m;
                    }
                }
                if (chkBrunch.Checked)
                {

                }
                if (chkLunch.Checked)
                {

                }
                if (chkDinner.Checked)
                {

                }
                if (chkSupper.Checked)
                {

                }
                if (chkSnack.Checked)
                {

                }

                // Grocery list generation
                if (chkGenerateGroceryList.Checked)
                {
                    
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            
            cmd.CommandText = "UPDATE `userprefs` SET " +
                "GenerateForDays = "            + numGenerateDays.Value                                        + ", " +
                "NumberOfDiffMeals = "          + numAlternateMeals.Value                                      + ", " +
                "GenerateGroceryList = "        + (chkGenerateGroceryList.Checked ? 1 : 0)                     + ", " +
                                                
                "BreakfastChk = "               + (chkBreakfast.Checked ? 1 : 0)                               + ", " +
                "BreakfastTime = "              + (timeBreakfast.Value.Hour * 60 + timeBreakfast.Value.Minute) + ", " +
                "BreakfastPeople = "            + numPersonsBreakfast.Value                                    + ", " +
                "BreakfastServingsPerPerson = " + numServingsBreakfast.Value                                   + ", " +
                                                
                "BrunchChk = "                  + (chkBrunch.Checked ? 1 : 0)                                  + ", " +
                "BrunchTime = "                 + (timeBrunch.Value.Hour * 60 + timeBrunch.Value.Minute)       + ", " +
                "BrunchPeople = "               + numPersonsBrunch.Value                                       + ", " +
                "BrunchServingsPerPerson = "    + numServingsBrunch.Value                                      + ", " +
                                                
                "LunchChk = "                   + (chkLunch.Checked ? 1 : 0)                                   + ", " +
                "LunchTime = "                  + (timeLunch.Value.Hour * 60 + timeLunch.Value.Minute)         + ", " +
                "LunchPeople = "                + numPersonsLunch.Value                                        + ", " +
                "LunchServingsPerPerson = "     + numServingsLunch.Value                                       + ", " +
                                                
                "DinnerChk = "                  + (chkDinner.Checked ? 1 : 0)                                  + ", " +
                "DinnerTime = "                 + (timeDinner.Value.Hour * 60 + timeDinner.Value.Minute)       + ", " +
                "DinnerPeople = "               + numPersonsDinner.Value                                       + ", " +
                "DinnerServingsPerPerson = "    + numServingsDinner.Value                                      + ", " +
                                                
                "SupperChk = "                  + (chkSupper.Checked ? 1 : 0)                                  + ", " +
                "SupperTime = "                 + (timeSupper.Value.Hour * 60 + timeSupper.Value.Minute)       + ", " +
                "SupperPeople = "               + numPersonsSupper.Value                                       + ", " +
                "SupperServingsPerPerson = "    + numServingsSupper.Value                                      + ", " +
                                                
                "SnackChk = "                   + (chkSnack.Checked ? 1 : 0)                                   + ", " +
                "SnackTime = "                  + (timeSnack.Value.Hour * 60 + timeSnack.Value.Minute)         + ", " +
                "SnackPeople = "                + numPersonsSnack.Value                                        + ", " +
                "SnackServingsPerPerson = "     + numServingsSnack.Value                                       + " " +

                "WHERE ROWID = 1;";
            
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}

struct Recipe
{
    #region Enums
    [Flags]
    public enum RecipeType { BREAKFAST = 1, BRUNCH = 2, LUNCH = 4, DINNER = 8, SUPPER = 16, SNACK = 32 };
    #endregion

    #region Fields
    public string Name, Ingredients, Directions; // ATTN: COME BACK LATER AND CHANGE THE INGREDIENTS FIELD TO A LIST OF INGREDIENT STRUCTS
    public int CookTime, PrepTime, Servings;
    public bool RequiresPrep;
    public RecipeType Type;
    #endregion

    #region Constructors
    public Recipe(string name, string ingredients, string directions, int cookTime, int prepTime, int servings, bool requiresPrep, RecipeType type)
    {
        Name = name;
        Ingredients = ingredients;
        Directions = directions;
        CookTime = cookTime;
        PrepTime = prepTime;
        Servings = servings;
        RequiresPrep = requiresPrep;
        Type = type;
    }
    #endregion
}

struct Ingredient
{
    #region Fields
    public string Name, Measurement;
    public double Amount;
    #endregion

    #region Constructors
    public Ingredient(string amount, string measurement, string name)
    {
        Name = name;
        Measurement = measurement;
        Amount = 0;
    }
    #endregion

    #region Methods
    private double ParseDouble(string s)
    {
        double d = 0;

        return d;
    }
    #endregion
}
