using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BAL;
using DAL.Models;


namespace Employeepractice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IstudentBAL studentBAL;

        public StudentController(IstudentBAL StudentB)
        {
            studentBAL = StudentB;
        }


        [HttpGet]
        public IActionResult GetStudentdetails()
        {

           List<StudentModel> studentdetails = studentBAL.GetStudentdetails();

            return Ok(studentdetails); 


        }

        [HttpPost]
        public IActionResult CreateStudentdetails(StudentModel createstudent)
        {
            bool createstudents = studentBAL.CreateStudentdetails(createstudent);
            return Ok(createstudents);
           


        }
        [HttpPut]
        public IActionResult UpdateStudentdetails(StudentModel Updatestudentdetails)
        {

            bool studentupdate = studentBAL.UpdateStudentdetails(Updatestudentdetails);
            return Ok(studentupdate);


        }

        [HttpDelete]
        public IActionResult DeleteStudentdetails(int Id)
        {
            bool deletestudent = studentBAL.DeleteStudentdetails(Id);
            return Ok(deletestudent);
           


        }
    }
}
