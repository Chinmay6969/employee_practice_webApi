using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class StudentBAL : IstudentBAL
    {
        private readonly IStudentDAL studentDAL;

        public StudentBAL(IStudentDAL student)
        {
            studentDAL = student;
        }

        public List<StudentModel> GetStudentdetails()
        {
            List<StudentModel> studentdetails = studentDAL.GetStudentdetails();


            //factory factory = new factory();

            //car car = new car();
            //car.wheel = 4;
            //car.engine = 1200;
            //factory.createVehicle(car);

            //Bike bike = new Bike();
            //factory.createVehicle(bike);

            //truck truck = new truck();
            //factory.createVehicle(truck);

            //autoo autoo = new autoo();

            //factory.createVehicle(autoo);


            return studentdetails;
        }

        public bool CreateStudentdetails(StudentModel createstudent)
        {
            bool createstd = studentDAL.CreateStudentdetails(createstudent);
            return createstd;

        }

        public bool UpdateStudentdetails(StudentModel Updatestudentdetails)
        {
            bool Updatestudent = studentDAL.UpdateStudentdetails(Updatestudentdetails);
            return Updatestudent;
        }
        public bool DeleteStudentdetails(int Id)
        {
            bool deletestddetails = studentDAL.DeleteStudentdetails(Id);
            return deletestddetails;
        }
    }
}
