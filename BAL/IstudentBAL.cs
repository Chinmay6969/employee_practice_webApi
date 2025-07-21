using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IstudentBAL
    {
        public List<StudentModel> GetStudentdetails();

        public bool CreateStudentdetails(StudentModel createstudent);

        public bool UpdateStudentdetails(StudentModel createstudent);

        public bool DeleteStudentdetails(int Id);

    }
}
