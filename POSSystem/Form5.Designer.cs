namespace POSSystem
{
    partial class Form5
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.deleteLastItemButton = new System.Windows.Forms.Button();
            this.changePriceButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 25);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.changePriceButton);
            this.panel3.Controls.Add(this.deleteLastItemButton);
            this.panel3.Controls.Add(this.settingsButton);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 386);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(192, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 386);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(3, 356);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(164, 23);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings...";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // deleteLastItemButton
            // 
            this.deleteLastItemButton.Location = new System.Drawing.Point(3, 327);
            this.deleteLastItemButton.Name = "deleteLastItemButton";
            this.deleteLastItemButton.Size = new System.Drawing.Size(164, 23);
            this.deleteLastItemButton.TabIndex = 1;
            this.deleteLastItemButton.Text = "Remove Last Item";
            this.deleteLastItemButton.UseVisualStyleBackColor = true;
            // 
            // changePriceButton
            // 
            this.changePriceButton.Location = new System.Drawing.Point(3, 298);
            this.changePriceButton.Name = "changePriceButton";
            this.changePriceButton.Size = new System.Drawing.Size(164, 23);
            this.changePriceButton.TabIndex = 2;
            this.changePriceButton.Text = "Change Item Price";
            this.changePriceButton.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changePriceButton;
        private System.Windows.Forms.Button deleteLastItemButton;
        private System.Windows.Forms.Button settingsButton;
    }
}