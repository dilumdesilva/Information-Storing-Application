using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Library;
using DALayer;
using System.Data;

namespace BALayer
{
    public class systemManager
    {
        public void insertStudentDetails(Student student)
        {

            dataAccessWorkplace objdataAccessWorkplace1 = new dataAccessWorkplace();
            objdataAccessWorkplace1.studentDetailsInToDb(student);

        }

        public void insertDepartments(Department objDepartment )
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplace2 = new dataAccessWorkplace();
            objdataAccessWorkplace2.departmentsInToDb(objDepartment);
        }

        //create a list to store loded data table from DAL
        public List<Department> LoadDepartmentToGrid()
        {
            List<Department> lstDepartment = new List<Department>();
            Department objDepartment = null;
            dataAccessWorkplace objobjdataAccessWorkplace3 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace3.getDepartmentToGrid();
            if(dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {                    
                    objDepartment = new Department();
                    objDepartment.DepartmentID = (int)dr["DepartmentID"];
                    objDepartment.DepartmentName = dr["DepartmentName"].ToString();
                    objDepartment.DepartmenCode = dr["DepartmentCode"].ToString();
                    lstDepartment.Add(objDepartment);
                }
            }
            return lstDepartment;
        }
    }
}
