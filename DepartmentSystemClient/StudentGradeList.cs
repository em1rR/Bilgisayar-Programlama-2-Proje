using DepartmentSystemClient.DTO;
using DepartmentSystemClient.Entities;
using DepartmentSystemClient.Filter;
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
    public partial class StudentGradeList : Form
    {
        public StudentGradeList()
        {
            InitializeComponent();
        }

        public Lecturer _lecturer = new Lecturer();
        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        private async Task FillComboboxGender(ComboBox comboBox, string type)
        {

            //comboBox.Items.Add("All");
            //comboBox.Items.Add("Male");
            //comboBox.Items.Add("Female");
            //comboBox.SelectedIndex = 0;

            //comboBox.DataSource = Methods.GetGender();
            //Dictionary<string, int> a = new Dictionary<string, int>();
            var a = await Methods.GetGender(type);
            comboBox.DataSource = a;
            /// comboBox.DataSource = new BindingSource(genderDictionary, null);
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";

            //var genderDictionary = await Methods.GetGender();
            //comboBox.DataSource = new BindingSource(genderDictionary, null);
            //comboBox.DisplayMember = "Key";
            //comboBox.ValueMember = "Value";

            //comboBox.DataSource = Enum.GetValues(typeof(Gender));
            //comboBox.SelectedIndex = 2;

            //comboBox.DisplayMember = "Text";
            //comboBox.ValueMember = "Value";

            //var items = new[] {
            //    new { Text = "All", Value = "null" },
            //    new { Text = "Male", Value = "0" },
            //    new { Text = "Female", Value = "1" },
            //};

            //comboBox.DataSource = items;

        }
        private async Task FillComboboxGraduate(ComboBox comboBox)
        {
            var graduates = await Methods.GetAllGraduates();

            comboBox.DataSource = graduates;

            var allOption = new Graduate();
            allOption.id = 0;
            allOption.name = "All";
            graduates.Insert(0, allOption);

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            //comboBox.Text = "Select a department";


        }
        private async Task FillComboboxDepartment(ComboBox comboBox)
        {
            var departments = await Methods.GetAllDepartments();
            comboBox.DataSource = departments;

            var allOption = new Department();
            allOption.id = 0;
            allOption.name = "All";
            departments.Insert(0, allOption);

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            //comboBox.Text = "Select a department";
        }

        private async Task FillComboboxCourses(ComboBox comboBox)
        {
            try
            {
                var courses = await Methods.GetCourseByLecturerId(_lecturer.id);
                comboBox.DataSource = courses.Data;

                //var allOption = new CourseDTO();
                //allOption.id = 0;
                //allOption.name = "All";
                //courses.Data.Insert(0, allOption);

                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                throw;
            }

            
            //comboBox.Text = "Select a department";
        }
        private void StudentGradeList_Load(object sender, EventArgs e)
        {
            FillComboboxDepartment(comboBoxDepartment);
            FillComboboxGraduate(comboBoxSearchGraduate);
            FillComboboxGender(comboBoxSearchGender, "search");
            FillComboboxCourses(comboBoxLesson);

        }

        private async void btnChooseLesson_Click(object sender, EventArgs e)
        {
            StudentFilter studentFilter = new StudentFilter();
            if (txtSearchId.Text != "")
            {
                studentFilter.Id = Int16.Parse(txtSearchId.Text);
            }
            if (txtSearchName.Text != "")
            {
                studentFilter.Name = txtSearchName.Text;
            }
            //if(txtSearchDepartmentId.Text != "")
            //{
            //    studentFilter.DepartmentId = Int16.Parse(txtSearchDepartmentId.Text);
            //}
            if (comboBoxDepartment.SelectedIndex != 0 || comboBoxDepartment.SelectedIndex != -1)
            {
                studentFilter.DepartmentId = int.Parse(comboBoxDepartment.SelectedValue.ToString());
            }

            if (comboBoxSearchGraduate.SelectedIndex != 0 || comboBoxSearchGraduate.SelectedIndex != -1)
            {
                studentFilter.GraduateId = int.Parse(comboBoxSearchGraduate.SelectedValue.ToString());
            }


            //if (txtSearchGraduateId.Text != "")
            //{
            //    studentFilter.GraduateId = Int16.Parse(txtSearchGraduateId.Text);
            //}

            //studentFilter.Gender = (byte)comboBoxSearchGender.Text;
            //Gender enum = (Gender)comboBoxSearchGender.SelectedItem;
            studentFilter.Gender = (byte)comboBoxSearchGender.SelectedValue;
            studentFilter.LessonId = int.Parse(comboBoxLesson.SelectedValue.ToString());
            LessonId = studentFilter.LessonId;

            //var url = await Methods.GetBySearch(studentFilter);
            try
            {
                var url = await Methods.GetBySearchStudentGradeDTO(studentFilter);
                if (url.Status == true)
                {
                    DGWStudentCourseGradeList.DataSource = url.Data;
                    DGWStudentCourseGradeList.DataSource = url.Data;
                    DGWStudentCourseGradeList.Columns[0].Width = 50;
                    DGWStudentCourseGradeList.Columns[4].Width = 50;
                    DGWStudentCourseGradeList.Columns[5].Width = 50;
                    DGWStudentCourseGradeList.Columns[6].Width = 50;
                    DGWStudentCourseGradeList.Columns[7].Width = 50;
                    DGWStudentCourseGradeList.Columns[8].Width = 50;
                    DGWStudentCourseGradeList.Columns[9].Width = 50;
                    DGWStudentCourseGradeList.Columns["lessonId"].Visible = false;
                }
                else
                {
                    MessageBox.Show(url.Message);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            StudentFilter studentFilter = new StudentFilter();
            if (txtSearchId.Text != "")
            {
                studentFilter.Id = Int16.Parse(txtSearchId.Text);
            }
            if (txtSearchName.Text != "")
            {
                studentFilter.Name = txtSearchName.Text;
            }
            //if(txtSearchDepartmentId.Text != "")
            //{
            //    studentFilter.DepartmentId = Int16.Parse(txtSearchDepartmentId.Text);
            //}
            if (comboBoxDepartment.SelectedIndex != 0 || comboBoxDepartment.SelectedIndex != -1)
            {
                studentFilter.DepartmentId = int.Parse(comboBoxDepartment.SelectedValue.ToString());
            }

            if (comboBoxSearchGraduate.SelectedIndex != 0 || comboBoxSearchGraduate.SelectedIndex != -1)
            {
                studentFilter.GraduateId = int.Parse(comboBoxSearchGraduate.SelectedValue.ToString());
            }


            //if (txtSearchGraduateId.Text != "")
            //{
            //    studentFilter.GraduateId = Int16.Parse(txtSearchGraduateId.Text);
            //}

            //studentFilter.Gender = (byte)comboBoxSearchGender.Text;
            //Gender enum = (Gender)comboBoxSearchGender.SelectedItem;
            studentFilter.Gender = (byte)comboBoxSearchGender.SelectedValue;
            studentFilter.LessonId = int.Parse(comboBoxLesson.SelectedValue.ToString());

            //var url = await Methods.GetBySearch(studentFilter);
            try
            {
                var url = await Methods.GetBySearchStudentGradeDTO(studentFilter);
                if (url.Status == true)
                {
                    DGWStudentCourseGradeList.DataSource = url.Data;
                    DGWStudentCourseGradeList.Columns[0].Width = 50;
                    DGWStudentCourseGradeList.Columns[4].Width = 50;
                    DGWStudentCourseGradeList.Columns[5].Width = 50;
                    DGWStudentCourseGradeList.Columns[6].Width = 50;
                    DGWStudentCourseGradeList.Columns[7].Width = 50;
                    DGWStudentCourseGradeList.Columns[8].Width = 50;
                    DGWStudentCourseGradeList.Columns[9].Width = 50;
                    DGWStudentCourseGradeList.Columns["lessonId"].Visible = false;
                }
                else
                {
                    MessageBox.Show(url.Message);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int editedStudentDTOId;
        private int LessonId;
        private void DGWStudentCourseGradeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentGradeDTO studentDTO = (StudentGradeDTO)DGWStudentCourseGradeList.CurrentRow.DataBoundItem;
            txtAddVize.Text = studentDTO.Vize.ToString();
            txtAddFinal.Text = studentDTO.Final.ToString();
            txtAddBut.Text = studentDTO.But.ToString();
            //studentDTO.Vize = int.Parse(txtAddVize.Text);
            //studentDTO.Final = int.Parse(txtAddFinal.Text);
            //studentDTO.But = int.Parse(txtAddBut.Text);
            editedStudentDTOId = studentDTO.Id;
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtAddVize.Text != "" && txtAddFinal.Text != "" && txtAddBut.Text != "")
            {
                //Student student = new Student { id = 8, name = "ekle", department_id=1, graduate_id=1};
                EditStudentCourseGradeDTO student = new EditStudentCourseGradeDTO();
                student.LessonId = LessonId;
                student.Id = editedStudentDTOId; 
                student.Vize = Int32.Parse(txtAddVize.Text);
                student.Final = Int32.Parse(txtAddFinal.Text);
                student.But = Int32.Parse(txtAddBut.Text);
                var url = await Methods.EditStudentGradeAsync(student.Id, student);
                MessageBox.Show(url.Message);

            }
            else
            {
                MessageBox.Show("Please fill all required fields");
            }
           
            txtAddVize.Text = "";
            txtAddFinal.Text = "";
            txtAddBut.Text = "";
        }
    }
}
