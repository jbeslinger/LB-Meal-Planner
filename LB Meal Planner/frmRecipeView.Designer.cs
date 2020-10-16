namespace LB_Meal_Planner
{
    partial class frmRecipeView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeView));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpIngredients = new System.Windows.Forms.GroupBox();
            this.datagridIngredients = new System.Windows.Forms.DataGridView();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDirections = new System.Windows.Forms.TextBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.numPrepMinutes = new System.Windows.Forms.NumericUpDown();
            this.numPrepHours = new System.Windows.Forms.NumericUpDown();
            this.numCookMinutes = new System.Windows.Forms.NumericUpDown();
            this.numCookHours = new System.Windows.Forms.NumericUpDown();
            this.lblServings = new System.Windows.Forms.Label();
            this.numServings = new System.Windows.Forms.NumericUpDown();
            this.lblMakes = new System.Windows.Forms.Label();
            this.chkPrepTime = new System.Windows.Forms.CheckBox();
            this.lblPrepTimeMin = new System.Windows.Forms.Label();
            this.lblPrepTimeHrs = new System.Windows.Forms.Label();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.lblCookTimeMin = new System.Windows.Forms.Label();
            this.lblCookTimeHrs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCanBeServed = new System.Windows.Forms.Label();
            this.chklstCanBeServed = new System.Windows.Forms.CheckedListBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.chkPickMeForGen = new System.Windows.Forms.CheckBox();
            this.tipIngredientsBox = new System.Windows.Forms.ToolTip(this.components);
            this.grpIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridIngredients)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCookMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCookHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(489, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(408, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpIngredients
            // 
            this.grpIngredients.Controls.Add(this.datagridIngredients);
            this.grpIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIngredients.Location = new System.Drawing.Point(12, 186);
            this.grpIngredients.Name = "grpIngredients";
            this.grpIngredients.Size = new System.Drawing.Size(552, 211);
            this.grpIngredients.TabIndex = 10;
            this.grpIngredients.TabStop = false;
            this.grpIngredients.Text = "Ingredients";
            // 
            // datagridIngredients
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAmount,
            this.colMeasurement,
            this.colIngredient});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridIngredients.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridIngredients.Location = new System.Drawing.Point(7, 20);
            this.datagridIngredients.Name = "datagridIngredients";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridIngredients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridIngredients.Size = new System.Drawing.Size(539, 185);
            this.datagridIngredients.TabIndex = 0;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAmount.Frozen = true;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MaxInputLength = 7;
            this.colAmount.Name = "colAmount";
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAmount.ToolTipText = "The amount of this ingredient in mixed fraction or decimal.";
            this.colAmount.Width = 68;
            // 
            // colMeasurement
            // 
            this.colMeasurement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMeasurement.Frozen = true;
            this.colMeasurement.HeaderText = "Measurement";
            this.colMeasurement.MaxInputLength = 8;
            this.colMeasurement.Name = "colMeasurement";
            this.colMeasurement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMeasurement.ToolTipText = "The unit of measurement (singular noun).  (e.g. \"cup\")";
            this.colMeasurement.Width = 96;
            // 
            // colIngredient
            // 
            this.colIngredient.Frozen = true;
            this.colIngredient.HeaderText = "Ingredient";
            this.colIngredient.MaxInputLength = 35;
            this.colIngredient.Name = "colIngredient";
            this.colIngredient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIngredient.ToolTipText = "The ingredient name (singular noun). (e.g. \"Broccoli\")";
            this.colIngredient.Width = 300;
            // 
            // txtDirections
            // 
            this.txtDirections.Location = new System.Drawing.Point(350, 25);
            this.txtDirections.MaxLength = 1000;
            this.txtDirections.Multiline = true;
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.Size = new System.Drawing.Size(214, 155);
            this.txtDirections.TabIndex = 9;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(347, 9);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(54, 13);
            this.lblDirections.TabIndex = 15;
            this.lblDirections.Text = "Directions";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Location = new System.Drawing.Point(12, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 24);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.numPrepMinutes);
            this.grpInfo.Controls.Add(this.numPrepHours);
            this.grpInfo.Controls.Add(this.numCookMinutes);
            this.grpInfo.Controls.Add(this.numCookHours);
            this.grpInfo.Controls.Add(this.lblServings);
            this.grpInfo.Controls.Add(this.numServings);
            this.grpInfo.Controls.Add(this.lblMakes);
            this.grpInfo.Controls.Add(this.chkPrepTime);
            this.grpInfo.Controls.Add(this.lblPrepTimeMin);
            this.grpInfo.Controls.Add(this.lblPrepTimeHrs);
            this.grpInfo.Controls.Add(this.lblPrepTime);
            this.grpInfo.Controls.Add(this.lblCookTimeMin);
            this.grpInfo.Controls.Add(this.lblCookTimeHrs);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.lblCanBeServed);
            this.grpInfo.Controls.Add(this.chklstCanBeServed);
            this.grpInfo.Controls.Add(this.txtRecipeName);
            this.grpInfo.Controls.Add(this.lblRecipeName);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(13, 13);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(328, 167);
            this.grpInfo.TabIndex = 16;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information";
            // 
            // numPrepMinutes
            // 
            this.numPrepMinutes.Enabled = false;
            this.numPrepMinutes.Location = new System.Drawing.Point(155, 120);
            this.numPrepMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numPrepMinutes.Name = "numPrepMinutes";
            this.numPrepMinutes.Size = new System.Drawing.Size(39, 20);
            this.numPrepMinutes.TabIndex = 36;
            // 
            // numPrepHours
            // 
            this.numPrepHours.Enabled = false;
            this.numPrepHours.Location = new System.Drawing.Point(84, 120);
            this.numPrepHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numPrepHours.Name = "numPrepHours";
            this.numPrepHours.Size = new System.Drawing.Size(39, 20);
            this.numPrepHours.TabIndex = 35;
            // 
            // numCookMinutes
            // 
            this.numCookMinutes.Location = new System.Drawing.Point(155, 94);
            this.numCookMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numCookMinutes.Name = "numCookMinutes";
            this.numCookMinutes.Size = new System.Drawing.Size(39, 20);
            this.numCookMinutes.TabIndex = 34;
            // 
            // numCookHours
            // 
            this.numCookHours.Location = new System.Drawing.Point(84, 94);
            this.numCookHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numCookHours.Name = "numCookHours";
            this.numCookHours.Size = new System.Drawing.Size(39, 20);
            this.numCookHours.TabIndex = 33;
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServings.Location = new System.Drawing.Point(152, 47);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(46, 13);
            this.lblServings.TabIndex = 32;
            this.lblServings.Text = "servings";
            // 
            // numServings
            // 
            this.numServings.Location = new System.Drawing.Point(84, 45);
            this.numServings.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numServings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServings.Name = "numServings";
            this.numServings.Size = new System.Drawing.Size(62, 20);
            this.numServings.TabIndex = 1;
            this.numServings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numServings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMakes
            // 
            this.lblMakes.AutoSize = true;
            this.lblMakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakes.Location = new System.Drawing.Point(38, 47);
            this.lblMakes.Name = "lblMakes";
            this.lblMakes.Size = new System.Drawing.Size(39, 13);
            this.lblMakes.TabIndex = 30;
            this.lblMakes.Text = "Makes";
            // 
            // chkPrepTime
            // 
            this.chkPrepTime.AutoSize = true;
            this.chkPrepTime.Location = new System.Drawing.Point(6, 122);
            this.chkPrepTime.Name = "chkPrepTime";
            this.chkPrepTime.Size = new System.Drawing.Size(15, 14);
            this.chkPrepTime.TabIndex = 5;
            this.chkPrepTime.UseVisualStyleBackColor = true;
            this.chkPrepTime.CheckedChanged += new System.EventHandler(this.chkPrepTime_CheckedChanged);
            // 
            // lblPrepTimeMin
            // 
            this.lblPrepTimeMin.AutoSize = true;
            this.lblPrepTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepTimeMin.Location = new System.Drawing.Point(201, 122);
            this.lblPrepTimeMin.Name = "lblPrepTimeMin";
            this.lblPrepTimeMin.Size = new System.Drawing.Size(23, 13);
            this.lblPrepTimeMin.TabIndex = 27;
            this.lblPrepTimeMin.Text = "min";
            // 
            // lblPrepTimeHrs
            // 
            this.lblPrepTimeHrs.AutoSize = true;
            this.lblPrepTimeHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepTimeHrs.Location = new System.Drawing.Point(129, 122);
            this.lblPrepTimeHrs.Name = "lblPrepTimeHrs";
            this.lblPrepTimeHrs.Size = new System.Drawing.Size(21, 13);
            this.lblPrepTimeHrs.TabIndex = 25;
            this.lblPrepTimeHrs.Text = "hrs";
            // 
            // lblPrepTime
            // 
            this.lblPrepTime.AutoSize = true;
            this.lblPrepTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepTime.Location = new System.Drawing.Point(23, 122);
            this.lblPrepTime.Name = "lblPrepTime";
            this.lblPrepTime.Size = new System.Drawing.Size(55, 13);
            this.lblPrepTime.TabIndex = 23;
            this.lblPrepTime.Text = "Prep Time";
            // 
            // lblCookTimeMin
            // 
            this.lblCookTimeMin.AutoSize = true;
            this.lblCookTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookTimeMin.Location = new System.Drawing.Point(201, 96);
            this.lblCookTimeMin.Name = "lblCookTimeMin";
            this.lblCookTimeMin.Size = new System.Drawing.Size(23, 13);
            this.lblCookTimeMin.TabIndex = 22;
            this.lblCookTimeMin.Text = "min";
            // 
            // lblCookTimeHrs
            // 
            this.lblCookTimeHrs.AutoSize = true;
            this.lblCookTimeHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookTimeHrs.Location = new System.Drawing.Point(129, 96);
            this.lblCookTimeHrs.Name = "lblCookTimeHrs";
            this.lblCookTimeHrs.Size = new System.Drawing.Size(21, 13);
            this.lblCookTimeHrs.TabIndex = 20;
            this.lblCookTimeHrs.Text = "hrs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cook Time";
            // 
            // lblCanBeServed
            // 
            this.lblCanBeServed.AutoSize = true;
            this.lblCanBeServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanBeServed.Location = new System.Drawing.Point(231, 51);
            this.lblCanBeServed.Name = "lblCanBeServed";
            this.lblCanBeServed.Size = new System.Drawing.Size(91, 13);
            this.lblCanBeServed.TabIndex = 17;
            this.lblCanBeServed.Text = "Can be served for";
            // 
            // chklstCanBeServed
            // 
            this.chklstCanBeServed.CheckOnClick = true;
            this.chklstCanBeServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstCanBeServed.FormattingEnabled = true;
            this.chklstCanBeServed.Items.AddRange(new object[] {
            "Breakfast",
            "Brunch",
            "Lunch",
            "Dinner",
            "Supper",
            "Snack"});
            this.chklstCanBeServed.Location = new System.Drawing.Point(234, 67);
            this.chklstCanBeServed.Name = "chklstCanBeServed";
            this.chklstCanBeServed.Size = new System.Drawing.Size(88, 94);
            this.chklstCanBeServed.TabIndex = 8;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(84, 19);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(238, 20);
            this.txtRecipeName.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(6, 22);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(72, 13);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name";
            // 
            // chkPickMeForGen
            // 
            this.chkPickMeForGen.AutoSize = true;
            this.chkPickMeForGen.Checked = true;
            this.chkPickMeForGen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPickMeForGen.Location = new System.Drawing.Point(43, 408);
            this.chkPickMeForGen.Name = "chkPickMeForGen";
            this.chkPickMeForGen.Size = new System.Drawing.Size(132, 17);
            this.chkPickMeForGen.TabIndex = 15;
            this.chkPickMeForGen.Text = "Pick me for generation";
            this.chkPickMeForGen.UseVisualStyleBackColor = true;
            // 
            // frmRecipeView
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(576, 438);
            this.Controls.Add(this.chkPickMeForGen);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.txtDirections);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecipeView";
            this.Text = "Recipe";
            this.grpIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridIngredients)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCookMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCookHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpIngredients;
        private System.Windows.Forms.TextBox txtDirections;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblCanBeServed;
        private System.Windows.Forms.CheckedListBox chklstCanBeServed;
        private System.Windows.Forms.CheckBox chkPickMeForGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCookTimeHrs;
        private System.Windows.Forms.Label lblCookTimeMin;
        private System.Windows.Forms.Label lblPrepTimeMin;
        private System.Windows.Forms.Label lblPrepTimeHrs;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.CheckBox chkPrepTime;
        private System.Windows.Forms.NumericUpDown numServings;
        private System.Windows.Forms.Label lblMakes;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.ToolTip tipIngredientsBox;
        private System.Windows.Forms.DataGridView datagridIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngredient;
        private System.Windows.Forms.NumericUpDown numPrepMinutes;
        private System.Windows.Forms.NumericUpDown numPrepHours;
        private System.Windows.Forms.NumericUpDown numCookMinutes;
        private System.Windows.Forms.NumericUpDown numCookHours;
    }
}