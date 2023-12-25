namespace MyCareerApp
{
    partial class TlesCoursesListForm
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
            this.bioinformaticsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.naturalLanguageProcessLinkLabel = new System.Windows.Forms.LinkLabel();
            this.androidLinkLabel = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bioinformaticsLinkLabel
            // 
            this.bioinformaticsLinkLabel.AutoSize = true;
            this.bioinformaticsLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bioinformaticsLinkLabel.LinkColor = System.Drawing.Color.Maroon;
            this.bioinformaticsLinkLabel.Location = new System.Drawing.Point(237, 235);
            this.bioinformaticsLinkLabel.Name = "bioinformaticsLinkLabel";
            this.bioinformaticsLinkLabel.Size = new System.Drawing.Size(391, 42);
            this.bioinformaticsLinkLabel.TabIndex = 0;
            this.bioinformaticsLinkLabel.TabStop = true;
            this.bioinformaticsLinkLabel.Text = "Λογικός Προγραμματισμός";
            this.bioinformaticsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logikosProgrammatismosLinkLabel_LinkClicked);
            // 
            // naturalLanguageProcessLinkLabel
            // 
            this.naturalLanguageProcessLinkLabel.AutoSize = true;
            this.naturalLanguageProcessLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.naturalLanguageProcessLinkLabel.LinkColor = System.Drawing.Color.Maroon;
            this.naturalLanguageProcessLinkLabel.Location = new System.Drawing.Point(237, 157);
            this.naturalLanguageProcessLinkLabel.Name = "naturalLanguageProcessLinkLabel";
            this.naturalLanguageProcessLinkLabel.Size = new System.Drawing.Size(630, 42);
            this.naturalLanguageProcessLinkLabel.TabIndex = 1;
            this.naturalLanguageProcessLinkLabel.TabStop = true;
            this.naturalLanguageProcessLinkLabel.Text = "Συστήματα Διαχείρισης Βάσεων Δεδομένων";
            this.naturalLanguageProcessLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sdvdProcessLinkLabel_LinkClicked);
            // 
            // androidLinkLabel
            // 
            this.androidLinkLabel.AutoSize = true;
            this.androidLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.androidLinkLabel.LinkColor = System.Drawing.Color.Maroon;
            this.androidLinkLabel.Location = new System.Drawing.Point(237, 312);
            this.androidLinkLabel.Name = "androidLinkLabel";
            this.androidLinkLabel.Size = new System.Drawing.Size(371, 42);
            this.androidLinkLabel.TabIndex = 2;
            this.androidLinkLabel.TabStop = true;
            this.androidLinkLabel.Text = "Εικονική Πραγματικότητα";
            this.androidLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eikonikiPragmatikotitaLinkLabel_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(787, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(185, 80);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "Έξοδος";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(185, 80);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Πίσω";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpButton.Location = new System.Drawing.Point(12, 517);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(104, 32);
            this.helpButton.TabIndex = 29;
            this.helpButton.Text = "Βοήθεια!";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // TlesCoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.androidLinkLabel);
            this.Controls.Add(this.naturalLanguageProcessLinkLabel);
            this.Controls.Add(this.bioinformaticsLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TlesCoursesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel bioinformaticsLinkLabel;
        private LinkLabel naturalLanguageProcessLinkLabel;
        private LinkLabel androidLinkLabel;
        private Button exitButton;
        private Button backButton;
        private Button helpButton;
    }
}