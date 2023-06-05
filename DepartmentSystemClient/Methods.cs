using DepartmentSystemClient.ComboBoxModel;
using DepartmentSystemClient.DTO;
using DepartmentSystemClient.Entities;
using DepartmentSystemClient.Filter;
using DepartmentSystemClient.GenericDTO;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DepartmentSystemClient
{
    public class Methods
    {
        static string token;
        static public HttpClient ClientAddress()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7275");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        static async public Task<ApiResponse<CreateStudentDTO>> CreateStudentAsync(CreateStudentDTO student)
        {
            try
            {
                var client = ClientAddress();

                HttpResponseMessage response = await client.PostAsJsonAsync("api/App/Student/Post", student);
                var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<CreateStudentDTO>>();
                return apiResponse;
               
            }
            catch (Exception exp)
            {

                throw;
            }
            
        }

        static async public Task<ApiResponse<EditStudentDTO>> EditStudentAsync(int id, EditStudentDTO student)
        {
            try
            {
                var client = ClientAddress();

                string url = "api/App/Student/Put";

                

                HttpResponseMessage response = await client.PutAsJsonAsync(url + id, student);
              
                var apiResponse = new ApiResponse<EditStudentDTO>();
                apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<EditStudentDTO>>();


                return apiResponse;
            }
            catch (Exception exp)
            {

                return null;
            }
        }
        //Delete
        static async public Task<ApiResponse<Student>> DeleteStudentAsync(int id)
        {
            try
            {
                var client = ClientAddress();

                HttpResponseMessage response = await client.DeleteAsync("api/App/Student/Delete" + id);
                var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<Student>>();
                return apiResponse;
            }
            catch (Exception exp)
            {

                throw;
            }
        }

        static async public Task<List<StudentDTO>> GetAllData()
        {
            var students = new List<Student>();
            var client = ClientAddress();

            HttpResponseMessage response = await client.GetAsync("api/App/StudentDto/Get");
            var studentstest = new List<StudentDTO>();
            studentstest = await response.Content.ReadFromJsonAsync<List<StudentDTO>>();
            return studentstest;
        }

        static async public Task<List<Student>> GetBySearchNotUsed(StudentFilter studentFilter)
        {

            var students = new List<Student>();
            //List<Student> students = null;
            var client = ClientAddress();
            string url = "api/App/Student/GetBySearch";
            
            if (studentFilter.Name == null)
                studentFilter.Name = "q";
            string queryString = GetQueryString(studentFilter);
            //url = QueryHelpers.AddQueryString(url, queryString);
            var uri = String.Concat(url, queryString);
            var response = await client.GetAsync(uri);

            //students = response.Content.ReadAsAsync<List<Student>>();
            try
            {
                students = await response.Content.ReadFromJsonAsync<List<Student>>();
               //var resp =  await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {

                throw;
            }
            //students = new List<Student>();
            //students.Add(resp);
            return students;
        }
        //static async public Task<List<StudentDTO>> GetBySearchTestDTO(StudentFilter studentFilter)

        static async public Task<ApiResponse<List<StudentDTO>>> GetBySearchDTO(StudentFilter studentFilter)
        {
            var students = new ApiResponse<List<StudentDTO>>();
            var client = ClientAddress();
            string url = "api/App/Student/GetBySearch";

            if (studentFilter.Name == null)
                studentFilter.Name = "q";

            string queryString = GetQueryString(studentFilter);
            var uri = String.Concat(url, queryString);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await client.GetAsync(uri);

            students = await response.Content.ReadFromJsonAsync<ApiResponse<List<StudentDTO>>>();

            return students;
        }

        //Not used
        static async public Task<List<Student>> GetBySearchTest(StudentFilter studentFilter)
        {
            var students = new List<Student>();
            //List<Student> students = null;
            var client = ClientAddress();
            string url = "api/App/Student/GetBySearch";
            string q = "qwe";

            //url = string.Format("api/App/Student/Get/id={0}&type={1}", q, q);

            var asd = studentFilter;
            var query = new Dictionary<string, string>
            {
                ["id"] = studentFilter.Id.ToString(),
                ["name"] = studentFilter.Name,
                ["department_id"] = studentFilter.DepartmentId.ToString(),
                ["graduate_id"] = studentFilter.GraduateId.ToString(),
                // ...
            };
            //var response = await client.GetAsync(QueryHelpers.AddQueryString(url, query));

            url = QueryHelpers.AddQueryString(url, query);
            //url = QueryHelpers.a
            // Usage:
            string queryString = GetQueryString(studentFilter);
            //url = QueryHelpers.AddQueryString(url, queryString);
            //url = QueryHelpers.AddQueryString(url, queryString);


            HttpResponseMessage response = await client.GetAsync(url);

            //students = response.Content.ReadAsAsync<List<Student>>();
            try
            {
                students = await response.Content.ReadFromJsonAsync<List<Student>>();

            }
            catch (Exception ex)
            {

                throw;
            }
            return students;
        }

        static string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return "?" + String.Join("&", properties.ToArray());
        }

        static async public Task<List<Department>> GetAllDepartments()
        {
            var departments = new List<Department>();
            var client = ClientAddress();

            HttpResponseMessage response = await client.GetAsync("api/App/Department/Get");

            departments = await response.Content.ReadFromJsonAsync<List<Department>>();
            return departments;
        }

        static async public Task<List<Graduate>> GetAllGraduates()
        {
            var graduates = new List<Graduate>();
            var client = ClientAddress();

            HttpResponseMessage response = await client.GetAsync("api/App/Graduate/Get");

            graduates = await response.Content.ReadFromJsonAsync<List<Graduate>>();
            return graduates;
        }

        static async public Task<List<DropDownGenderModel>> GetGender(string type)
        {
            
            var genderDictionary = new List<DropDownGenderModel>();
            var client = ClientAddress();
            string url = "api/App/Gender/Get";
            var uri = String.Concat(url, $"?type={type}");    
            var response = await client.GetAsync(uri);

            try
            {
                genderDictionary = await response.Content.ReadFromJsonAsync<List<DropDownGenderModel>>();
                return genderDictionary;
            }
            catch (Exception ex)
            {
                return new List<DropDownGenderModel>();
            }
        }

        static public void FillDataGridView(List<StudentDTO> studentDTOs, DataGridView dataGridView)
        {
            dataGridView.DataSource = studentDTOs;

            dataGridView.Columns["department_id"].Visible = false;
            dataGridView.Columns["graduate_id"].Visible = false;
        }

        static public async Task<bool> Login(string email, string password)
        {
            var user = new UserInfoDTO();
            user.Email = email;
            user.Password = password;

            var client = ClientAddress();
            try
            {
                //HttpResponseMessage response = await client.PostAsJsonAsync("api/token", user);
                //var apiResponse = await response.Content.ReadAsStringAsync()

                var response = await client.PostAsJsonAsync("api/token", user);
                //var apiResponse = response.Headers.GetValues("access-token").FirstOrDefault();
                var apiResponse = await response.Content.ReadAsAsync<string>();

                if (response.StatusCode != System.Net.HttpStatusCode.BadRequest)
                {
                    token = apiResponse;
                    Console.WriteLine(apiResponse);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch   (Exception ex)
            {
                return false;
            }
            
        }

        static public async Task<ApiResponse<LecturerDTO>> GetLecturerAsync(string email)
        {
            try
            {
                var client = ClientAddress();

                string url = "api/App/Lecturer/GetByEmail";


                string requestUrl = $"{url}?email={email}";
                HttpResponseMessage response = await client.GetAsync(requestUrl);
                var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<LecturerDTO>>();
                return apiResponse;
            }
            catch (Exception exp)
            {

                throw;
            }
        }

        static async public Task<ApiResponse<List<CourseDTO>>> GetCourseByLecturerId(int id)
        {

            var client = ClientAddress();
            string url = "api/App/Lecturer_Courses/GetCourseByLecturerId";

            string requestUrl = $"{url}?id={id}";
            HttpResponseMessage response = await client.GetAsync(requestUrl);

            var courses = await response.Content.ReadFromJsonAsync<ApiResponse<List<CourseDTO>>>();


            return courses;

        }

        static async public Task<ApiResponse<List<StudentGradeDTO>>> GetBySearchStudentGradeDTO(StudentFilter studentFilter)
        {
            var students = new ApiResponse<List<StudentGradeDTO>>();
            var client = ClientAddress();
            string url = "api/App/StudentCourseGrade/GetBySearch";

            if (studentFilter.Name == null)
                studentFilter.Name = "q";

            string queryString = GetQueryString(studentFilter);
            var uri = String.Concat(url, queryString);

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await client.GetAsync(uri);

            students = await response.Content.ReadFromJsonAsync<ApiResponse<List<StudentGradeDTO>>>();

            return students;
        }
        static async public Task<ApiResponse<EditStudentCourseGradeDTO>> EditStudentGradeAsync(int id, EditStudentCourseGradeDTO student)
        {
            try
            {
                var client = ClientAddress();

                string url = "api/App/StudentCourseGrade/Put";



                HttpResponseMessage response = await client.PutAsJsonAsync(url + id, student);

                var apiResponse = new ApiResponse<EditStudentCourseGradeDTO>();
                apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<EditStudentCourseGradeDTO>>();


                return apiResponse;
            }
            catch (Exception exp)
            {

                return null;
            }
        }


    }
}
