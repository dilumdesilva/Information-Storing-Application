using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALayer
{
    public class connectionBuider
    {
        public static SqlConnection buildConection()
        {
            try
            {
                SqlConnection conPath = new SqlConnection("Data Source=nghq-it-023;Initial Catalog=University_Information;User ID=sa");
                if (conPath.State == ConnectionState.Closed)
                {
                    
                    conPath.Open();
                }
                else
                {
                    conPath.Close();
                }

                return conPath;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
         

    }
}
