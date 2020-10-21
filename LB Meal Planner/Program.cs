using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace LB_Meal_Planner
{
    static class Program
    {
        #region Main
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (InitializeDatabase() == 1)
                return;
            
            Application.Run(new frmMain());
        }
        #endregion

        #region Methods
        private static int InitializeDatabase()
        {
            string dbName = "database.db";
            SQLiteConnection con;

            if (!File.Exists(dbName))
            {
                // Generate a fresh database
                SQLiteConnection.CreateFile(dbName);
                con = new SQLiteConnection(@"URI=file:" + dbName);
                con.Open();
                string sqlCreateTableRecipes = "CREATE TABLE `recipes` (" +
                    "RecipeName text DEFAULT ''," +
                    "RecipeType int DEFAULT 0," +
                    "PickMe int DEFAULT 1," +
                    "CookTime int DEFAULT 0," +
                    "RequiresPrep int DEFAULT 0," +
                    "PrepTime int DEFAULT 0," +
                    "Servings int DEFAULT 4," +
                    "Ingredients varchar(1000) DEFAULT ''," +
                    "Directions varchar(1000) DEFAULT ''" +
                    ");";

                string sqlCreateTableUserPrefs = "CREATE TABLE `userprefs` (" +
                    "CalendarURL varchar(1000) DEFAULT 'primary'," +
                    "GenerateForDays int DEFAULT 7," +
                    "NumberOfDiffMeals int DEFAULT 2," +
                    "GenerateGroceryList int DEFAULT 0," +
                    "BreakfastChk int DEFAULT 0,BrunchChk int DEFAULT 0,LunchChk int DEFAULT 0,DinnerChk int DEFAULT 0,SupperChk int DEFAULT 0,SnackChk int DEFAULT 0," +
                    "BreakfastTime int DEFAULT 0,BrunchTime int DEFAULT 0,LunchTime int DEFAULT 0,DinnerTime int DEFAULT 0,SupperTime int DEFAULT 0,SnackTime int DEFAULT 0," +
                    "BreakfastPeople int DEFAULT 1,BrunchPeople int DEFAULT 1,LunchPeople int DEFAULT 1,DinnerPeople int DEFAULT 1,SupperPeople int DEFAULT 1,SnackPeople int DEFAULT 1," +
                    "BreakfastServingsPerPerson int DEFAULT 1,BrunchServingsPerPerson int DEFAULT 1,LunchServingsPerPerson int DEFAULT 1,DinnerServingsPerPerson int DEFAULT 1,SupperServingsPerPerson int DEFAULT 1,SnackServingsPerPerson int DEFAULT 1" +
                    "); INSERT INTO `userprefs` DEFAULT VALUES;";

                var cmd = new SQLiteCommand(con);
                cmd.CommandText = sqlCreateTableRecipes;
                cmd.ExecuteNonQuery();
                cmd.CommandText = sqlCreateTableUserPrefs;
                cmd.ExecuteNonQuery();

                con.Close();
            }

            try
            {
                // Load the database
                con = new SQLiteConnection(@"URI=file:" + dbName);
                con.Open();

                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT * FROM `userprefs`";
                cmd.ExecuteNonQuery();

                con.Close();
                return 0;
            }
            catch
            {
                MessageBox.Show("Database invalid somehow.  Please delete database.db and re-run program to generate a new one.",
                    "Database Read Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return 1;
            }
        }
        #endregion
    }
}
