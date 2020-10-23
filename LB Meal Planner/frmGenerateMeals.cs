using System;
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
            numGenerateDays.Value = rdr.GetInt16(1);
            numAlternateMeals.Value = rdr.GetInt16(2);
            chkGenerateGroceryList.Checked = (rdr.GetInt16(3) == 1) ? true : false;

            int minutes, hours;
            chkBreakfast.Checked = (rdr.GetInt16(4) == 1) ? true : false;
            minutes = rdr.GetInt32(4 + 6); hours = minutes / 60; minutes %= 60;
            timeBreakfast.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsBreakfast.Value = rdr.GetInt16(4 + 12);
            numServingsBreakfast.Value = rdr.GetInt16(4 + 18);

            chkBrunch.Checked = (rdr.GetInt16(5) == 1) ? true : false;
            minutes = rdr.GetInt32(5 + 6); hours = minutes / 60; minutes %= 60;
            timeBrunch.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsBrunch.Value = rdr.GetInt16(5 + 12);
            numServingsBrunch.Value = rdr.GetInt16(5 + 18);
            
            chkLunch.Checked = (rdr.GetInt16(6) == 1) ? true : false;
            minutes = rdr.GetInt32(6 + 6); hours = minutes / 60; minutes %= 60;
            timeLunch.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsLunch.Value = rdr.GetInt16(6 + 12);
            numServingsLunch.Value = rdr.GetInt16(6 + 18);

            chkDinner.Checked = (rdr.GetInt16(7) == 1) ? true : false;
            minutes = rdr.GetInt32(7 + 6); hours = minutes / 60; minutes %= 60;
            timeDinner.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsDinner.Value = rdr.GetInt16(7 + 12);
            numServingsDinner.Value = rdr.GetInt16(7 + 18);

            chkSupper.Checked = (rdr.GetInt16(8) == 1) ? true : false;
            minutes = rdr.GetInt32(8 + 6); hours = minutes / 60; minutes %= 60;
            timeSupper.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsSupper.Value = rdr.GetInt16(8 + 12);
            numServingsSupper.Value = rdr.GetInt16(8 + 18);

            chkSnack.Checked = (rdr.GetInt16(9) == 1) ? true : false;
            minutes = rdr.GetInt32(9 + 6); hours = minutes / 60; minutes %= 60;
            timeSnack.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            numPersonsSnack.Value = rdr.GetInt16(9 + 12);
            numServingsSnack.Value = rdr.GetInt16(9 + 18);
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
                // Generate Meals
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
                "GenerateForDays = "                + numGenerateDays.Value                                         + ", " +
                "NumberOfDiffMeals = "              + numAlternateMeals.Value                                       + ", " +
                "GenerateGroceryList = "            + (chkGenerateGroceryList.Checked ? 1 : 0)                      + ", " +
                
                "BreakfastChk = "                   + (chkBreakfast.Checked ? 1 : 0)                                + ", " +
                "BreakfastTime = "                  + (timeBreakfast.Value.Hour * 60 + timeBreakfast.Value.Minute)  + ", " +
                "BreakfastPeople = "                + numPersonsBreakfast.Value                                     + ", " +
                "BreakfastServingsPerPerson = "     + numServingsBreakfast.Value                                    + ", " +
                
                "BrunchChk = "                      + (chkBrunch.Checked ? 1 : 0)                                   + ", " +
                "BrunchTime = "                     + (timeBrunch.Value.Hour * 60 + timeBrunch.Value.Minute)        + ", " +
                "BrunchPeople = "                   + numPersonsBrunch.Value                                        + ", " +
                "BrunchServingsPerPerson = "        + numServingsBrunch.Value                                       + ", " +
                
                "LunchChk = "                       + (chkLunch.Checked ? 1 : 0)                                    + ", " +
                "LunchTime = "                      + (timeLunch.Value.Hour * 60 + timeLunch.Value.Minute)          + ", " +
                "LunchPeople = "                    + numPersonsLunch.Value                                         + ", " +
                "LunchServingsPerPerson = "         + numServingsLunch.Value                                        + ", " +

                "DinnerChk = "                      + (chkDinner.Checked ? 1 : 0)                                   + ", " +
                "DinnerTime = "                     + (timeDinner.Value.Hour * 60 + timeDinner.Value.Minute)        + ", " +
                "DinnerPeople = "                   + numPersonsDinner.Value                                        + ", " +
                "DinnerServingsPerPerson = "        + numServingsDinner.Value                                       + ", " +

                "SupperChk = "                      + (chkSupper.Checked ? 1 : 0)                                   + ", " +
                "SupperTime = "                     + (timeSupper.Value.Hour * 60 + timeSupper.Value.Minute)        + ", " +
                "SupperPeople = "                   + numPersonsSupper.Value                                        + ", " +
                "SupperServingsPerPerson = "        + numServingsSupper.Value                                       + ", " +

                "SnackChk = "                       + (chkSnack.Checked ? 1 : 0)                                    + ", " +
                "SnackTime = "                      + (timeSnack.Value.Hour * 60 + timeSnack.Value.Minute)          + ", " +
                "SnackPeople = "                    + numPersonsSnack.Value                                         + ", " +
                "SnackServingsPerPerson = "         + numServingsSnack.Value                                        + " " +

                "WHERE ROWID = 1;";
            
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
