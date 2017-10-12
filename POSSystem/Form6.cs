using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            if  (itemPreviewTable.RowCount == 1 && itemPreviewTable.ColumnCount == 1) //checks to see if items have already been made
            {
                noItemsLabel.Visible = true; //tells the user to add some items to show them in the table
            }

            if (itemPreviewTable.RowCount != 1 && itemPreviewTable.ColumnCount != 1) //checks to see if the user has added items
            {
                noItemsLabel.Dispose(); //removes the label telling the user that they need to add items
            }
        }

        private void applyItemsNumberButton_Click(object sender, EventArgs e) //runs when the user applies how many items they want
        {
            if (itemCounter.Value != 0) //only runs our code if the user has actually input a value, not 0
            {
                noItemsLabel.Dispose(); //disposes of our label since we've created items and we don't need it anymore

                int howManyItems = Convert.ToInt32(itemCounter.Value); //converts the number the user input into an int variable

                itemPreviewTable.RowCount = howManyItems; //sets the amount of rows to the number the user has input
                itemPreviewTable.ColumnCount = 2; //sets the amount of columns to 2 - we had it set to one so it looked better visually when there are no items inputted
                itemPreviewTable.RowStyles.Clear(); //clears the default style for the rows in our table
                itemPreviewTable.ColumnStyles.Clear(); //clears the default style for the columns in our table

                itemPreviewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (itemPreviewTable.Width / 2))); //makes our column occupy half of the table (we only need to do this once since there are only 2 columns)

                for (int i = 1; i <= itemPreviewTable.RowCount; i++) //loop adds a new row style for every row we add
                {
                    itemPreviewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (100 / howManyItems))); //sets the style to be a percent based on how many items the user has added
                }
            }
        }
    }
}
