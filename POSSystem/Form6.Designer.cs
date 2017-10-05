namespace POSSystem
{
    partial class Form6
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
            this.settingsHeaderLabel = new System.Windows.Forms.Label();
            this.settingsSubHeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsHeaderLabel
            // 
            this.settingsHeaderLabel.AutoSize = true;
            this.settingsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsHeaderLabel.Location = new System.Drawing.Point(314, 68);
            this.settingsHeaderLabel.Name = "settingsHeaderLabel";
            this.settingsHeaderLabel.Size = new System.Drawing.Size(68, 20);
            this.settingsHeaderLabel.TabIndex = 0;
            this.settingsHeaderLabel.Text = "Settings";
            // 
            // settingsSubHeaderLabel
            // 
            this.settingsSubHeaderLabel.AutoSize = true;
            this.settingsSubHeaderLabel.Location = new System.Drawing.Point(189, 100);
            this.settingsSubHeaderLabel.Name = "settingsSubHeaderLabel";
            this.settingsSubHeaderLabel.Size = new System.Drawing.Size(318, 13);
            this.settingsSubHeaderLabel.TabIndex = 1;
            this.settingsSubHeaderLabel.Text = "(If the account you\'re using is new, you\'ll have to configure it here)";
            this.settingsSubHeaderLabel.Click += new System.EventHandler(this.settingsSubHeaderLabel_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.settingsSubHeaderLabel);
            this.Controls.Add(this.settingsHeaderLabel);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsHeaderLabel;
        private System.Windows.Forms.Label settingsSubHeaderLabel;
    }
}