namespace LB_Meal_Planner
{
    partial class frmGenerateMeals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblHowManyDays = new System.Windows.Forms.Label();
            this.txtHowManyDays = new System.Windows.Forms.TextBox();
            this.txtHowManyMeals = new System.Windows.Forms.TextBox();
            this.lblHowManyMeals = new System.Windows.Forms.Label();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.horizontalDivider = new System.Windows.Forms.Label();
            this.dateStartThisDay = new System.Windows.Forms.DateTimePicker();
            this.lblStartThisDay = new System.Windows.Forms.Label();
            this.timeBreakfast = new System.Windows.Forms.DateTimePicker();
            this.numServingsBreakfast = new System.Windows.Forms.NumericUpDown();
            this.numPersonsBreakfast = new System.Windows.Forms.NumericUpDown();
            this.lblMeal = new System.Windows.Forms.Label();
            this.lblTimeToEat = new System.Windows.Forms.Label();
            this.lblPersons = new System.Windows.Forms.Label();
            this.lblServings = new System.Windows.Forms.Label();
            this.numPersonsBrunch = new System.Windows.Forms.NumericUpDown();
            this.numServingsBrunch = new System.Windows.Forms.NumericUpDown();
            this.timeBrunch = new System.Windows.Forms.DateTimePicker();
            this.chkBrunch = new System.Windows.Forms.CheckBox();
            this.numPersonsDinner = new System.Windows.Forms.NumericUpDown();
            this.numServingsDinner = new System.Windows.Forms.NumericUpDown();
            this.timeDinner = new System.Windows.Forms.DateTimePicker();
            this.chkDinner = new System.Windows.Forms.CheckBox();
            this.numPersonsLunch = new System.Windows.Forms.NumericUpDown();
            this.numServingsLunch = new System.Windows.Forms.NumericUpDown();
            this.timeLunch = new System.Windows.Forms.DateTimePicker();
            this.chkLunch = new System.Windows.Forms.CheckBox();
            this.numPersonsSnack = new System.Windows.Forms.NumericUpDown();
            this.numServingsSnack = new System.Windows.Forms.NumericUpDown();
            this.timeSnack = new System.Windows.Forms.DateTimePicker();
            this.chkSnack = new System.Windows.Forms.CheckBox();
            this.numPersonsSupper = new System.Windows.Forms.NumericUpDown();
            this.numServingsSupper = new System.Windows.Forms.NumericUpDown();
            this.timeSupper = new System.Windows.Forms.DateTimePicker();
            this.chkSupper = new System.Windows.Forms.CheckBox();
            this.chkGenerateGroceryList = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsBreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsBreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsBrunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsBrunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsSnack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsSnack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsSupper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsSupper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(356, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(275, 320);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblHowManyDays
            // 
            this.lblHowManyDays.AutoSize = true;
            this.lblHowManyDays.Location = new System.Drawing.Point(13, 13);
            this.lblHowManyDays.Name = "lblHowManyDays";
            this.lblHowManyDays.Size = new System.Drawing.Size(138, 13);
            this.lblHowManyDays.TabIndex = 2;
            this.lblHowManyDays.Text = "Generate for this many days";
            // 
            // txtHowManyDays
            // 
            this.txtHowManyDays.Location = new System.Drawing.Point(157, 10);
            this.txtHowManyDays.Name = "txtHowManyDays";
            this.txtHowManyDays.Size = new System.Drawing.Size(100, 20);
            this.txtHowManyDays.TabIndex = 0;
            // 
            // txtHowManyMeals
            // 
            this.txtHowManyMeals.Location = new System.Drawing.Point(230, 39);
            this.txtHowManyMeals.Name = "txtHowManyMeals";
            this.txtHowManyMeals.Size = new System.Drawing.Size(100, 20);
            this.txtHowManyMeals.TabIndex = 1;
            // 
            // lblHowManyMeals
            // 
            this.lblHowManyMeals.AutoSize = true;
            this.lblHowManyMeals.Location = new System.Drawing.Point(13, 42);
            this.lblHowManyMeals.Name = "lblHowManyMeals";
            this.lblHowManyMeals.Size = new System.Drawing.Size(211, 13);
            this.lblHowManyMeals.TabIndex = 4;
            this.lblHowManyMeals.Text = "Alternate between this many different meals";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(12, 165);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(71, 17);
            this.chkBreakfast.TabIndex = 5;
            this.chkBreakfast.Text = "Breakfast";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            this.chkBreakfast.CheckedChanged += new System.EventHandler(this.chkBreakfast_CheckedChanged);
            // 
            // horizontalDivider
            // 
            this.horizontalDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalDivider.Location = new System.Drawing.Point(7, 126);
            this.horizontalDivider.Name = "horizontalDivider";
            this.horizontalDivider.Size = new System.Drawing.Size(430, 2);
            this.horizontalDivider.TabIndex = 7;
            // 
            // dateStartThisDay
            // 
            this.dateStartThisDay.Location = new System.Drawing.Point(102, 69);
            this.dateStartThisDay.Name = "dateStartThisDay";
            this.dateStartThisDay.Size = new System.Drawing.Size(200, 20);
            this.dateStartThisDay.TabIndex = 3;
            // 
            // lblStartThisDay
            // 
            this.lblStartThisDay.AutoSize = true;
            this.lblStartThisDay.Location = new System.Drawing.Point(13, 72);
            this.lblStartThisDay.Name = "lblStartThisDay";
            this.lblStartThisDay.Size = new System.Drawing.Size(83, 13);
            this.lblStartThisDay.TabIndex = 9;
            this.lblStartThisDay.Text = "Start on this day";
            // 
            // timeBreakfast
            // 
            this.timeBreakfast.CustomFormat = "hh:mm";
            this.timeBreakfast.Enabled = false;
            this.timeBreakfast.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeBreakfast.Location = new System.Drawing.Point(112, 163);
            this.timeBreakfast.Name = "timeBreakfast";
            this.timeBreakfast.ShowUpDown = true;
            this.timeBreakfast.Size = new System.Drawing.Size(88, 20);
            this.timeBreakfast.TabIndex = 6;
            this.timeBreakfast.Value = new System.DateTime(2020, 9, 21, 9, 0, 0, 0);
            // 
            // numServingsBreakfast
            // 
            this.numServingsBreakfast.Enabled = false;
            this.numServingsBreakfast.Location = new System.Drawing.Point(336, 162);
            this.numServingsBreakfast.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numServingsBreakfast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServingsBreakfast.Name = "numServingsBreakfast";
            this.numServingsBreakfast.Size = new System.Drawing.Size(56, 20);
            this.numServingsBreakfast.TabIndex = 8;
            this.numServingsBreakfast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numServingsBreakfast.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numPersonsBreakfast
            // 
            this.numPersonsBreakfast.Enabled = false;
            this.numPersonsBreakfast.Location = new System.Drawing.Point(228, 163);
            this.numPersonsBreakfast.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonsBreakfast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonsBreakfast.Name = "numPersonsBreakfast";
            this.numPersonsBreakfast.Size = new System.Drawing.Size(56, 20);
            this.numPersonsBreakfast.TabIndex = 7;
            this.numPersonsBreakfast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPersonsBreakfast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeal.Location = new System.Drawing.Point(27, 140);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(30, 13);
            this.lblMeal.TabIndex = 18;
            this.lblMeal.Text = "Meal";
            this.lblMeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeToEat
            // 
            this.lblTimeToEat.AutoSize = true;
            this.lblTimeToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeToEat.Location = new System.Drawing.Point(125, 140);
            this.lblTimeToEat.Name = "lblTimeToEat";
            this.lblTimeToEat.Size = new System.Drawing.Size(61, 13);
            this.lblTimeToEat.TabIndex = 19;
            this.lblTimeToEat.Text = "Time to Eat";
            this.lblTimeToEat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersons
            // 
            this.lblPersons.AutoSize = true;
            this.lblPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersons.Location = new System.Drawing.Point(233, 140);
            this.lblPersons.Name = "lblPersons";
            this.lblPersons.Size = new System.Drawing.Size(45, 13);
            this.lblPersons.TabIndex = 20;
            this.lblPersons.Text = "Persons";
            this.lblPersons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServings.Location = new System.Drawing.Point(313, 140);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(102, 13);
            this.lblServings.TabIndex = 21;
            this.lblServings.Text = "Servings per Person";
            this.lblServings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPersonsBrunch
            // 
            this.numPersonsBrunch.Enabled = false;
            this.numPersonsBrunch.Location = new System.Drawing.Point(228, 189);
            this.numPersonsBrunch.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonsBrunch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonsBrunch.Name = "numPersonsBrunch";
            this.numPersonsBrunch.Size = new System.Drawing.Size(56, 20);
            this.numPersonsBrunch.TabIndex = 11;
            this.numPersonsBrunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPersonsBrunch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numServingsBrunch
            // 
            this.numServingsBrunch.Enabled = false;
            this.numServingsBrunch.Location = new System.Drawing.Point(336, 188);
            this.numServingsBrunch.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numServingsBrunch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServingsBrunch.Name = "numServingsBrunch";
            this.numServingsBrunch.Size = new System.Drawing.Size(56, 20);
            this.numServingsBrunch.TabIndex = 12;
            this.numServingsBrunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numServingsBrunch.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // timeBrunch
            // 
            this.timeBrunch.CustomFormat = "hh:mm";
            this.timeBrunch.Enabled = false;
            this.timeBrunch.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeBrunch.Location = new System.Drawing.Point(112, 189);
            this.timeBrunch.Name = "timeBrunch";
            this.timeBrunch.ShowUpDown = true;
            this.timeBrunch.Size = new System.Drawing.Size(88, 20);
            this.timeBrunch.TabIndex = 10;
            this.timeBrunch.Value = new System.DateTime(2020, 9, 21, 10, 0, 0, 0);
            // 
            // chkBrunch
            // 
            this.chkBrunch.AutoSize = true;
            this.chkBrunch.Location = new System.Drawing.Point(12, 191);
            this.chkBrunch.Name = "chkBrunch";
            this.chkBrunch.Size = new System.Drawing.Size(60, 17);
            this.chkBrunch.TabIndex = 9;
            this.chkBrunch.Text = "Brunch";
            this.chkBrunch.UseVisualStyleBackColor = true;
            this.chkBrunch.CheckedChanged += new System.EventHandler(this.chkBrunch_CheckedChanged);
            // 
            // numPersonsDinner
            // 
            this.numPersonsDinner.Enabled = false;
            this.numPersonsDinner.Location = new System.Drawing.Point(228, 241);
            this.numPersonsDinner.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonsDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonsDinner.Name = "numPersonsDinner";
            this.numPersonsDinner.Size = new System.Drawing.Size(56, 20);
            this.numPersonsDinner.TabIndex = 19;
            this.numPersonsDinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPersonsDinner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numServingsDinner
            // 
            this.numServingsDinner.Enabled = false;
            this.numServingsDinner.Location = new System.Drawing.Point(336, 240);
            this.numServingsDinner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numServingsDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServingsDinner.Name = "numServingsDinner";
            this.numServingsDinner.Size = new System.Drawing.Size(56, 20);
            this.numServingsDinner.TabIndex = 20;
            this.numServingsDinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numServingsDinner.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // timeDinner
            // 
            this.timeDinner.CustomFormat = "hh:mm";
            this.timeDinner.Enabled = false;
            this.timeDinner.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDinner.Location = new System.Drawing.Point(112, 241);
            this.timeDinner.Name = "timeDinner";
            this.timeDinner.ShowUpDown = true;
            this.timeDinner.Size = new System.Drawing.Size(88, 20);
            this.timeDinner.TabIndex = 18;
            this.timeDinner.Value = new System.DateTime(2020, 9, 21, 17, 0, 0, 0);
            // 
            // chkDinner
            // 
            this.chkDinner.AutoSize = true;
            this.chkDinner.Location = new System.Drawing.Point(12, 243);
            this.chkDinner.Name = "chkDinner";
            this.chkDinner.Size = new System.Drawing.Size(57, 17);
            this.chkDinner.TabIndex = 17;
            this.chkDinner.Text = "Dinner";
            this.chkDinner.UseVisualStyleBackColor = true;
            this.chkDinner.CheckedChanged += new System.EventHandler(this.chkDinner_CheckedChanged);
            // 
            // numPersonsLunch
            // 
            this.numPersonsLunch.Enabled = false;
            this.numPersonsLunch.Location = new System.Drawing.Point(228, 215);
            this.numPersonsLunch.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonsLunch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonsLunch.Name = "numPersonsLunch";
            this.numPersonsLunch.Size = new System.Drawing.Size(56, 20);
            this.numPersonsLunch.TabIndex = 15;
            this.numPersonsLunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPersonsLunch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numServingsLunch
            // 
            this.numServingsLunch.Enabled = false;
            this.numServingsLunch.Location = new System.Drawing.Point(336, 214);
            this.numServingsLunch.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numServingsLunch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServingsLunch.Name = "numServingsLunch";
            this.numServingsLunch.Size = new System.Drawing.Size(56, 20);
            this.numServingsLunch.TabIndex = 16;
            this.numServingsLunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numServingsLunch.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // timeLunch
            // 
            this.timeLunch.CustomFormat = "hh:mm";
            this.timeLunch.Enabled = false;
            this.timeLunch.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeLunch.Location = new System.Drawing.Point(112, 215);
            this.timeLunch.Name = "timeLunch";
            this.timeLunch.ShowUpDown = true;
            this.timeLunch.Size = new System.Drawing.Size(88, 20);
            this.timeLunch.TabIndex = 14;
            this.timeLunch.Value = new System.DateTime(2020, 9, 21, 13, 0, 0, 0);
            // 
            // chkLunch
            // 
            this.chkLunch.AutoSize = true;
            this.chkLunch.Location = new System.Drawing.Point(12, 217);
            this.chkLunch.Name = "chkLunch";
            this.chkLunch.Size = new System.Drawing.Size(56, 17);
            this.chkLunch.TabIndex = 13;
            this.chkLunch.Text = "Lunch";
            this.chkLunch.UseVisualStyleBackColor = true;
            this.chkLunch.CheckedChanged += new System.EventHandler(this.chkLunch_CheckedChanged);
            // 
            // numPersonsSnack
            // 
            this.numPersonsSnack.Enabled = false;
            this.numPersonsSnack.Location = new System.Drawing.Point(228, 293);
            this.numPersonsSnack.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonsSnack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonsSnack.Name = "numPersonsSnack";
            this.numPersonsSnack.Size = new System.Drawing.Size(56, 20);
            this.numPersonsSnack.TabIndex = 27;
            this.numPersonsSnack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPersonsSnack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numServingsSnack
            // 
            this.numServingsSnack.Enabled = false;
            this.numServingsSnack.Location = new System.Drawing.Point(336, 292);
            this.numServingsSnack.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numServingsSnack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServingsSnack.Name = "numServingsSnack";
            this.numServingsSnack.Size = new System.Drawing.Size(56, 20);
            this.numServingsSnack.TabIndex = 28;
            this.numServingsSnack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numServingsSnack.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // timeSnack
            // 
            this.timeSnack.CustomFormat = "hh:mm";
            this.timeSnack.Enabled = false;
            this.timeSnack.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeSnack.Location = new System.Drawing.Point(112, 293);
            this.timeSnack.Name = "timeSnack";
            this.timeSnack.ShowUpDown = true;
            this.timeSnack.Size = new System.Drawing.Size(88, 20);
            this.timeSnack.TabIndex = 26;
            this.timeSnack.Value = new System.DateTime(2020, 9, 21, 15, 0, 0, 0);
            // 
            // chkSnack
            // 
            this.chkSnack.AutoSize = true;
            this.chkSnack.Location = new System.Drawing.Point(12, 295);
            this.chkSnack.Name = "chkSnack";
            this.chkSnack.Size = new System.Drawing.Size(57, 17);
            this.chkSnack.TabIndex = 25;
            this.chkSnack.Text = "Snack";
            this.chkSnack.UseVisualStyleBackColor = true;
            this.chkSnack.CheckedChanged += new System.EventHandler(this.chkSnack_CheckedChanged);
            // 
            // numPersonsSupper
            // 
            this.numPersonsSupper.Enabled = false;
            this.numPersonsSupper.Location = new System.Drawing.Point(228, 267);
            this.numPersonsSupper.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonsSupper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonsSupper.Name = "numPersonsSupper";
            this.numPersonsSupper.Size = new System.Drawing.Size(56, 20);
            this.numPersonsSupper.TabIndex = 23;
            this.numPersonsSupper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPersonsSupper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numServingsSupper
            // 
            this.numServingsSupper.Enabled = false;
            this.numServingsSupper.Location = new System.Drawing.Point(336, 266);
            this.numServingsSupper.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numServingsSupper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServingsSupper.Name = "numServingsSupper";
            this.numServingsSupper.Size = new System.Drawing.Size(56, 20);
            this.numServingsSupper.TabIndex = 24;
            this.numServingsSupper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numServingsSupper.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // timeSupper
            // 
            this.timeSupper.CustomFormat = "hh:mm";
            this.timeSupper.Enabled = false;
            this.timeSupper.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeSupper.Location = new System.Drawing.Point(112, 267);
            this.timeSupper.Name = "timeSupper";
            this.timeSupper.ShowUpDown = true;
            this.timeSupper.Size = new System.Drawing.Size(88, 20);
            this.timeSupper.TabIndex = 22;
            this.timeSupper.Value = new System.DateTime(2020, 9, 21, 20, 0, 0, 0);
            // 
            // chkSupper
            // 
            this.chkSupper.AutoSize = true;
            this.chkSupper.Location = new System.Drawing.Point(12, 269);
            this.chkSupper.Name = "chkSupper";
            this.chkSupper.Size = new System.Drawing.Size(60, 17);
            this.chkSupper.TabIndex = 21;
            this.chkSupper.Text = "Supper";
            this.chkSupper.UseVisualStyleBackColor = true;
            this.chkSupper.CheckedChanged += new System.EventHandler(this.chkSupper_CheckedChanged);
            // 
            // chkGenerateGroceryList
            // 
            this.chkGenerateGroceryList.AutoSize = true;
            this.chkGenerateGroceryList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGenerateGroceryList.Checked = true;
            this.chkGenerateGroceryList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenerateGroceryList.Location = new System.Drawing.Point(12, 100);
            this.chkGenerateGroceryList.Name = "chkGenerateGroceryList";
            this.chkGenerateGroceryList.Size = new System.Drawing.Size(123, 17);
            this.chkGenerateGroceryList.TabIndex = 4;
            this.chkGenerateGroceryList.Tag = "Hello";
            this.chkGenerateGroceryList.Text = "Generate grocery list";
            this.chkGenerateGroceryList.UseVisualStyleBackColor = true;
            // 
            // frmGenerateMeals
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(443, 356);
            this.Controls.Add(this.chkGenerateGroceryList);
            this.Controls.Add(this.numPersonsSnack);
            this.Controls.Add(this.numServingsSnack);
            this.Controls.Add(this.timeSnack);
            this.Controls.Add(this.chkSnack);
            this.Controls.Add(this.numPersonsSupper);
            this.Controls.Add(this.numServingsSupper);
            this.Controls.Add(this.timeSupper);
            this.Controls.Add(this.chkSupper);
            this.Controls.Add(this.numPersonsDinner);
            this.Controls.Add(this.numServingsDinner);
            this.Controls.Add(this.timeDinner);
            this.Controls.Add(this.chkDinner);
            this.Controls.Add(this.numPersonsLunch);
            this.Controls.Add(this.numServingsLunch);
            this.Controls.Add(this.timeLunch);
            this.Controls.Add(this.chkLunch);
            this.Controls.Add(this.numPersonsBrunch);
            this.Controls.Add(this.numServingsBrunch);
            this.Controls.Add(this.timeBrunch);
            this.Controls.Add(this.chkBrunch);
            this.Controls.Add(this.lblServings);
            this.Controls.Add(this.lblPersons);
            this.Controls.Add(this.lblTimeToEat);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.numPersonsBreakfast);
            this.Controls.Add(this.numServingsBreakfast);
            this.Controls.Add(this.timeBreakfast);
            this.Controls.Add(this.lblStartThisDay);
            this.Controls.Add(this.dateStartThisDay);
            this.Controls.Add(this.horizontalDivider);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.txtHowManyMeals);
            this.Controls.Add(this.lblHowManyMeals);
            this.Controls.Add(this.txtHowManyDays);
            this.Controls.Add(this.lblHowManyDays);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerateMeals";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Generate Meals";
            ((System.ComponentModel.ISupportInitialize)(this.numServingsBreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsBreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsBrunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsBrunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsSnack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsSnack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonsSupper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingsSupper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblHowManyDays;
        private System.Windows.Forms.TextBox txtHowManyDays;
        private System.Windows.Forms.TextBox txtHowManyMeals;
        private System.Windows.Forms.Label lblHowManyMeals;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.Label horizontalDivider;
        private System.Windows.Forms.DateTimePicker dateStartThisDay;
        private System.Windows.Forms.Label lblStartThisDay;
        private System.Windows.Forms.DateTimePicker timeBreakfast;
        private System.Windows.Forms.NumericUpDown numServingsBreakfast;
        private System.Windows.Forms.NumericUpDown numPersonsBreakfast;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Label lblTimeToEat;
        private System.Windows.Forms.Label lblPersons;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.NumericUpDown numPersonsBrunch;
        private System.Windows.Forms.NumericUpDown numServingsBrunch;
        private System.Windows.Forms.DateTimePicker timeBrunch;
        private System.Windows.Forms.CheckBox chkBrunch;
        private System.Windows.Forms.NumericUpDown numPersonsDinner;
        private System.Windows.Forms.NumericUpDown numServingsDinner;
        private System.Windows.Forms.DateTimePicker timeDinner;
        private System.Windows.Forms.CheckBox chkDinner;
        private System.Windows.Forms.NumericUpDown numPersonsLunch;
        private System.Windows.Forms.NumericUpDown numServingsLunch;
        private System.Windows.Forms.DateTimePicker timeLunch;
        private System.Windows.Forms.CheckBox chkLunch;
        private System.Windows.Forms.NumericUpDown numPersonsSnack;
        private System.Windows.Forms.NumericUpDown numServingsSnack;
        private System.Windows.Forms.DateTimePicker timeSnack;
        private System.Windows.Forms.CheckBox chkSnack;
        private System.Windows.Forms.NumericUpDown numPersonsSupper;
        private System.Windows.Forms.NumericUpDown numServingsSupper;
        private System.Windows.Forms.DateTimePicker timeSupper;
        private System.Windows.Forms.CheckBox chkSupper;
        private System.Windows.Forms.CheckBox chkGenerateGroceryList;
    }
}