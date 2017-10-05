namespace POSSystem
{
    partial class Form1
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
            this.usernameInputTextBox = new System.Windows.Forms.TextBox();
            this.passwordInputTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameInputTextBox
            // 
            this.usernameInputTextBox.Location = new System.Drawing.Point(97, 11);
            this.usernameInputTextBox.Name = "usernameInputTextBox";
            this.usernameInputTextBox.Size = new System.Drawing.Size(128, 20);
            this.usernameInputTextBox.TabIndex = 0;
            // 
            // passwordInputTextBox
            // 
            this.passwordInputTextBox.Location = new System.Drawing.Point(97, 37);
            this.passwordInputTextBox.Name = "passwordInputTextBox";
            this.passwordInputTextBox.Size = new System.Drawing.Size(128, 20);
            this.passwordInputTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(33, 14);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(35, 40);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // newAccountButton
            // 
            this.newAccountButton.AutoSize = true;
            this.newAccountButton.Location = new System.Drawing.Point(132, 73);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(116, 23);
            this.newAccountButton.TabIndex = 4;
            this.newAccountButton.Text = "Create New Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.AutoSize = true;
            this.forgotPasswordButton.Location = new System.Drawing.Point(10, 73);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(116, 23);
            this.forgotPasswordButton.TabIndex = 5;
            this.forgotPasswordButton.Text = "Forgot Password?";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(92, 102);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 136);
            this.ControlBox = false;
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.forgotPasswordButton);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordInputTextBox);
            this.Controls.Add(this.usernameInputTextBox);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInputTextBox;
        private System.Windows.Forms.TextBox passwordInputTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Button loginButton;
    }
}

