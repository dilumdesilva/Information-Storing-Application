using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Shared_Library;

namespace DALayer
{
    public class dataAccessWorkplace
    {
        private static string query;
        private static SqlConnection con = connectionBuider.buildConection();

        private SqlCommand cmd = new SqlCommand(query, con);

        private SqlDataAdapter adp = new SqlDataAdapter();


        private SqlCommand commandTypeSelector( int cmdType)
        {
            if(cmdType == 1)
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand = cmd;
            }
            return cmd;
        }

        //method which stores student details to the db.
        public void studentDetailsInToDb(Student student)
        {
            try
            {
                query = "storeStudentDetails";
                cmd= commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@StuCode", student.universityID);
                cmd.Parameters.AddWithValue("@StuName", student.firstName + " " + student.lastName);
                cmd.Parameters.AddWithValue("@StuAge", student.age);
                cmd.Parameters.AddWithValue("@Address", student.adress);
                cmd.Parameters.AddWithValue("@DateIfBirth", student.dateOfBirth);
                cmd.Parameters.AddWithValue("@DepartmentID", student.DepartmentID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                 
                throw ex;
            }
        }

        //method which stores department datails to the db.
        public void departmentsInToDb(Department objDepartment)
        {
            try
            {
                query = "storeDepartmentDetails";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@DeptCode", objDepartment.DepartmenCode);
                cmd.Parameters.AddWithValue("@DeptName", objDepartment.DepartmentName);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Method which load department data from db to a data table
        public DataTable getDepartmentToGrid()
        {
            query = "DepartmentDetailsForGrid";
            cmd = commandTypeSelector(1);
            cmd.CommandText = query;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;

        }

        //Method which load student data from db to a data table
        public DataTable getStudentData()
        {
            query = "GetStudentData";
            cmd = commandTypeSelector(1);
            cmd.CommandText = query;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;

        }

    }
}
