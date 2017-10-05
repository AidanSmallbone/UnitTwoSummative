using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.Close(); //closes the form when the user clicks the cancel button
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameInputTextBox.Text) || string.IsNullOrEmpty(passwordInputTextBox.Text) || string.IsNullOrEmpty(confirmPasswordInputTextBox.Text) || string.IsNullOrEmpty(hintInputTextBox.Text)) //checks to see if any text fields are empty
            {
                Form4 notFilledIn = new Form4(); //names form4 so we can call upon it
                notFilledIn.Show(); //shows the form
            }
            else
            {
                if (passwordInputTextBox.Text != confirmPasswordInputTextBox.Text)
                {
                    passwordInputTextBox.ForeColor = Color.Red; //sets the text color to red
                    passwordInputTextBox.Text = "Passwords Must Match"; //tells the user the password they've entered doesn't match
                    confirmPasswordInputTextBox.ForeColor = Color.Red; //sets the text color to red
                    confirmPasswordInputTextBox.Text = "Passwords Must Match"; //tells the user the password they've entered doesn't match
                    Refresh(); //refreshes the form so the changes are reflected
                    Thread.Sleep(1500); //waits 1500ms
                    passwordInputTextBox.ForeColor = Color.Black; //sets the color text back to black
                    passwordInputTextBox.Text = ""; //empties the text box so they can reenter the correct information
                    confirmPasswordInputTextBox.ForeColor = Color.Black; //sets the color text back to black
                    confirmPasswordInputTextBox.Text = ""; //empties the text box so they can reenter the correct information
                }
                else
                {
                    string[] loginInfo = { usernameInputTextBox.Text, passwordInputTextBox.Text, hintInputTextBox.Text }; //creates a string that hold the values the user input into our text boxes
                    System.IO.File.WriteAllLines(@".\login.txt", loginInfo); //writes the info in the string to a text file
                    this.Close(); //closes the form
                }
            }
        }
    }
}
