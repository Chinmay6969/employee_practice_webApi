using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IBALEmployee
    {
        public List<EmpDALModel> GetEmployee();

        public bool CreateEmployee(EmpDALModel createemp);

        public bool UpdateEmployee(EmpDALModel updateemp);


        public bool DeleteEmployee(int Id);
    }
}
