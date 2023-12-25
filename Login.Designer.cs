namespace MyCareerApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new Label();
            passwordTextBox = new TextBox();
            password = new Label();
            loginButton = new Button();
            registerButton = new Button();
            usernameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            helpButton = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username.AutoSize = true;
            username.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(270, 267);
            username.Name = "username";
            username.Size = new Size(179, 31);
            username.TabIndex = 3;
            username.Text = "Όνομα χρήστη:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(455, 358);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(469, 38);
            passwordTextBox.TabIndex = 2;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password.AutoSize = true;
            password.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(208, 361);
            password.Name = "password";
            password.Size = new Size(248, 31);
            password.TabIndex = 4;
            password.Text = "Κωδικός πρόσβασης:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Tan;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(254, 528);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(286, 133);
            loginButton.TabIndex = 0;
            loginButton.Text = "Είσοδος";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Tan;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(722, 528);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(286, 133);
            registerButton.TabIndex = 5;
            registerButton.Text = "Εγγραφή";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(455, 264);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(469, 38);
            usernameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(371, 28);
            label1.Name = "label1";
            label1.Size = new Size(447, 52);
            label1.TabIndex = 6;
            label1.Text = "Επαγγελματικός Οδηγός";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(270, 147);
            label2.Name = "label2";
            label2.Size = new Size(24, 29);
            label2.TabIndex = 7;
            label2.Text = "d";
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.Transparent;
            helpButton.Cursor = Cursors.Hand;
            helpButton.FlatStyle = FlatStyle.Popup;
            helpButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            helpButton.ForeColor = SystemColors.ActiveCaptionText;
            helpButton.Location = new Point(14, 689);
            helpButton.Margin = new Padding(3, 4, 3, 4);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(119, 43);
            helpButton.TabIndex = 27;
            helpButton.Text = "Βοήθεια!";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1125, 748);
            Controls.Add(helpButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Controls.Add(registerButton);
            Controls.Add(username);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(password);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Είσοδος";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private TextBox passwordTextBox;
        private Label password;
        private Button loginButton;
        private Button registerButton;
        private TextBox usernameTextBox;
        private Label label1;
        private Label label2;
        private Button helpButton;
    }
}