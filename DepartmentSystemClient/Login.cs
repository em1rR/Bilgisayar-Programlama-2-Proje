using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentSystemClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Admin 
            //txtEmail.Text = "deneme@abc.com";
            //txtPassword.Text = "$admin@2022";

            //Lecturer 1 - 2 - 3
            //    basak@gmail.com
            //    123asD
            
            //    faruk@gmail.com
            //    654ewD

            //    ahmet@gmail.com
            //    879vbD

            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                var response = await Methods.Login(txtEmail.Text, txtPassword.Text);
                if (response == true)
                {
                    if(rdbtnAdmin.Checked && txtEmail.Text == "deneme@abc.com")
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                    }
                    else if(rdbtnLecturer.Checked)
                    {
                        this.Hide();
                        lecturer lecturerForm = new lecturer();
                        lecturerForm.UserEmail = txtEmail.Text;
                        lecturerForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please checked the radio button");
                    }
                }
                else
                {
                    MessageBox.Show("Unknown user");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the requarites area");
            }
            
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
