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
            this.newItemNameTextBox = new System.Windows.Forms.TextBox();
            this.newItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.newItemNameTextBoxLabel = new System.Windows.Forms.Label();
            this.newItemPriceTextBoxLabel = new System.Windows.Forms.Label();
            this.itemEditPanel = new System.Windows.Forms.Panel();
            this.taxRateTextBox = new System.Windows.Forms.TextBox();
            this.taxRateTextBoxLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maxPriceChangeAmountLabel = new System.Windows.Forms.Label();
            this.priceChangeAmountTextBox = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.itemEditPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsHeaderLabel
            // 
            this.settingsHeaderLabel.AutoSize = true;
            this.settingsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsHeaderLabel.Location = new System.Drawing.Point(278, 9);
            this.settingsHeaderLabel.Name = "settingsHeaderLabel";
            this.settingsHeaderLabel.Size = new System.Drawing.Size(68, 20);
            this.settingsHeaderLabel.TabIndex = 0;
            this.settingsHeaderLabel.Text = "Settings";
            // 
            // settingsSubHeaderLabel
            // 
            this.settingsSubHeaderLabel.AutoSize = true;
            this.settingsSubHeaderLabel.Location = new System.Drawing.Point(153, 29);
            this.settingsSubHeaderLabel.Name = "settingsSubHeaderLabel";
            this.settingsSubHeaderLabel.Size = new System.Drawing.Size(318, 13);
            this.settingsSubHeaderLabel.TabIndex = 1;
            this.settingsSubHeaderLabel.Text = "(If the account you\'re using is new, you\'ll have to configure it here)";
            // 
            // newItemNameTextBox
            // 
            this.newItemNameTextBox.Location = new System.Drawing.Point(73, 37);
            this.newItemNameTextBox.Name = "newItemNameTextBox";
            this.newItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.newItemNameTextBox.TabIndex = 2;
            // 
            // newItemPriceTextBox
            // 
            this.newItemPriceTextBox.Location = new System.Drawing.Point(73, 11);
            this.newItemPriceTextBox.Name = "newItemPriceTextBox";
            this.newItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.newItemPriceTextBox.TabIndex = 3;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(86, 63);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.AutoSize = true;
            this.removeItemButton.Location = new System.Drawing.Point(83, 92);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(80, 23);
            this.removeItemButton.TabIndex = 5;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // newItemNameTextBoxLabel
            // 
            this.newItemNameTextBoxLabel.AutoSize = true;
            this.newItemNameTextBoxLabel.Location = new System.Drawing.Point(8, 14);
            this.newItemNameTextBoxLabel.Name = "newItemNameTextBoxLabel";
            this.newItemNameTextBoxLabel.Size = new System.Drawing.Size(61, 13);
            this.newItemNameTextBoxLabel.TabIndex = 6;
            this.newItemNameTextBoxLabel.Text = "Item Name:";
            // 
            // newItemPriceTextBoxLabel
            // 
            this.newItemPriceTextBoxLabel.AutoSize = true;
            this.newItemPriceTextBoxLabel.Location = new System.Drawing.Point(12, 40);
            this.newItemPriceTextBoxLabel.Name = "newItemPriceTextBoxLabel";
            this.newItemPriceTextBoxLabel.Size = new System.Drawing.Size(57, 13);
            this.newItemPriceTextBoxLabel.TabIndex = 7;
            this.newItemPriceTextBoxLabel.Text = "Item Price:";
            // 
            // itemEditPanel
            // 
            this.itemEditPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemEditPanel.Controls.Add(this.newItemPriceTextBox);
            this.itemEditPanel.Controls.Add(this.newItemPriceTextBoxLabel);
            this.itemEditPanel.Controls.Add(this.newItemNameTextBox);
            this.itemEditPanel.Controls.Add(this.newItemNameTextBoxLabel);
            this.itemEditPanel.Controls.Add(this.addItemButton);
            this.itemEditPanel.Controls.Add(this.removeItemButton);
            this.itemEditPanel.Location = new System.Drawing.Point(12, 303);
            this.itemEditPanel.Name = "itemEditPanel";
            this.itemEditPanel.Size = new System.Drawing.Size(181, 126);
            this.itemEditPanel.TabIndex = 8;
            // 
            // taxRateTextBox
            // 
            this.taxRateTextBox.Location = new System.Drawing.Point(134, 7);
            this.taxRateTextBox.Name = "taxRateTextBox";
            this.taxRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxRateTextBox.TabIndex = 9;
            // 
            // taxRateTextBoxLabel
            // 
            this.taxRateTextBoxLabel.AutoSize = true;
            this.taxRateTextBoxLabel.Location = new System.Drawing.Point(6, 10);
            this.taxRateTextBoxLabel.Name = "taxRateTextBoxLabel";
            this.taxRateTextBoxLabel.Size = new System.Drawing.Size(119, 13);
            this.taxRateTextBoxLabel.TabIndex = 10;
            this.taxRateTextBoxLabel.Text = "Tax Rate (as a decimal)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.taxRateTextBoxLabel);
            this.panel1.Controls.Add(this.taxRateTextBox);
            this.panel1.Location = new System.Drawing.Point(199, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 35);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.maxPriceChangeAmountLabel);
            this.panel2.Controls.Add(this.priceChangeAmountTextBox);
            this.panel2.Location = new System.Drawing.Point(199, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 35);
            this.panel2.TabIndex = 12;
            // 
            // maxPriceChangeAmountLabel
            // 
            this.maxPriceChangeAmountLabel.AutoSize = true;
            this.maxPriceChangeAmountLabel.Location = new System.Drawing.Point(3, 8);
            this.maxPriceChangeAmountLabel.Name = "maxPriceChangeAmountLabel";
            this.maxPriceChangeAmountLabel.Size = new System.Drawing.Size(166, 13);
            this.maxPriceChangeAmountLabel.TabIndex = 11;
            this.maxPriceChangeAmountLabel.Text = "Max Price Change Amount (+ or -)";
            // 
            // priceChangeAmountTextBox
            // 
            this.priceChangeAmountTextBox.Location = new System.Drawing.Point(175, 5);
            this.priceChangeAmountTextBox.Name = "priceChangeAmountTextBox";
            this.priceChangeAmountTextBox.Size = new System.Drawing.Size(59, 20);
            this.priceChangeAmountTextBox.TabIndex = 10;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(530, 406);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(82, 23);
            this.saveSettingsButton.TabIndex = 13;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.itemEditPanel);
            this.Controls.Add(this.settingsSubHeaderLabel);
            this.Controls.Add(this.settingsHeaderLabel);
            this.Name = "Form6";
            this.Text = "Form6";
            this.itemEditPanel.ResumeLayout(false);
            this.itemEditPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsHeaderLabel;
        private System.Windows.Forms.Label settingsSubHeaderLabel;
        private System.Windows.Forms.TextBox newItemNameTextBox;
        private System.Windows.Forms.TextBox newItemPriceTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label newItemNameTextBoxLabel;
        private System.Windows.Forms.Label newItemPriceTextBoxLabel;
        private System.Windows.Forms.Panel itemEditPanel;
        private System.Windows.Forms.TextBox taxRateTextBox;
        private System.Windows.Forms.Label taxRateTextBoxLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label maxPriceChangeAmountLabel;
        private System.Windows.Forms.TextBox priceChangeAmountTextBox;
        private System.Windows.Forms.Button saveSettingsButton;
    }
}