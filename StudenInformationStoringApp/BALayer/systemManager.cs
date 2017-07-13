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
        public void passStudentDetails(Student student)
        {

            dataAccessWorkplace objdataAccessWorkplace1 = new dataAccessWorkplace();
            objdataAccessWorkplace1.studentDetailsInToDb(student);
            objdataAccessWorkplace1.updateStudentsDetails(student);
            objdataAccessWorkplace1.deleteStudentsDetails(student);

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

        public void passSemesterDetailsUpdate(Semesters objSemesters)
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplaceUpdate = new dataAccessWorkplace();
            objdataAccessWorkplaceUpdate.updateSemesterDetails(objSemesters);
        }

        public void passSemesterDetailsDelete(Semesters objSemesters)
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplaceUpdate = new dataAccessWorkplace();
            objdataAccessWorkplaceUpdate.deleteSemesterDetails(objSemesters);
        }

        public void insertSubjects(Subjects objsystemManager)
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplace4 = new dataAccessWorkplace();
            objdataAccessWorkplace4.SubjectDataInToDb(objsystemManager);
        }

        private DataTable CreateItemTable()
        {
            DataTable dt = new DataTable();
            DataColumn clmSubjectID = new DataColumn("SubjectID", typeof(int));
            DataColumn clmSemesterID = new DataColumn("SemesterID", typeof(int));      
           
            dt.Columns.Add(clmSubjectID);
            dt.Columns.Add(clmSemesterID);
            return dt;
        }

        public bool insertSubSem(List<Subjects> lstSubjects)
        {
            //passing the values as object to the dataAccessLayer to store in b           
            DataTable dt = CreateItemTable();

            DataRow dr;
            foreach (var item in lstSubjects)
            {
                dr = dt.NewRow();
                dr["SubjectID"] = item.SubjectID;
                dr["SemesterID"] = item.ObjSemesters.SemesterID;               
                dt.Rows.Add(dr);
            }
            dataAccessWorkplace objdataAccessWorkplace5 = new dataAccessWorkplace();
            return objdataAccessWorkplace5.SubSemDataInToDb(dt);
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
                    objStudent.ObjDepartment = new Department();
                    objStudent.StudentID = (int)dr["StudentID"]; 
                    objStudent.universityID = dr["StudentCode"].ToString();
                    objStudent.FullName = dr["StdentName"].ToString();
                    objStudent.age = Convert.ToInt32(dr["StudentAge"].ToString());
                    objStudent.dateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                    objStudent.adress = dr["Address"].ToString();
                    objStudent.ObjDepartment.DepartmentID = Convert.ToInt32(dr["DepartmentID"].ToString());
                    objStudent.ObjDepartment.DepartmentName = dr["DepartmentName"].ToString();
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

        //create a list to store loded Subject data table from DAL
        public List<Subjects> GetSubjectData()
        {
            List<Subjects> lstSubjects = new List<Subjects>();
            Subjects objSubjects = null;
            dataAccessWorkplace objobjdataAccessWorkplace4 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace4.getSubjectData();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objSubjects = new Subjects();
                    objSubjects.SubjectID = (int)dr["SubjectID"];
                    objSubjects.SubjectCode = dr["SubjectCode"].ToString();
                    objSubjects.SubjectName = dr["SubjectName"].ToString();

                    lstSubjects.Add(objSubjects);
                }
            }
            return lstSubjects;
        }

    }
}
