using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;

namespace Employeepractice.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IBALEmployee bALEmployee;

        public EmployeeController(IBALEmployee EmployeeBAL)
        {
            bALEmployee = EmployeeBAL;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            List<EmpDALModel> Empdetailsreturn = bALEmployee.GetEmployee();

            return Ok(Empdetailsreturn);

        }

        [HttpPost]
        public IActionResult CreateEmployee(EmpDALModel createemp)
        {
            bool insertemp = bALEmployee.CreateEmployee(createemp);
            return Ok(insertemp);
        }
        [HttpPut]
        public IActionResult UpdateEmployee(EmpDALModel updateemp)
        {
            bool updateemployee = bALEmployee.UpdateEmployee(updateemp);
            return Ok(updateemployee);


        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int Id)
        {
            bool deleteemp = bALEmployee.DeleteEmployee(Id);
            return Ok(deleteemp);
        }

    }
}
