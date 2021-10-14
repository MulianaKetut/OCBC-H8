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
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            //connect db
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_exitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_loginClick(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
        }

        private void btn_registerClick(object sender, EventArgs e)
        {
            if (field_name.Text == "")
            {
                MessageBox.Show("Please input name!");
            }
            else if (field_username.Text == "")
            {
                MessageBox.Show("Please input username!");
            }
            else if (field_password.Text == "")
            {
                MessageBox.Show("Please inpu password!");
            }
            else if (field_confirm_password.Text == "")
            {
                MessageBox.Show("Please input confirm password!");
            }
            else
            {
                if (field_password.Text != field_confirm_password.Text)
                {
                    MessageBox.Show("Password and Confirm password must be the same!");
                }
                else
                {
                    try
                    {
                        Console.WriteLine(field_name);
                        db.Execute("INSERT INTO user_info(names, username, password) VALUES ('" + field_name.Text + "', '" + field_username.Text + "', '" + field_password.Text + "')");
                        MessageBox.Show("User Registered!");
                        this.Close();
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show("Eror! "+err.Message);
                    }
                }
            }
        }
    }
}
