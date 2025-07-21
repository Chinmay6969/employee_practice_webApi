using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employeepractice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IcountryBAL countBAL;

        public CountryController(IcountryBAL countryBAL)
        {
            countBAL = countryBAL;
        }

        [HttpGet]
        public IActionResult Getcountries()
        {
            List<countryDALmodel> countries = countBAL.Getcountries();
            throw new Exception("Barkha error");
            return Ok(countries);


        }

        [HttpGet]
        public IActionResult GetHealthCheck()
        {

            return Ok("App is running as expected !");


        }

    }
}
