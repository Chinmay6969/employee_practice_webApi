using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IStudentDAL
    {
        public List<StudentModel> GetStudentdetails();

        public bool CreateStudentdetails(StudentModel createstudent);

        public bool UpdateStudentdetails(StudentModel createstudent);

        public bool DeleteStudentdetails(int Id);



    }
}
