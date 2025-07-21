using DAL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL: IEmployeeDAL
    {

        public bool IsDbNull(object inputobj)
        {
            if (inputobj == DBNull.Value)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<EmpDALModel> GetEmployee()
        {
           DataSet ds = new DataSet();
           ds = Commonmethod.storeprocExecute("EmployeeDetails");

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            List<EmpDALModel> Empdetails = new List<EmpDALModel>();

            foreach(DataRow row in dt.Rows)
            {
                EmpDALModel emp = new EmpDALModel();

                emp.ID = Convert.ToInt32(row["ID"]);
                emp.Name = row["Name"].ToString();
                emp.Age = Convert.ToInt32(row["Age"]);
                emp.salary = Convert.ToInt32(row["Salary"]);
                emp.Countryid = IsDbNull(row["Country_id"]) ? 0 : Convert.ToInt32(row["Country_id"]);

                emp.CountryName = IsDbNull(row["CountryName"]) ? string.Empty : row["CountryName"].ToString();

                Empdetails.Add(emp);
            }

            return Empdetails;

        }

        public bool CreateEmployee(EmpDALModel createemp)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Name", createemp.Name),
                new SqlParameter("@Age",createemp.Age),
                new SqlParameter("@Salary",createemp.salary),
                new SqlParameter ("@Country_id",createemp.Countryid)



            };

            DataSet ds = new DataSet();
            ds = Commonmethod.storeprocExecute("CreateEmployee",sqlParameters);

            if (ds.Tables.Count>0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if ((int)dr["returnvalue"]==1)
                {
                    return true;
                }
                

            }
            return false;
        }
        public bool UpdateEmployee(EmpDALModel updateemp)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id",updateemp.ID),
                new SqlParameter("@Name", updateemp.Name),
                new SqlParameter("@Age",updateemp.Age),
                new SqlParameter("@Salary",updateemp.salary),
                new SqlParameter ("@countryId",updateemp.Countryid)

            };

            DataSet ds = new DataSet();
            ds = Commonmethod.storeprocExecute("UpdateEmployee",sqlParameters);

            if(ds.Tables.Count>0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if ((int)dr["returnvalue"] ==1)
                {
                    return true;

                }

            }
            return false;


        }
        public bool DeleteEmployee(int Id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id",Id)
            };

            DataSet ds = new DataSet();
            ds = Commonmethod.storeprocExecute("DeleteEmployee",sqlParameters);

            if(ds.Tables.Count>0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if ((int)dr["returnvalue"]==1)
                {  
                    return true;
                }
            }
            return false;

        }

    }
}
