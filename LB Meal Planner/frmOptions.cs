using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_Meal_Planner
{
    public partial class frmOptions : Form
    {
        #region Members
        SQLiteConnection con;
        frmMain parentForm;
        #endregion

        #region Constructors
        public frmOptions(SQLiteConnection con, frmMain parentForm)
        {
            InitializeComponent();
            this.con = con;
            this.parentForm = parentForm;
        }
        #endregion

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really sure you want to clear the entire recipe database?",
                "Clear Recipe Database", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "DELETE FROM `recipes`";
                cmd.ExecuteNonQuery();
                parentForm.PopulateListbox();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all of your user data including past meal generation options? (Though not including calendar credentials.)",
               "Clear User Data", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "DELETE FROM `userprefs`; INSERT INTO `userprefs` DEFAULT VALUES;";
                cmd.ExecuteNonQuery();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string credentialsPath = "credentials.json";

            if (MessageBox.Show("Are you sure you want to clear your Google Calendar credentials? You will be prompted to sign into a new Google account and authorize this program again if you choose 'Yes'.",
                "Clear Calendar Credentials", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (File.Exists(credentialsPath))
                {
                    File.Delete(credentialsPath);
                    Console.WriteLine("Deleted.");
                    // Regen your calendar credentials
                }
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = String.Format("UPDATE `userprefs` SET CalendarURL = '{0}' WHERE ROWID = 1", txtCalendarURL.Text);
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
