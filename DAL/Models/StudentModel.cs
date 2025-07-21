using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DAL.Models
{
    public class StudentModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string Class { get; set;}

        public int Countryid { get; set; }

        public string? CountryName { get; set;}

    }
}
