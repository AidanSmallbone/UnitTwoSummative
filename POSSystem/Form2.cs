using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string passwordHint = File.ReadLines(@".\login.txt").Skip(2).Take(1).First(); //creates a string and sets its value to the 3rd line of the text file that contains our login info

            if (string.IsNullOrEmpty(passwordHint)) //checks to see if the string we created is empty so we can tell if the user has made an account yet
            {
                passwordHintLabel.Text = "It appears there is no account saved, please create an account first."; //tells the user they need to create an account
            }
            else //if the string isn't null/empty this runs
            {
                passwordHintLabel.Text = "Password hint: " + passwordHint; //sets the label to display the password hint
            }

        }
    }
}
