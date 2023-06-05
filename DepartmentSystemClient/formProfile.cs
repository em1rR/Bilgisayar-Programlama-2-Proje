using DepartmentSystemClient.Entities;
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
    public partial class formProfile : Form
    {
        public formProfile()
        {
            InitializeComponent();
        }

        public Lecturer lecturer = new Lecturer();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void formProfile_Load(object sender, EventArgs e)
        {
            lblName.Text = lecturer.name;
            lblSurname.Text = lecturer.surname;
            lblEmail.Text = lecturer.email;
        }
    }
}
