using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Models;
using Microsoft.Data.SqlClient;


namespace DAL
{
    public class StudentDAL : IStudentDAL
    {
        public bool IsDbNull(object inputobj)
        {
            if(inputobj == DBNull.Value) 
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public List<StudentModel> GetStudentdetails()
        {
            DataSet ds = new DataSet();

            ds = Commonmethod.storeprocExecute("GetStudents");

           DataTable dt = ds.Tables[0];

           List<StudentModel> Student = new List<StudentModel>();

            foreach(DataRow row in dt.Rows)
            {
                StudentModel stdmodel = new StudentModel();

                stdmodel.Id = Convert.ToInt32(row["ID"]);
                stdmodel.Name = row["Name"].ToString();
                stdmodel.Department = row["Department"].ToString();
                stdmodel.Class = row["Class"].ToString();
                stdmodel.Countryid = IsDbNull(row["Country_id"]) ? 0 : Convert.ToInt32(row["Country_id"]);

                stdmodel.CountryName = IsDbNull( row["CountryName"]) ? string.Empty : row["CountryName"].ToString() ;


                //stdmodel.Countryid = Convert.ToInt32(row["Country_id"]);
                //stdmodel.CountryName = row["CountryName"].ToString();

                Student.Add(stdmodel);


            }

            return Student;



        }
        //Country_id

        public bool CreateStudentdetails(StudentModel createstudent)
        {
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter ("@Name", createstudent.Name),
                new SqlParameter ("@Department", createstudent.Department),
                new SqlParameter ("@Class",createstudent.Class),
                new SqlParameter ("@Country_id",createstudent.Countryid)

            };

            DataSet ds = new DataSet();

            ds = Commonmethod.storeprocExecute("Createstudent", sqlparam);

            if(ds.Tables.Count>0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if ((int)dr["returvalue"] ==1)
                {
                    return true;

                }

            }
            return false;
        }

        public bool UpdateStudentdetails(StudentModel Updatestudentdetails)
        {
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter ("@Id", Updatestudentdetails.Id),
                new SqlParameter ("@Name", Updatestudentdetails.Name),
                new SqlParameter ("@Department", Updatestudentdetails.Department),
                new SqlParameter ("@Class",Updatestudentdetails.Class),
                new SqlParameter ("@countryId",Updatestudentdetails.Countryid)

            };

            DataSet ds = new DataSet();

            ds = Commonmethod.storeprocExecute("UpdateStudent", sqlparam);

            if (ds.Tables.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if ((int)dr["returnvalue"] == 1)
                {
                    return true;

                }

            }
            return false;
        }

        public bool DeleteStudentdetails(int Id)
        {
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter ("@Id", Id),
                

            };

            DataSet ds = new DataSet();

            ds = Commonmethod.storeprocExecute("DeleteStudent", sqlparam);

            if (ds.Tables.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if ((int)dr["returvalue"] == 1)
                {
                    return true;

                }

            }
            return false;
        }


    }
}
