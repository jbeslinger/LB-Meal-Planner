using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LB_Meal_Planner
{
    public partial class frmRecipeView : Form
    {
        #region Members
        frmMain parentForm;
        SQLiteConnection con;
        int recipeID;
        #endregion

        #region Constructors
        public frmRecipeView(frmMain parentForm, SQLiteConnection c, int recipeID)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.con = c;
            this.recipeID = recipeID;

            // Fill in the form with data from the database
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM `recipes` WHERE ROWID = " + recipeID + " LIMIT 1";
            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr.ToString());
                txtRecipeName.Text = rdr.GetString(0);
                numServings.Value = rdr.GetInt32(6);
                txtDirections.Text = rdr.GetString(8);

                int timeInMinutes = rdr.GetInt32(3);
                numCookHours.Value = timeInMinutes / 60;
                numCookMinutes.Value = timeInMinutes % 60;

                chkPrepTime.Checked = rdr.GetInt16(4) == 0 ? false : true;
                if (chkPrepTime.Checked)
                {
                    timeInMinutes = rdr.GetInt32(5);
                    numPrepHours.Value = timeInMinutes / 60;
                    numPrepMinutes.Value = timeInMinutes % 60;
                }

                // The meal type is a base 2 number in decimal form.
                // This section turns each sequential bit into flags for the checklist of items.
                // For instance, 1001 means the 0th and 3rd list items should be checked true.
                byte mealType = (byte) rdr.GetInt16(1);
                for (int b = 0; b < 6; b++)
                {
                    if ((mealType & (1 << b)) != 0) { chklstCanBeServed.SetItemChecked(b, true); }
                }

                // The ingredients are stored in one field of each record.
                // They are separated by commas; then semicolons separate amounts, names, and measurements.
                string[] ingredients = rdr.GetString(7).Split(',');
                if (ingredients[0] != "")
                {
                    foreach (string s in ingredients)
                    {
                        string[] components = s.Split(';');
                        datagridIngredients.Rows.Add(new object[] { components[0], components[1], components[2] });
                    }
                }

                chkPickMeForGen.Checked = rdr.GetInt16(2) == 0 ? false : true;
            }
        }
        #endregion

        #region Methods

        #endregion

        #region Events
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string ingredientsList = "";
            foreach (DataGridViewRow r in datagridIngredients.Rows)
            {
                if (r.Index + 1 == datagridIngredients.Rows.Count)
                    break;

                if (r.Cells[0].Value == null || r.Cells[1].Value == null || r.Cells[2].Value == null)
                {
                    MessageBox.Show("Please don't leave boxes empty in the data grid.", "Empty DataGrid Cells", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ingredientsList += r.Cells[0].Value.ToString() + ";" + r.Cells[1].Value.ToString() + ";" + r.Cells[2].Value.ToString();
                if (r.Index + 2 != datagridIngredients.Rows.Count) // Is it not the last row in the datagrid?
                    ingredientsList += ","; // Comma separate
            }

            byte recipeType = 0;
            for (int b = 0; b < 6; b++)
                if (chklstCanBeServed.GetItemChecked(b)) { recipeType = (byte)(recipeType | (1 << b)); }

            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE `recipes` " +
                "SET RecipeName = '" + txtRecipeName.Text + "', " +
                "RecipeType = " + recipeType + ", " +
                "PickMe = " + (chkPickMeForGen.Checked ? 1 : 0) + ", " +
                "CookTime = " + ((numCookHours.Value * 60) + numCookMinutes.Value) + ", " +
                "RequiresPrep = " + (chkPrepTime.Checked ? 1 : 0) + ", " +
                "PrepTime = " + ((numPrepHours.Value * 60) + numPrepMinutes.Value) + ", " +
                "Servings = " + numServings.Value + ", " +
                "Ingredients = '" + ingredientsList + "', " +
                "Directions = '" + txtDirections.Text + "' " +
                "WHERE ROWID = " + recipeID;
            cmd.ExecuteNonQuery();

            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pnlIngredientsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkPrepTime_CheckedChanged(object sender, System.EventArgs e)
        {
            numPrepHours.Enabled = !numPrepHours.Enabled;
            numPrepMinutes.Enabled = !numPrepMinutes.Enabled;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT RecipeName FROM `recipes` WHERE ROWID = " + recipeID;
            var rdr = cmd.ExecuteReader();
            rdr.Read();

            if (MessageBox.Show(String.Format("Are you sure you want to delete the recipe for {0}?", rdr.GetString(0)), "Delete record?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd = new SQLiteCommand(con);
                cmd.CommandText = "DELETE FROM `recipes` WHERE ROWID = " + recipeID;
                cmd.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                return;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            parentForm.PopulateListbox();
        }
        #endregion
    }
}
