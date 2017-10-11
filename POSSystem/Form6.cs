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

                for (int i=0;i<howManyItems;i++)
                {

                }
            }
        }
    }
}
