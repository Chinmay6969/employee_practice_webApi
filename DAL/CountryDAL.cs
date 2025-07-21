using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CountryDAL: IcountryDAL
    {
        public List<countryDALmodel> Getcountries()
        {
            DataSet ds = new DataSet();
            ds = Commonmethod.storeprocExecute("getCountries");


            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            List<countryDALmodel> createcountries = new List<countryDALmodel>();

            foreach(DataRow row in dt.Rows)
            {
                countryDALmodel countries = new countryDALmodel();

                countries.Id = Convert.ToInt32(row["Id"]);
                countries.CountryName = (row["CountryName"]).ToString();

                createcountries.Add(countries);

            }

            return createcountries;

            
        }



    }
}
