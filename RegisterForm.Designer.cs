namespace MyCareerApp
{
    partial class RegisterForm
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
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.haveAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.registerButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(241, 188);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(91, 25);
            this.password.TabIndex = 10;
            this.password.Text = "Κωδικός:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(189, 114);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(143, 25);
            this.username.TabIndex = 9;
            this.username.Text = "Όνομα χρήστη:";
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(338, 188);
            this.registerPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '*';
            this.registerPasswordTextBox.Size = new System.Drawing.Size(411, 23);
            this.registerPasswordTextBox.TabIndex = 8;
            // 
            // registerUsernameTextBox
            // 
            this.registerUsernameTextBox.Location = new System.Drawing.Point(338, 116);
            this.registerUsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerUsernameTextBox.Name = "registerUsernameTextBox";
            this.registerUsernameTextBox.Size = new System.Drawing.Size(411, 23);
            this.registerUsernameTextBox.TabIndex = 7;
            // 
            // haveAccountLinkLabel
            // 
            this.haveAccountLinkLabel.AutoSize = true;
            this.haveAccountLinkLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haveAccountLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.haveAccountLinkLabel.Location = new System.Drawing.Point(375, 414);
            this.haveAccountLinkLabel.Name = "haveAccountLinkLabel";
            this.haveAccountLinkLabel.Size = new System.Drawing.Size(208, 25);
            this.haveAccountLinkLabel.TabIndex = 12;
            this.haveAccountLinkLabel.TabStop = true;
            this.haveAccountLinkLabel.Text = "Έχετε ήδη λογαριασμό;";
            this.haveAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.haveAccountLinkLabel_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.BackColor = System.Drawing.Color.Tan;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(282, 282);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(400, 100);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Εγγραφή";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.theoryButton_Click);
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
            this.helpButton.TabIndex = 27;
            this.helpButton.Text = "Βοήθεια!";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.haveAccountLinkLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.registerUsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εγγραφή";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label password;
        private Label username;
        private TextBox registerPasswordTextBox;
        private TextBox registerUsernameTextBox;
        private LinkLabel haveAccountLinkLabel;
        private Button registerButton;
        private Button helpButton;
    }
}