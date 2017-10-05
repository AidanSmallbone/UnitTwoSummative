namespace POSSystem
{
    partial class Form4
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
            this.finishCreateAccountLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finishCreateAccountLabel
            // 
            this.finishCreateAccountLabel.Location = new System.Drawing.Point(12, 9);
            this.finishCreateAccountLabel.Name = "finishCreateAccountLabel";
            this.finishCreateAccountLabel.Size = new System.Drawing.Size(195, 35);
            this.finishCreateAccountLabel.TabIndex = 0;
            this.finishCreateAccountLabel.Text = "ATTENTION: All fields must be filled in to create an account";
            this.finishCreateAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(72, 47);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 81);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.finishCreateAccountLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "ATTENTION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label finishCreateAccountLabel;
        private System.Windows.Forms.Button okButton;
    }
}