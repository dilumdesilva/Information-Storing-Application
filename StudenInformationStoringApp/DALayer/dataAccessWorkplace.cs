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
                cmd.Parameters.AddWithValue("@StuName", student.firstName);
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

        //method which inserts semester datails to the db.
        public void SemesterDataInToDb(Semesters objSemesters)
        {
            try
            {
                query = "StoreSemesterDetails";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@SemCode", objSemesters.SemesterCode);
                cmd.Parameters.AddWithValue("@SemName", objSemesters.SemesterName);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //method which inserts subject datails to the db.
        public void SubjectDataInToDb(Subjects objSubjects)
        {
            try
            {
                query = "StoreSubjectDetails";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@SubjectCode", objSubjects.SubjectCode);
                cmd.Parameters.AddWithValue("@SubjectName", objSubjects.SubjectName);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool SubSemDataInToDb(DataTable dt)
        {
            bool res = false;
            try
            {
                query = "spSaveSubjects";
                cmd = commandTypeSelector(1);

                cmd.CommandText = query;
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@dtSubjects";
                parameter.SqlDbType = System.Data.SqlDbType.Structured;
                parameter.Value = dt;
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException se)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return res;
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

        //Method which load semester data from db to a data table
        public DataTable getSemestertData()
        {
            query = "GetSemesterData";
            cmd = commandTypeSelector(1);
            cmd.CommandText = query;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;

        }

        //Method which load semester data from db to a data table
        public DataTable getSubjectData()
        {
            query = "GetSubjectData";
            cmd = commandTypeSelector(1);
            cmd.CommandText = query;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;

        }

        public bool SaveMarks(Student student)
        {
            bool res = false;
            cmd.Parameters.AddWithValue("", student.ObjDepartment.DepartmentID);
            res = true;

            return res;
        }

        //method which perform semester updates to db
        public void updateSemesterDetails(Semesters objSemesters)
        {
            try
            {
                query = "UpdateSemDetails";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@SemesterID", objSemesters.SemesterID);
                cmd.Parameters.AddWithValue("@SemesterName", objSemesters.SemesterName);
                cmd.Parameters.AddWithValue("@SemesterCode", objSemesters.SemesterCode);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //method which perform semester delete from db
        public void deleteSemesterDetails(Semesters objSemesters)
        {
            try
            {
                query = "DeleteSemester";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@SemesterID", objSemesters.SemesterID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //method which perform students updates to db
        public void updateStudentsDetails(Student student)
        {
            try
            {
                query = "UpdateStudent";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@StuID", student.StudentID);
                cmd.Parameters.AddWithValue("@StuCode", student.universityID);
                cmd.Parameters.AddWithValue("@StuName",student.firstName);
                cmd.Parameters.AddWithValue("@StuAge", student.age );
                cmd.Parameters.AddWithValue("@Address", student.adress);
                cmd.Parameters.AddWithValue("@DateIfBirth", student.dateOfBirth);
                cmd.Parameters.AddWithValue("@DepartmentID", student.ObjDepartment.DepartmentID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //method which perform students delete from db
        public void deleteStudentsDetails(Student student)
        {
            try
            {
                query = "DeleteStudent";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //method which perform students updates to db
        public void updateDepartments(Department objDepartment)
        {
            try
            {
                query = "UpdateDepartment";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@DeptID", objDepartment.DepartmentID);
                cmd.Parameters.AddWithValue("@DeptName", objDepartment.DepartmentName);
                cmd.Parameters.AddWithValue("@DeptCode", objDepartment.DepartmenCode);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //method which perform students delete from db
        public void deleteDepartments(Department objDepartment)
        {
            try
            {
                query = "DeleteDepartment";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@DeptID", objDepartment.DepartmentID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //method which perform students updates to db
        public void updateSubjects(Subjects objSubjects)
        {
            try
            {
                query = "UpdateSubject";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@subID", objSubjects.SubjectID);
                cmd.Parameters.AddWithValue("@subName", objSubjects.SubjectName);
                cmd.Parameters.AddWithValue("@subCode", objSubjects.SubjectCode);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //method which perform students delete from db
        public void deleteSubjects(Subjects objSubjects)
        {
            try
            {
                query = "DeleteSubject";
                cmd = commandTypeSelector(1);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@subID", objSubjects.SubjectID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
