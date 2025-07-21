using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BAL
{
    public class EmployeeBAL: IBALEmployee
    {
        private readonly IEmployeeDAL empDAL;

        public EmployeeBAL(IEmployeeDAL employeeDAL)
        {
            empDAL = employeeDAL;
        }
        public List<EmpDALModel> GetEmployee()
        {
            List<EmpDALModel> Empdetails = empDAL.GetEmployee();
            return Empdetails;

        }
        public bool CreateEmployee(EmpDALModel createemp)
        {
            bool insertemployee = empDAL.CreateEmployee(createemp);

            return insertemployee;

        }
        public bool UpdateEmployee(EmpDALModel updateemp)
        {
            bool Updateempdetails = empDAL.UpdateEmployee(updateemp);
            return Updateempdetails;
        }
        public bool DeleteEmployee(int Id)
        {
            bool deleteemp = empDAL.DeleteEmployee(Id);
            return deleteemp;

        }

    }
}
