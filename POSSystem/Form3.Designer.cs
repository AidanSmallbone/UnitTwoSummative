namespace POSSystem
{
    partial class Form3
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
            this.confirmPasswordInputTextBox = new System.Windows.Forms.TextBox();
            this.hintInputTextBox = new System.Windows.Forms.TextBox();
            this.usernameInputLabel = new System.Windows.Forms.Label();
            this.passwordInputLabel = new System.Windows.Forms.Label();
            this.cofirmPasswordInputLabel = new System.Windows.Forms.Label();
            this.passwordHintInputLabel = new System.Windows.Forms.Label();
            this.createAccountHeaderLabel = new System.Windows.Forms.Label();
            this.createAccountSubHeaderLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameInputTextBox
            // 
            this.usernameInputTextBox.Location = new System.Drawing.Point(103, 54);
            this.usernameInputTextBox.Name = "usernameInputTextBox";
            this.usernameInputTextBox.Size = new System.Drawing.Size(128, 20);
            this.usernameInputTextBox.TabIndex = 0;
            // 
            // passwordInputTextBox
            // 
            this.passwordInputTextBox.Location = new System.Drawing.Point(103, 80);
            this.passwordInputTextBox.Name = "passwordInputTextBox";
            this.passwordInputTextBox.Size = new System.Drawing.Size(128, 20);
            this.passwordInputTextBox.TabIndex = 1;
            // 
            // confirmPasswordInputTextBox
            // 
            this.confirmPasswordInputTextBox.Location = new System.Drawing.Point(103, 106);
            this.confirmPasswordInputTextBox.Name = "confirmPasswordInputTextBox";
            this.confirmPasswordInputTextBox.Size = new System.Drawing.Size(128, 20);
            this.confirmPasswordInputTextBox.TabIndex = 2;
            // 
            // hintInputTextBox
            // 
            this.hintInputTextBox.Location = new System.Drawing.Point(103, 132);
            this.hintInputTextBox.Name = "hintInputTextBox";
            this.hintInputTextBox.Size = new System.Drawing.Size(128, 20);
            this.hintInputTextBox.TabIndex = 3;
            // 
            // usernameInputLabel
            // 
            this.usernameInputLabel.AutoSize = true;
            this.usernameInputLabel.Location = new System.Drawing.Point(39, 57);
            this.usernameInputLabel.Name = "usernameInputLabel";
            this.usernameInputLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameInputLabel.TabIndex = 4;
            this.usernameInputLabel.Text = "Username:";
            // 
            // passwordInputLabel
            // 
            this.passwordInputLabel.AutoSize = true;
            this.passwordInputLabel.Location = new System.Drawing.Point(41, 83);
            this.passwordInputLabel.Name = "passwordInputLabel";
            this.passwordInputLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordInputLabel.TabIndex = 5;
            this.passwordInputLabel.Text = "Password:";
            // 
            // cofirmPasswordInputLabel
            // 
            this.cofirmPasswordInputLabel.AutoSize = true;
            this.cofirmPasswordInputLabel.Location = new System.Drawing.Point(3, 109);
            this.cofirmPasswordInputLabel.Name = "cofirmPasswordInputLabel";
            this.cofirmPasswordInputLabel.Size = new System.Drawing.Size(94, 13);
            this.cofirmPasswordInputLabel.TabIndex = 6;
            this.cofirmPasswordInputLabel.Text = "Confirm Password:";
            // 
            // passwordHintInputLabel
            // 
            this.passwordHintInputLabel.AutoSize = true;
            this.passwordHintInputLabel.Location = new System.Drawing.Point(19, 135);
            this.passwordHintInputLabel.Name = "passwordHintInputLabel";
            this.passwordHintInputLabel.Size = new System.Drawing.Size(78, 13);
            this.passwordHintInputLabel.TabIndex = 7;
            this.passwordHintInputLabel.Text = "Password Hint:";
            // 
            // createAccountHeaderLabel
            // 
            this.createAccountHeaderLabel.AutoSize = true;
            this.createAccountHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountHeaderLabel.Location = new System.Drawing.Point(46, 6);
            this.createAccountHeaderLabel.Name = "createAccountHeaderLabel";
            this.createAccountHeaderLabel.Size = new System.Drawing.Size(146, 20);
            this.createAccountHeaderLabel.TabIndex = 8;
            this.createAccountHeaderLabel.Text = "Create an Account:";
            // 
            // createAccountSubHeaderLabel
            // 
            this.createAccountSubHeaderLabel.AutoSize = true;
            this.createAccountSubHeaderLabel.Location = new System.Drawing.Point(58, 26);
            this.createAccountSubHeaderLabel.Name = "createAccountSubHeaderLabel";
            this.createAccountSubHeaderLabel.Size = new System.Drawing.Size(121, 13);
            this.createAccountSubHeaderLabel.TabIndex = 9;
            this.createAccountSubHeaderLabel.Text = "(All fields are mandatory)";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(46, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.AutoSize = true;
            this.createAccountButton.Location = new System.Drawing.Point(102, 158);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(91, 23);
            this.createAccountButton.TabIndex = 11;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 186);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createAccountSubHeaderLabel);
            this.Controls.Add(this.createAccountHeaderLabel);
            this.Controls.Add(this.passwordHintInputLabel);
            this.Controls.Add(this.cofirmPasswordInputLabel);
            this.Controls.Add(this.passwordInputLabel);
            this.Controls.Add(this.usernameInputLabel);
            this.Controls.Add(this.hintInputTextBox);
            this.Controls.Add(this.confirmPasswordInputTextBox);
            this.Controls.Add(this.passwordInputTextBox);
            this.Controls.Add(this.usernameInputTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "CREATE NEW ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInputTextBox;
        private System.Windows.Forms.TextBox passwordInputTextBox;
        private System.Windows.Forms.TextBox confirmPasswordInputTextBox;
        private System.Windows.Forms.TextBox hintInputTextBox;
        private System.Windows.Forms.Label usernameInputLabel;
        private System.Windows.Forms.Label passwordInputLabel;
        private System.Windows.Forms.Label cofirmPasswordInputLabel;
        private System.Windows.Forms.Label passwordHintInputLabel;
        private System.Windows.Forms.Label createAccountHeaderLabel;
        private System.Windows.Forms.Label createAccountSubHeaderLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createAccountButton;
    }
}