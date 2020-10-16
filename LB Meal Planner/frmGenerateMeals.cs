using System;
using System.Windows.Forms;

namespace LB_Meal_Planner
{
    public partial class frmGenerateMeals : Form
    {
        public frmGenerateMeals()
        {
            InitializeComponent();

            // Initialize the meal rows by enabling / disabling them based on the row's checkmark
            if (chkBreakfast.Checked) { timeBreakfast.Enabled = true; numPersonsBreakfast.Enabled = true; numServingsBreakfast.Enabled = true; } else { timeBreakfast.Enabled = false; numPersonsBreakfast.Enabled = false; numServingsBreakfast.Enabled = false; }
            if (chkBrunch.Checked) { timeBrunch.Enabled = true; numPersonsBrunch.Enabled = true; numServingsBrunch.Enabled = true; } else { timeBrunch.Enabled = false; numPersonsBrunch.Enabled = false; numServingsBrunch.Enabled = false; }
            if (chkLunch.Checked) { timeLunch.Enabled = true; numPersonsLunch.Enabled = true; numServingsLunch.Enabled = true; } else { timeLunch.Enabled = false; numPersonsLunch.Enabled = false; numServingsLunch.Enabled = false; }
            if (chkDinner.Checked) { timeDinner.Enabled = true; numPersonsDinner.Enabled = true; numServingsDinner.Enabled = true; } else { timeDinner.Enabled = false; numPersonsDinner.Enabled = false; numServingsDinner.Enabled = false; }
            if (chkSupper.Checked) { timeSupper.Enabled = true; numPersonsSupper.Enabled = true; numServingsSupper.Enabled = true; } else { timeSupper.Enabled = false; numPersonsSupper.Enabled = false; numServingsSupper.Enabled = false; }
            if (chkSnack.Checked) { timeSnack.Enabled = true; numPersonsSnack.Enabled = true; numServingsSnack.Enabled = true; } else { timeSnack.Enabled = false; numPersonsSnack.Enabled = false; numServingsSnack.Enabled = false; }
        }

        // Toggle the correct controls when the checkmarks are altered.
        private void chkBreakfast_CheckedChanged(object sender, EventArgs e)
        { timeBreakfast.Enabled = !timeBreakfast.Enabled; numPersonsBreakfast.Enabled = !numPersonsBreakfast.Enabled; numServingsBreakfast.Enabled = !numServingsBreakfast.Enabled; }
        private void chkBrunch_CheckedChanged(object sender, EventArgs e)
        { timeBrunch.Enabled = !timeBrunch.Enabled; numPersonsBrunch.Enabled = !numPersonsBrunch.Enabled; numServingsBrunch.Enabled = !numServingsBrunch.Enabled; }
        private void chkLunch_CheckedChanged(object sender, EventArgs e)
        { timeLunch.Enabled = !timeLunch.Enabled; numPersonsLunch.Enabled = !numPersonsLunch.Enabled; numServingsLunch.Enabled = !numServingsLunch.Enabled; }
        private void chkDinner_CheckedChanged(object sender, EventArgs e)
        { timeDinner.Enabled = !timeDinner.Enabled; numPersonsDinner.Enabled = !numPersonsDinner.Enabled; numServingsDinner.Enabled = !numServingsDinner.Enabled; }
        private void chkSupper_CheckedChanged(object sender, EventArgs e)
        { timeSupper.Enabled = !timeSupper.Enabled; numPersonsSupper.Enabled = !numPersonsSupper.Enabled; numServingsSupper.Enabled = !numServingsSupper.Enabled; }
        private void chkSnack_CheckedChanged(object sender, EventArgs e)
        { timeSnack.Enabled = !timeSnack.Enabled; numPersonsSnack.Enabled = !numPersonsSnack.Enabled; numServingsSnack.Enabled = !numServingsSnack.Enabled; }

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
    }
}
