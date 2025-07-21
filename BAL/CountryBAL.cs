using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;


namespace BAL
{
    public class CountryBAL : IcountryBAL
    {
        private readonly IcountryDAL countDAL;

        public CountryBAL(IcountryDAL CountryDAL)
        {
            countDAL = CountryDAL;
        }

        public List<countryDALmodel> Getcountries()
        {
            List<countryDALmodel> countries = countDAL.Getcountries();
            
            return countries;

        }



    }
}
