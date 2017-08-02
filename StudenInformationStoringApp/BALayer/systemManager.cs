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
        public void InsertStudentDetails( Student student)
        {

            dataAccessWorkplace objdataAccessWorkplace1 = new dataAccessWorkplace();
            objdataAccessWorkplace1.studentDetailsInToDb(student);

        }

        public void UpdateStudentDetails(Student student)
        {

            dataAccessWorkplace objdataAccessWorkplace1 = new dataAccessWorkplace();
            objdataAccessWorkplace1.updateStudentsDetails(student);
        }

        public void DeleteStudentDetails(Student student)
        {

            dataAccessWorkplace objdataAccessWorkplace1 = new dataAccessWorkplace();
            objdataAccessWorkplace1.deleteStudentsDetails(student);

        }

        public void insertDepartments(Department objDepartment )
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplace2 = new dataAccessWorkplace();
            objdataAccessWorkplace2.departmentsInToDb(objDepartment);
        }

        public void updateDepartments(Department objDepartment)
        {
            dataAccessWorkplace objdataAccessWorkplace = new dataAccessWorkplace();
            objdataAccessWorkplace.updateDepartments(objDepartment);
        }

        public void deleteDepartments(Department objDepartment)
        {
            dataAccessWorkplace objdataAccessWorkplace = new dataAccessWorkplace();
            objdataAccessWorkplace.deleteDepartments(objDepartment);
        }

        public void insertSemesters(Semesters objSemesters)
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplace3 = new dataAccessWorkplace();
            objdataAccessWorkplace3.SemesterDataInToDb(objSemesters);
        }

        public void sendStuSemConfig(Student objStudent)
        {
            dataAccessWorkplace objdataAccessWorkplace = new dataAccessWorkplace();
            objdataAccessWorkplace.stuSemConfigToDB(objStudent);
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

        public void insertSubjects(Subjects objSubjects)
        {
            //passing the values as object to the dataAccessLayer to store in b
            dataAccessWorkplace objdataAccessWorkplace4 = new dataAccessWorkplace();
            objdataAccessWorkplace4.SubjectDataInToDb(objSubjects);
        }

        public void updateSubjects(Subjects objSubjects)
        {
            dataAccessWorkplace objdataAccessWorkplace = new dataAccessWorkplace();
            objdataAccessWorkplace.updateSubjects(objSubjects);
        }

        public void deleteSubjects(Subjects objSubjects)
        {
            dataAccessWorkplace objdataAccessWorkplace = new dataAccessWorkplace();
            objdataAccessWorkplace.deleteSubjects(objSubjects);
        }

        public void stuMarksInsert( )
        {

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

        //public bool insertSubSem(List<Subjects> lstSubjects)
        //{
        //    List<Subjects> saveList = (List<Subjects>)lstSubjects;

        //    if (saveList.Count != 0)
        //    {
        //        dataAccessWorkplace objdataAccessWorkplace5 = new dataAccessWorkplace();

        //        Subjects objSubjects = null;
        //        List<Subjects> lstSubjects2 = new List<Subjects>();
        //        foreach (var item in saveList)
        //        {
        //            objSubjects = new Subjects();
        //            objSubjects.ObjSemesters = new Semesters();
        //            objSubjects.SubjectID = item.SubjectID;
        //            objSubjects.ObjSemesters.SemesterID = item.SemesterID;
        //            lstSubjects2.Add(objSubjects);
        //        }
        //        bool res = objdataAccessWorkplace5.SubSemDataInToDb(lstSubjects2);
        //    }
           
        //}


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

        public bool SaveMarks(Student student)
        {
            dataAccessWorkplace objobjdataAccessWorkplace3 = new dataAccessWorkplace();
            return objobjdataAccessWorkplace3.SaveMarks(student);
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

        public List<Semesters> GetSemeSubConfigData()
         {
            List<Semesters> lstSemSubConfigData = new List<Semesters>();
            Semesters objSemester = null;
            dataAccessWorkplace objobjdataAccessWorkplace3 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace3.getSemSubConfig();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objSemester = new Semesters();
                    objSemester.objSubjects = new Subjects();
                    objSemester.SemSubConfigID = (int)dr["SemSubConfigID"];
                    objSemester.SemesterID = (int)dr["SemesterID"];
                    objSemester.SemesterCode = dr["SemesterCode"].ToString();
                    objSemester.SemesterName = dr["SemesterName"].ToString();
                    objSemester.objSubjects.SubjectID = Convert.ToInt32(dr["SubjectID"].ToString());
                    objSemester.objSubjects.SubjectCode = dr["SubjectCode"].ToString();
                    //objSemester.objSubjects.SubjectName = dr["SubjectName"].ToString();
                    lstSemSubConfigData.Add(objSemester);
                }
            }
            return lstSemSubConfigData;
        }

        public List<Student> GetStudentAllocationData()
        {
            List<Student> lstSemSubConfigData = new List<Student>();
            Student objStudent = null;
            dataAccessWorkplace objobjdataAccessWorkplace3 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace3.getSemSubConfig();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objStudent = new Student();
                    objStudent.ObjSubjects = new Subjects();
                    objStudent.ObjSemesters = new Semesters();
                    //string xxx = "sbsb";
                    //var i = Convert.ToInt16(xxx);

                    objStudent.StudentID = Convert.ToInt32(dr["StudentID"].ToString());
                    objStudent.FullName = dr["StdentName"].ToString();
                    objStudent.universityID = dr["StudentCode"].ToString();

                    objStudent.ObjSemesters.SemesterID = Convert.ToInt32(dr["SemesterID"].ToString());
                    objStudent.ObjSemesters.SemesterCode = dr["SemesterCode"].ToString();
                    objStudent.ObjSemesters.SemesterName = dr["SemesterName"].ToString();

                    objStudent.ObjSubjects.SubjectID = Convert.ToInt32(dr["SubjectID"].ToString());
                    objStudent.ObjSubjects.SubjectCode = dr["SubjectCode"].ToString();
                    objStudent.ObjSubjects.SubjectName = dr["SubjectName"].ToString();

                    objStudent.StuSemConfigID = Convert.ToInt32(dr["StuSemConfigID"].ToString());
                    objStudent.ObjSemesters.SemSubConfigID = Convert.ToInt32(dr["SemSubConfigID"].ToString());

                    lstSemSubConfigData.Add(objStudent);
                }
            }
            return lstSemSubConfigData;
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

        public DataTable ViewSemestersData()
        {
            List<Semesters> lstSemesters = new List<Semesters>();
            Semesters objSemesters = null;
            dataAccessWorkplace objobjdataAccessWorkplace4 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace4.getSemestertData();        
            return dt; ;
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

        public List<Semesters> GetSemeDatatoStuSemAllocation()
        {
            List<Semesters> lstSemesters = new List<Semesters>();
            Semesters objSemesters = null;
            dataAccessWorkplace objobjdataAccessWorkplace3 = new dataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objobjdataAccessWorkplace3.GetSemDataStuSemAllocation();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objSemesters = new Semesters();
                    //objSemesters.ObjDepartment = new Department();
                    objSemesters.SemesterID = (int)dr["SemesterID"];
                    objSemesters.SemesterName = dr["SemesterName"].ToString();
                    objSemesters.SemesterCode = dr["SemesterCode"].ToString();

                    lstSemesters.Add(objSemesters);
                }
            }
            return lstSemesters;
        }

    }
}
