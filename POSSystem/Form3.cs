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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //closes the form if the user clicks the cancel button

            this.Close();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (usernameInputTextBox.Text == null || passwordInputTextBox.Text == null || confirmPasswordInputTextBox.Text == null || hintInputTextBox.Text == null)
            {
                createAccountSubHeaderLabel.ForeColor = Color.Red;
            };

            //creates a string that takes in all of the info the user provides, and writes it to a text file so that it's saved and other forms can access it, then we close the form

            string[] accountInfo = {usernameInputTextBox.Text, passwordInputTextBox.Text, hintInputTextBox.Text};
            System.IO.File.WriteAllLines(@".\accountinfo.txt", accountInfo);
            this.Close();
        }
    }
}
