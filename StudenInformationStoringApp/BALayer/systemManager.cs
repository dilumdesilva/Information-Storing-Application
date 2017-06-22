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

        public void insertSemesters(Semesters objSemesters)
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplace3 = new dataAccessWorkplace();
            objdataAccessWorkplace3.SemesterDataInToDb(objSemesters);
        }

        //create a list to store loded Department data table from DAL
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

        //create a list to store loded student basic data table from DAL
        public List<Student> GetStudentBasicData()
        {
            List<Student> lstStudent = new List<Student>();
            Student objStudent = null;
            dataAccessWorkplace objobjdataAccessWorkplace3 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace3.getStudentData();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objStudent = new Student();
                    objStudent.StudentID = (int)dr["StudentID"];
                    objStudent.universityID = dr["StudentCode"].ToString();
                    objStudent.FullName = dr["StdentName"].ToString();

                    lstStudent.Add(objStudent);
                }
            }
            return lstStudent;
        }

        //create a list to store loded semester data table from DAL
        public List<Semesters> GetSemestersData()
        {
            List<Semesters> lstSemesters = new List<Semesters>();
            Semesters objSemesters = null;
            dataAccessWorkplace objobjdataAccessWorkplace4 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace4.getSemestertData();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objSemesters = new Semesters();
                    objSemesters.SemesterID = (int)dr["SemesterID"];
                    objSemesters.SemesterCode = dr["SemesterCode"].ToString();
                    objSemesters.SemesterName = dr["SemesterName"].ToString();

                    lstSemesters.Add(objSemesters);
                }
            }
            return lstSemesters;
        }

    }
}
