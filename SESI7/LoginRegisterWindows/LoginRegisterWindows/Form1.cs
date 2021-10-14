using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterWindows
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            //pass the database you want to connect to
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_loginClick(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM user_info WHERE username='" + field_username.Text + "' AND password='" + field_password.Text + "'");
            if (db.Count() == 1)
            {
                MessageBox.Show("Login Success! You logged in as " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username or password combination!");
            }
        }

        private void btn_registerClick(object sender, EventArgs e)
        {
            //show register window
            Register register = new Register();
            register.Show();
        }
        private void btn_exitClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
