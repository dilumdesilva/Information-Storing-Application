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
    class dataAccessWorkplace
    {
        private static string query;
        private static SqlConnection con = connectionBuider.buildConection();

        private SqlCommand cmd = new SqlCommand(query, con);

        private SqlDataAdapter adp = new SqlDataAdapter();


        private SqlCommand commandTypeSelector( int cmdType)
        {
            if(cmdType == 1)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand = cmd;
            }
            return cmd;
        }

        public void studentDetailsInToDb(student student)
        {
            try
            {
                query = "storeStudentDetails";
                commandTypeSelector(1);

               // @StuCode,@StuName,@StuAge,@Address,@DateIfBirth

                cmd.Parameters.AddWithValue("@StuCode", student.universityID);
                cmd.Parameters.AddWithValue("@StuName", student.firstName + " " + student.lastName);
                cmd.Parameters.AddWithValue("@StuAge", student.age);
                cmd.Parameters.AddWithValue("@Address", student.adress);
                cmd.Parameters.AddWithValue("@DateIfBirth", student.dateOfBirth);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                 
                throw ex;
            }
        }


    }
}
