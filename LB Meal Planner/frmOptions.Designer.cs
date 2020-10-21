namespace LB_Meal_Planner
{
    partial class frmOptions
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
            this.txtCalendarURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearDatabase = new System.Windows.Forms.Button();
            this.btnClearUserData = new System.Windows.Forms.Button();
            this.btnDeleteCredentials = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalendarURL
            // 
            this.txtCalendarURL.Location = new System.Drawing.Point(93, 10);
            this.txtCalendarURL.Name = "txtCalendarURL";
            this.txtCalendarURL.Size = new System.Drawing.Size(179, 20);
            this.txtCalendarURL.TabIndex = 0;
            this.txtCalendarURL.Text = "primary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calendar URL";
            // 
            // btnClearDatabase
            // 
            this.btnClearDatabase.AutoSize = true;
            this.btnClearDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearDatabase.Location = new System.Drawing.Point(79, 37);
            this.btnClearDatabase.Name = "btnClearDatabase";
            this.btnClearDatabase.Size = new System.Drawing.Size(127, 23);
            this.btnClearDatabase.TabIndex = 1;
            this.btnClearDatabase.Text = "Clear Recipe Database";
            this.btnClearDatabase.UseVisualStyleBackColor = true;
            this.btnClearDatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearUserData
            // 
            this.btnClearUserData.AutoSize = true;
            this.btnClearUserData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearUserData.Location = new System.Drawing.Point(96, 66);
            this.btnClearUserData.Name = "btnClearUserData";
            this.btnClearUserData.Size = new System.Drawing.Size(92, 23);
            this.btnClearUserData.TabIndex = 2;
            this.btnClearUserData.Text = "Clear User Data";
            this.btnClearUserData.UseVisualStyleBackColor = true;
            this.btnClearUserData.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteCredentials
            // 
            this.btnDeleteCredentials.AutoSize = true;
            this.btnDeleteCredentials.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCredentials.Location = new System.Drawing.Point(68, 95);
            this.btnDeleteCredentials.Name = "btnDeleteCredentials";
            this.btnDeleteCredentials.Size = new System.Drawing.Size(148, 23);
            this.btnDeleteCredentials.TabIndex = 3;
            this.btnDeleteCredentials.Text = "Delete Calendar Credentials";
            this.btnDeleteCredentials.UseVisualStyleBackColor = true;
            this.btnDeleteCredentials.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.btnDeleteCredentials);
            this.Controls.Add(this.btnClearUserData);
            this.Controls.Add(this.btnClearDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalendarURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalendarURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearDatabase;
        private System.Windows.Forms.Button btnClearUserData;
        private System.Windows.Forms.Button btnDeleteCredentials;
    }
}