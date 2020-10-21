using System;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LB_Meal_Planner
{
    public partial class frmOptions : Form
    {
        #region Members
        SQLiteConnection con;
        frmMain parentForm;

        Regex regex = new Regex(@"^https:\/\/calendar\.google\.com\/calendar\/ical\/*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        #endregion

        #region Constructors
        public frmOptions(SQLiteConnection con, frmMain parentForm)
        {
            InitializeComponent();
            this.con = con;
            this.parentForm = parentForm;

            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT CalendarURL FROM `userprefs` WHERE ROWID = 1";
            var rdr = cmd.ExecuteReader();
            rdr.Read();

            txtCalendarURL.Text = rdr.GetString(0);
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
            string url = txtCalendarURL.Text;
            var matches = regex.Matches(url);

            if (url == "")
            { url = "primary"; }
            else if (url == "primary")
            { }
            else if (matches.Count == 0)
            {
                MessageBox.Show("This is not a valid Google Calendar address. " +
                    "If you don't have a valid iCal address you may leave the textbox blank or type 'primary' to use your default calendar.",
                    "Calendar URL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var cmd = new SQLiteCommand(con);
            cmd.CommandText = String.Format("UPDATE `userprefs` SET CalendarURL = '{0}' WHERE ROWID = 1", url);
            cmd.ExecuteNonQuery();
            
            base.OnFormClosing(e);
        }
        #endregion
    }
}
