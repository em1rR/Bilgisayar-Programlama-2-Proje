using DepartmentSystemClient.DTO;
using DepartmentSystemClient.Entities;
using DepartmentSystemClient.GenericDTO;
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
    public partial class lecturer : Form
    {
        public lecturer()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        public string UserEmail { get; set; }

        Lecturer _lecturer = new Lecturer();

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
           
            var response = await Methods.GetLecturerAsync(UserEmail);
            if(response.Status == true)
            {

                formProfile frmProfile = new formProfile();
                frmProfile.lecturer = _lecturer;
                openChildForm(frmProfile);
            }

            

        }

        private async void lecturer_Load(object sender, EventArgs e)
        {
            try
            {
                var response = await Methods.GetLecturerAsync(UserEmail);
                if (response.Status == true)
                {
                    Lecturer lecturer = new Lecturer();
                    lecturer.id = response.Data.Id;
                    lecturer.name = response.Data.Name;
                    lecturer.surname = response.Data.Surname;
                    lecturer.email = response.Data.Email;

                    _lecturer = lecturer;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public static implicit operator lecturer(ApiResponse<LecturerDTO> v)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentGradeList frmStudentGradeList = new StudentGradeList();
            frmStudentGradeList._lecturer = _lecturer;
            openChildForm(frmStudentGradeList);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
