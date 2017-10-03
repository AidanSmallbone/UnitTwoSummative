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
    public partial class loginForm : Form
    {
        public loginForm()
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
    }
}
