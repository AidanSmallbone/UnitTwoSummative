using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            //names the forgot password form so we can call upon it, and shows the form

            Form2 forgotPasswordForm = new Form2();
            forgotPasswordForm.Show();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            //names the new account form so we can call upon it, and shows the form

            Form3 newAccountForm = new Form3();
            newAccountForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = File.ReadLines(@".\login.txt").Take(1).First(); //creates a string and sets the value to the username that's been saved
            string password = File.ReadLines(@".\login.txt").Skip(1).Take(1).First(); //creates a string and sets the value to the password that's been saved

            if (usernameInputTextBox.Text != username) //checks if the correct username was entered
            {
                usernameInputTextBox.ForeColor = Color.Red; //sets the text color to red
                usernameInputTextBox.Text = "Incorrect Credentials"; //tells the user the username they've entered doesn't match
                Refresh(); //refreshes the form so the changes are reflected
                Thread.Sleep(1500); //waits 1500ms
                usernameInputTextBox.ForeColor = Color.Black; //sets the color text back to black
                usernameInputTextBox.Text = ""; //empties the text box so they can reenter the correct information
            }

            if (passwordInputTextBox.Text != password) //checks if the correct password was entered
            {
                passwordInputTextBox.ForeColor = Color.Red; //sets the text color to red
                passwordInputTextBox.Text = "Incorrect Credentials"; //tells the user the password they've entered doesn't match
                Refresh(); //refreshes the form so the changes are reflected
                Thread.Sleep(1500); //waits 1500ms
                passwordInputTextBox.ForeColor = Color.Black; //sets the text color back to black
                passwordInputTextBox.Text = ""; //empties the text box so they can reenter the correct information
            }

            if (usernameInputTextBox.Text == username && passwordInputTextBox.Text == password) //checks to see if both username and password are correct
            {
                Form5 posSystem = new Form5(); //names the form where our POS system will exist
                posSystem.Show(); //shows it
            }
        }
    }
}
