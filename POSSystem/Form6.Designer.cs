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
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.itemSettings = new System.Windows.Forms.TabPage();
            this.applyItemsNumberButton = new System.Windows.Forms.Button();
            this.itemCounterLabel = new System.Windows.Forms.Label();
            this.itemCounter = new System.Windows.Forms.NumericUpDown();
            this.itemPreviewTable = new System.Windows.Forms.TableLayoutPanel();
            this.noItemsLabel = new System.Windows.Forms.Label();
            this.priceSettings = new System.Windows.Forms.TabPage();
            this.recieptSettings = new System.Windows.Forms.TabPage();
            this.settingsTabs.SuspendLayout();
            this.itemSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCounter)).BeginInit();
            this.itemPreviewTable.SuspendLayout();
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
            // settingsTabs
            // 
            this.settingsTabs.Controls.Add(this.itemSettings);
            this.settingsTabs.Controls.Add(this.priceSettings);
            this.settingsTabs.Controls.Add(this.recieptSettings);
            this.settingsTabs.Location = new System.Drawing.Point(12, 32);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(600, 397);
            this.settingsTabs.TabIndex = 1;
            // 
            // itemSettings
            // 
            this.itemSettings.Controls.Add(this.applyItemsNumberButton);
            this.itemSettings.Controls.Add(this.itemCounterLabel);
            this.itemSettings.Controls.Add(this.itemCounter);
            this.itemSettings.Controls.Add(this.itemPreviewTable);
            this.itemSettings.Location = new System.Drawing.Point(4, 22);
            this.itemSettings.Name = "itemSettings";
            this.itemSettings.Padding = new System.Windows.Forms.Padding(3);
            this.itemSettings.Size = new System.Drawing.Size(592, 371);
            this.itemSettings.TabIndex = 0;
            this.itemSettings.Text = "Items";
            this.itemSettings.UseVisualStyleBackColor = true;
            // 
            // applyItemsNumberButton
            // 
            this.applyItemsNumberButton.Location = new System.Drawing.Point(282, 6);
            this.applyItemsNumberButton.Name = "applyItemsNumberButton";
            this.applyItemsNumberButton.Size = new System.Drawing.Size(42, 23);
            this.applyItemsNumberButton.TabIndex = 3;
            this.applyItemsNumberButton.Text = "Apply";
            this.applyItemsNumberButton.UseVisualStyleBackColor = true;
            this.applyItemsNumberButton.Click += new System.EventHandler(this.applyItemsNumberButton_Click);
            // 
            // itemCounterLabel
            // 
            this.itemCounterLabel.AutoSize = true;
            this.itemCounterLabel.Location = new System.Drawing.Point(123, 9);
            this.itemCounterLabel.Name = "itemCounterLabel";
            this.itemCounterLabel.Size = new System.Drawing.Size(87, 13);
            this.itemCounterLabel.TabIndex = 2;
            this.itemCounterLabel.Text = "Number of Items:";
            // 
            // itemCounter
            // 
            this.itemCounter.Location = new System.Drawing.Point(216, 7);
            this.itemCounter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.itemCounter.Name = "itemCounter";
            this.itemCounter.Size = new System.Drawing.Size(60, 20);
            this.itemCounter.TabIndex = 1;
            // 
            // itemPreviewTable
            // 
            this.itemPreviewTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.itemPreviewTable.ColumnCount = 1;
            this.itemPreviewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemPreviewTable.Controls.Add(this.noItemsLabel, 0, 0);
            this.itemPreviewTable.Location = new System.Drawing.Point(330, 6);
            this.itemPreviewTable.Name = "itemPreviewTable";
            this.itemPreviewTable.RowCount = 1;
            this.itemPreviewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemPreviewTable.Size = new System.Drawing.Size(256, 359);
            this.itemPreviewTable.TabIndex = 0;
            // 
            // noItemsLabel
            // 
            this.noItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noItemsLabel.Location = new System.Drawing.Point(6, 3);
            this.noItemsLabel.Name = "noItemsLabel";
            this.noItemsLabel.Size = new System.Drawing.Size(244, 26);
            this.noItemsLabel.TabIndex = 0;
            this.noItemsLabel.Text = "You haven\'t added any items! Add some and they will appear here";
            this.noItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noItemsLabel.Visible = false;
            // 
            // priceSettings
            // 
            this.priceSettings.Location = new System.Drawing.Point(4, 22);
            this.priceSettings.Name = "priceSettings";
            this.priceSettings.Padding = new System.Windows.Forms.Padding(3);
            this.priceSettings.Size = new System.Drawing.Size(592, 371);
            this.priceSettings.TabIndex = 1;
            this.priceSettings.Text = "Pricing";
            this.priceSettings.UseVisualStyleBackColor = true;
            // 
            // recieptSettings
            // 
            this.recieptSettings.Location = new System.Drawing.Point(4, 22);
            this.recieptSettings.Name = "recieptSettings";
            this.recieptSettings.Padding = new System.Windows.Forms.Padding(3);
            this.recieptSettings.Size = new System.Drawing.Size(592, 371);
            this.recieptSettings.TabIndex = 2;
            this.recieptSettings.Text = "Receipt";
            this.recieptSettings.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.settingsTabs);
            this.Controls.Add(this.settingsHeaderLabel);
            this.Name = "Form6";
            this.Text = "Form6";
            this.settingsTabs.ResumeLayout(false);
            this.itemSettings.ResumeLayout(false);
            this.itemSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCounter)).EndInit();
            this.itemPreviewTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsHeaderLabel;
        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage itemSettings;
        private System.Windows.Forms.TableLayoutPanel itemPreviewTable;
        private System.Windows.Forms.TabPage priceSettings;
        private System.Windows.Forms.TabPage recieptSettings;
        private System.Windows.Forms.Label noItemsLabel;
        private System.Windows.Forms.Button applyItemsNumberButton;
        private System.Windows.Forms.Label itemCounterLabel;
        private System.Windows.Forms.NumericUpDown itemCounter;
    }
}