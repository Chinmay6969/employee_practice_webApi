using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace DAL
{
    public static class Commonmethod
    {
        private static string connectionstring = "Server=BARKHA;Database=EmployeePractice;Trusted_Connection=True;Encrypt=False;";
        public static DataSet storeprocExecute(string stroreprocedure, SqlParameter[]sqlparam = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using(SqlCommand command = new SqlCommand(stroreprocedure, connection)) 
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if(sqlparam!=null)
                    {
                        command.Parameters.AddRange(sqlparam);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        return ds;

                    }


                }
            }

        }

    }
}
