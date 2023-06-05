using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentSystemClient.DTO
{
    public class EditStudentCourseGradeDTO
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public int But { get; set; }
    }
}
