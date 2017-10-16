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

            if  (itemPreviewTable.RowCount == 1 && itemPreviewTable.ColumnCount == 1) //checks to see if the user has created any items
            {
                noItemsLabel.Visible = true; //shows the label telling the user to add some items
            }

            if (itemPreviewTable.RowCount != 1 && itemPreviewTable.ColumnCount != 1) //checks if the user has created any items
            {
                noItemsLabel.Dispose(); //disposes of the label if they have created items
            }
        }

        private void applyItemsNumberButton_Click(object sender, EventArgs e)
        {
            if (itemCounter.Value != 0) //only runs this code if the user has actually added some items, does nothing if they haven't
            {
                noItemsLabel.Dispose(); //disposes of thr label if the user has added items

                int howManyItems = Convert.ToInt32(itemCounter.Value); //creates a variable that gets its value from the output of the counter that sets how many items to create

                itemPreviewTable.RowCount = howManyItems; //sets the amount of rows in our table to the amount of items the user has created
                itemPreviewTable.ColumnCount = 2; //sets out column count to 2 (one for name, one for price)
                itemPreviewTable.RowStyles.Clear(); //clears the styling of our table
                itemPreviewTable.ColumnStyles.Clear();

                itemPreviewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (itemPreviewTable.Width / 2))); //sets the columns to half of the size of the table each

                for (int i = 1; i <= itemPreviewTable.RowCount; i++) //adds a new style for every row
                {
                    itemPreviewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (100 / howManyItems))); //sets the rows sizing to the size of the table divided by how many items there are
                }

                int howManyRows = itemPreviewTable.RowCount; //creates a new variable based on how many rows are in the table
                int rowItemCounter = 0; //creates a new variable to keep track of which row to put text boxes in

                void addRow()
                {
                    itemPreviewTable.Controls.Add(new TextBox() { Dock = DockStyle.Fill, Name = "columnOneTextBox" + rowItemCounter}, 0, rowItemCounter); //creates a textbox in the first column of the table and names it
                    itemPreviewTable.Controls.Add(new TextBox() { Dock = DockStyle.Fill, Name = "columnTwoTextBox" + rowItemCounter}, 1, rowItemCounter); //creates a textbox in the second column of the table and names it
                    rowItemCounter = rowItemCounter + 1; //adds to our row variable so they controls are created in the right row
                }

                for (int i = 1; i <= howManyRows; i++) //loop that runs for how many items the user wants
                {
                    addRow(); //runs out addrow method
                }

                //columnOneTextBox1.Text = "Item Name";
                //columnTwoTextBox1.Text = "Item Price";
            }
        }
    }
}
