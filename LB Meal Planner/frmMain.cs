using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace LB_Meal_Planner
{
    public partial class frmMain : Form
    {
        #region Enums
        private enum SortMode { NONE, ASCENDING, DESCENDING };
        #endregion

        #region Members
        string dbName = "database.db";
        SQLiteConnection con;
        SortMode sortMode = SortMode.NONE;
        #endregion

        #region Constructors
        public frmMain()
        {
            InitializeComponent();
            
            // Open an SQLite connection
            con = new SQLiteConnection(@"URI=file:" + dbName);
            con.Open();

            PopulateListbox();
        }
        #endregion

        #region Methods
        public void PopulateListbox()
        {
            // Clear the listbox if it's full
            chklstRecipes.Items.Clear();

            // Fill the listbox with all of the recipes in the database
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT ROWID, RecipeName, PickMe FROM `recipes`";

            switch (sortMode)
            {
                case SortMode.NONE:
                    break;
                case SortMode.ASCENDING:
                    cmd.CommandText += " ORDER BY RecipeName ASC";
                    break;
                case SortMode.DESCENDING:
                    cmd.CommandText += " ORDER BY RecipeName DESC";
                    break;
            }

            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                chklstRecipes.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1),
                    rdr.GetInt32(2) == 1 ? true : false);
            }

            tbtnEditRecipe.Enabled = false; tbtnDeleteRecipe.Enabled = false; tbtnSave.Enabled = false;
        }
        
        private void AddRecipe()
        {
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO `recipes` DEFAULT VALUES; SELECT ROWID FROM `recipes` ORDER BY ROWID DESC;";
            var rdr = cmd.ExecuteReader();
            rdr.Read();
            new frmRecipeView(this, con, rdr.GetInt32(0)).ShowDialog();
        }
        
        private void EditRecipe()
        {
            if (chklstRecipes.SelectedItem == null)
            {
                tbtnEditRecipe.Enabled = false;
                return;
            }

            // Figure out the ROWID of the recipe & send it to a new RecipeView form using that data
            string s = chklstRecipes.SelectedItem.ToString();
            s = s.Split('-')[0];
            int i = Int32.Parse(s);
            new frmRecipeView(this, con, i).ShowDialog();
        }

        private void DeleteRecipe()
        {
            if (chklstRecipes.SelectedItem == null)
            {
                tbtnDeleteRecipe.Enabled = false;
                return;
            }

            string s = chklstRecipes.SelectedItem.ToString();
            s = s.Split('-')[0];
            int id = Int32.Parse(s);

            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT RecipeName FROM `recipes` WHERE ROWID = " + id;
            var rdr = cmd.ExecuteReader();
            rdr.Read();

            if (MessageBox.Show(String.Format("Are you sure you want to delete the recipe for {0}?", rdr.GetString(0)), "Delete record?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd = new SQLiteCommand(con);
                cmd.CommandText = "DELETE FROM `recipes` WHERE ROWID = " + id;
                cmd.ExecuteNonQuery();
                PopulateListbox();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Events
        private void chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstRecipes.Items.Count; i++)
                chklstRecipes.SetItemChecked(i, chkCheckAll.Checked);

            tbtnSave.Enabled = true;
        }

        private void chklstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbtnSave.Enabled = true;
            tbtnEditRecipe.Enabled = true;
            tbtnDeleteRecipe.Enabled = true;
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < chklstRecipes.Items.Count; index++)
            {
                string s = chklstRecipes.Items[index].ToString();
                s = s.Split('-')[0];
                int id = Int32.Parse(s);

                var cmd = new SQLiteCommand(con);
                cmd.CommandText = String.Format("UPDATE `recipes` SET PickMe = {0} WHERE ROWID = {1}\n",
                    chklstRecipes.GetItemChecked(index) ? 1 : 0,
                    id);
                cmd.ExecuteNonQuery();
            }

            tbtnSave.Enabled = false;
        }

        private void tbtnSettings_Click(object sender, EventArgs e)
        {
            new frmOptions(con, this).ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            new frmGenerateMeals().ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            EditRecipe();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmOptions(con, this).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateMealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGenerateMeals().ShowDialog();
        }

        private void tbtnAddRecipe_Click(object sender, EventArgs e)
        {
            AddRecipe();
        }

        private void tbtnSortClear_Click(object sender, EventArgs e)
        {
            this.sortMode = SortMode.NONE;
            PopulateListbox();
        }

        private void tbtnSortAscending_Click(object sender, EventArgs e)
        {
            this.sortMode = SortMode.ASCENDING;
            PopulateListbox();
        }

        private void tbtnSortDescending_Click(object sender, EventArgs e)
        {
            this.sortMode = SortMode.DESCENDING;
            PopulateListbox();
        }

        private void tbtnDeleteRecipe_Click(object sender, EventArgs e)
        {
            DeleteRecipe();
        }

        private void addRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecipe();
        }

        private void deleteRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRecipe();
        }

        private void editRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRecipe();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            con.Close();
        }
        #endregion        
    }
}
