namespace LB_Meal_Planner
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chklstRecipes = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnAddRecipe = new System.Windows.Forms.ToolStripButton();
            this.tbtnDeleteRecipe = new System.Windows.Forms.ToolStripButton();
            this.tbtnEditRecipe = new System.Windows.Forms.ToolStripButton();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSortClear = new System.Windows.Forms.ToolStripButton();
            this.tbtnSortAscending = new System.Windows.Forms.ToolStripButton();
            this.tbtnSortDescending = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSettings = new System.Windows.Forms.ToolStripButton();
            this.tbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.chkCheckAll = new System.Windows.Forms.CheckBox();
            this.grpRecipes = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpRecipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMealsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // generateMealsToolStripMenuItem
            // 
            this.generateMealsToolStripMenuItem.Name = "generateMealsToolStripMenuItem";
            this.generateMealsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.generateMealsToolStripMenuItem.Text = "&Generate Meals";
            this.generateMealsToolStripMenuItem.Click += new System.EventHandler(this.generateMealsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecipeToolStripMenuItem,
            this.deleteRecipeToolStripMenuItem,
            this.editRecipesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addRecipeToolStripMenuItem
            // 
            this.addRecipeToolStripMenuItem.Name = "addRecipeToolStripMenuItem";
            this.addRecipeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addRecipeToolStripMenuItem.Text = "&Add Recipe";
            this.addRecipeToolStripMenuItem.Click += new System.EventHandler(this.addRecipeToolStripMenuItem_Click);
            // 
            // deleteRecipeToolStripMenuItem
            // 
            this.deleteRecipeToolStripMenuItem.Name = "deleteRecipeToolStripMenuItem";
            this.deleteRecipeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteRecipeToolStripMenuItem.Text = "&Delete Recipe";
            this.deleteRecipeToolStripMenuItem.Click += new System.EventHandler(this.deleteRecipeToolStripMenuItem_Click);
            // 
            // editRecipesToolStripMenuItem
            // 
            this.editRecipesToolStripMenuItem.Name = "editRecipesToolStripMenuItem";
            this.editRecipesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editRecipesToolStripMenuItem.Text = "&Edit Recipe";
            this.editRecipesToolStripMenuItem.Click += new System.EventHandler(this.editRecipesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noSortingToolStripMenuItem,
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sortToolStripMenuItem.Text = "&Sort";
            // 
            // noSortingToolStripMenuItem
            // 
            this.noSortingToolStripMenuItem.Name = "noSortingToolStripMenuItem";
            this.noSortingToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.noSortingToolStripMenuItem.Text = "&No Sorting";
            this.noSortingToolStripMenuItem.Click += new System.EventHandler(this.noSortingToolStripMenuItem_Click);
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aZToolStripMenuItem.Text = "&A-Z (Ascending)";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.zAToolStripMenuItem.Text = "&Z-A (Descending)";
            this.zAToolStripMenuItem.Click += new System.EventHandler(this.zAToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(211, 453);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Meals";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chklstRecipes
            // 
            this.chklstRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstRecipes.FormattingEnabled = true;
            this.chklstRecipes.Location = new System.Drawing.Point(6, 19);
            this.chklstRecipes.Name = "chklstRecipes";
            this.chklstRecipes.Size = new System.Drawing.Size(286, 364);
            this.chklstRecipes.TabIndex = 1;
            this.chklstRecipes.SelectedIndexChanged += new System.EventHandler(this.chklstRecipes_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAddRecipe,
            this.tbtnDeleteRecipe,
            this.tbtnEditRecipe,
            this.tbtnSave,
            this.toolStripSeparator1,
            this.tbtnSortClear,
            this.tbtnSortAscending,
            this.tbtnSortDescending,
            this.toolStripSeparator2,
            this.tbtnSettings,
            this.tbtnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(323, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnAddRecipe
            // 
            this.tbtnAddRecipe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddRecipe.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAddRecipe.Image")));
            this.tbtnAddRecipe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddRecipe.Name = "tbtnAddRecipe";
            this.tbtnAddRecipe.Size = new System.Drawing.Size(23, 22);
            this.tbtnAddRecipe.Text = "Add Recipe";
            this.tbtnAddRecipe.Click += new System.EventHandler(this.tbtnAddRecipe_Click);
            // 
            // tbtnDeleteRecipe
            // 
            this.tbtnDeleteRecipe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDeleteRecipe.Enabled = false;
            this.tbtnDeleteRecipe.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDeleteRecipe.Image")));
            this.tbtnDeleteRecipe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDeleteRecipe.Name = "tbtnDeleteRecipe";
            this.tbtnDeleteRecipe.Size = new System.Drawing.Size(23, 22);
            this.tbtnDeleteRecipe.Text = "Delete Recipe";
            this.tbtnDeleteRecipe.Click += new System.EventHandler(this.tbtnDeleteRecipe_Click);
            // 
            // tbtnEditRecipe
            // 
            this.tbtnEditRecipe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEditRecipe.Enabled = false;
            this.tbtnEditRecipe.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEditRecipe.Image")));
            this.tbtnEditRecipe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEditRecipe.Name = "tbtnEditRecipe";
            this.tbtnEditRecipe.Size = new System.Drawing.Size(23, 22);
            this.tbtnEditRecipe.Text = "Edit Recipe";
            this.tbtnEditRecipe.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tbtnSave
            // 
            this.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSave.Enabled = false;
            this.tbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSave.Image")));
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tbtnSave.Text = "Save Changes";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnSortClear
            // 
            this.tbtnSortClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSortClear.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSortClear.Image")));
            this.tbtnSortClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSortClear.Name = "tbtnSortClear";
            this.tbtnSortClear.Size = new System.Drawing.Size(23, 22);
            this.tbtnSortClear.Text = "Clear Sorting";
            this.tbtnSortClear.Click += new System.EventHandler(this.tbtnSortClear_Click);
            // 
            // tbtnSortAscending
            // 
            this.tbtnSortAscending.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSortAscending.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSortAscending.Image")));
            this.tbtnSortAscending.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSortAscending.Name = "tbtnSortAscending";
            this.tbtnSortAscending.Size = new System.Drawing.Size(23, 22);
            this.tbtnSortAscending.Text = "Sort Ascending";
            this.tbtnSortAscending.Click += new System.EventHandler(this.tbtnSortAscending_Click);
            // 
            // tbtnSortDescending
            // 
            this.tbtnSortDescending.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSortDescending.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSortDescending.Image")));
            this.tbtnSortDescending.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSortDescending.Name = "tbtnSortDescending";
            this.tbtnSortDescending.Size = new System.Drawing.Size(23, 22);
            this.tbtnSortDescending.Text = "Sort Descending";
            this.tbtnSortDescending.Click += new System.EventHandler(this.tbtnSortDescending_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnSettings
            // 
            this.tbtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSettings.Image")));
            this.tbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSettings.Name = "tbtnSettings";
            this.tbtnSettings.Size = new System.Drawing.Size(23, 22);
            this.tbtnSettings.Text = "Settings";
            this.tbtnSettings.Click += new System.EventHandler(this.tbtnSettings_Click);
            // 
            // tbtnHelp
            // 
            this.tbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tbtnHelp.Image")));
            this.tbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnHelp.Name = "tbtnHelp";
            this.tbtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tbtnHelp.Text = "Help";
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.Location = new System.Drawing.Point(13, 458);
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Size = new System.Drawing.Size(71, 17);
            this.chkCheckAll.TabIndex = 3;
            this.chkCheckAll.Text = "Check All";
            this.chkCheckAll.UseVisualStyleBackColor = true;
            this.chkCheckAll.CheckedChanged += new System.EventHandler(this.chkCheckAll_CheckedChanged);
            // 
            // grpRecipes
            // 
            this.grpRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecipes.Controls.Add(this.chklstRecipes);
            this.grpRecipes.Location = new System.Drawing.Point(12, 52);
            this.grpRecipes.Name = "grpRecipes";
            this.grpRecipes.Size = new System.Drawing.Size(298, 395);
            this.grpRecipes.TabIndex = 0;
            this.grpRecipes.TabStop = false;
            this.grpRecipes.Text = "Recipe Database";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 488);
            this.Controls.Add(this.chkCheckAll);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpRecipes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "LB Meal Planner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpRecipes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateMealsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecipesToolStripMenuItem;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckedListBox chklstRecipes;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnAddRecipe;
        private System.Windows.Forms.ToolStripButton tbtnDeleteRecipe;
        private System.Windows.Forms.ToolStripButton tbtnEditRecipe;
        private System.Windows.Forms.CheckBox chkCheckAll;
        private System.Windows.Forms.GroupBox grpRecipes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnSettings;
        private System.Windows.Forms.ToolStripButton tbtnHelp;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.ToolStripButton tbtnSortAscending;
        private System.Windows.Forms.ToolStripButton tbtnSortDescending;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tbtnSortClear;
        private System.Windows.Forms.ToolStripMenuItem noSortingToolStripMenuItem;
    }
}

