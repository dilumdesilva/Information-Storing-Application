using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using Shared_Library;

namespace StudenInformationStoringApp
{
    public partial class InsertStudentMarkFinal : Form
    {
        public InsertStudentMarkFinal()
        {
            InitializeComponent();
        }

        public void SetcmbStudentID()
        {
            systemManager objsystemManager = new systemManager();
            cmbStudentID.DataSource = objsystemManager.GetStudentAllocationData();

            cmbStudentID.DisplayMember = "universityID"; 
            cmbStudentID.ValueMember = "StudentID";
        }

        public void setCmbSemester()
        {
            //systemManager objsystemManager = new systemManager();
            //cmbSemester.DataSource =  objsystemManager.GetStudentAllocationData();

            //List<Student> lstStudents = new List<Student>();
            //lstStudents = GetStudentAllocatedData();
            //cmbSemester.DataSource = (from lst in lstStudents                                     
            //                          select lst.ObjSemesters).Distinct().ToList();

            //cmbSemester.ValueMember = "SemesterID";
            //cmbSemester.DisplayMember = "SemesterCode";

            List<StudentMarkAllocationViewModel> lst = new List<StudentMarkAllocationViewModel>();
            lst = GetViewModelStudentMarkAllocationData();

            //var semList = (from n in lst
            //               select new { n.SemesterID, n.SemesterCode }).ToList();

            var semList = (from n in lst
                           select new { n.SemesterID ,n.SemesterCode }).Distinct().ToList();

            List<StudentMarkAllocationViewModel> sList = new List<StudentMarkAllocationViewModel>();
            //sList = semList.Distinct().ToList();

            cmbSemester.DataSource = semList;

            cmbSemester.ValueMember = "SemesterID";
            cmbSemester.DisplayMember = "SemesterCode";

        }

        private void InsertStudentMarkFinal_Load(object sender, EventArgs e)
        {
            try
            {
                //GetViewModelStudentMarkAllocationData();
                //GetStudentAllocatedData();
                //SetcmbStudentID();
                setCmbSemester();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private List<Student> GetStudentAllocatedData()
        {
            systemManager objsystemManager = new systemManager();

            List<Student> lstStudentData = new List<Student>();
            lstStudentData = objsystemManager.GetStudentAllocationData();

            return lstStudentData;
        }

        public List<StudentMarkAllocationViewModel> GetViewModelStudentMarkAllocationData()
        {
            
            List<Student> StuAllocatedData = new List<Student>();
            StuAllocatedData = GetStudentAllocatedData();

            List<StudentMarkAllocationViewModel> lstStuData = new List<StudentMarkAllocationViewModel>();
            StudentMarkAllocationViewModel objViewModelStudentMarkAllocation = null;

            foreach (var item in StuAllocatedData)
            {
                objViewModelStudentMarkAllocation = new StudentMarkAllocationViewModel();
                objViewModelStudentMarkAllocation.StudentID = item.StudentID;
                objViewModelStudentMarkAllocation.SubjectCode = item.universityID;
                objViewModelStudentMarkAllocation.StdentName = item.FullName;

                objViewModelStudentMarkAllocation.SemesterID = item.ObjSemesters.SemesterID;
                objViewModelStudentMarkAllocation.SemesterCode = item.ObjSemesters.SemesterCode;
                objViewModelStudentMarkAllocation.SemesterName = item.ObjSemesters.SemesterName;

                objViewModelStudentMarkAllocation.SubjectID = item.ObjSubjects.SubjectID;
                objViewModelStudentMarkAllocation.SubjectCode = item.ObjSubjects.SubjectCode;
                objViewModelStudentMarkAllocation.SubjectName = item.ObjSubjects.SubjectName;

                objViewModelStudentMarkAllocation.SemSubConfigID = item.ObjSemesters.SemSubConfigID;
                objViewModelStudentMarkAllocation.StuSemConfigID = item.StuSemConfigID;


                lstStuData.Add(objViewModelStudentMarkAllocation);
            }
            return lstStuData;
        }

        private void cmbStudentID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                List<Student> lstStudent = new List<Student>();
                lstStudent = (List<Student>)cmbStudentID.DataSource;
                if (lstStudent != null && lstStudent.Count > 0)
                {
                    string fullname = (from lst in lstStudent
                                       where lst.StudentID.Equals(Convert.ToInt32(cmbStudentID.SelectedValue))
                                       select lst.FullName).FirstOrDefault();

                    //var x = (from lst in lstStudent
                    //                where lst.StudentID.Equals(Convert.ToInt32(cmbStudentID.SelectedValue))
                    //                select lst);


                    txtStudentName.Text = fullname;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Student> lstStudents = new List<Student>();
            //lstStudents = this.GetStudentAllocatedData();

            //if (lstStudents != null)
            //{
            //    cmbSubject.DataSource = (from lst in lstStudents
            //                             where lst.ObjSemesters.SemesterID.Equals(Convert.ToInt32(cmbSemester.SelectedValue))
            //                             select lst.ObjSubjects).ToList();
            //    cmbSubject.DisplayMember = "SubjectName";
            //    cmbSubject.ValueMember = "SubjectID";

            //}
            //List<Semesters> lstSemesters = new List<Semesters>();
            //lstSemesters = (List<Semesters>)cmbSemester.DataSource;

            //if (lstSemesters != null && lstSemesters.Count > 0)
            //{
            //    //String sd
            //}
        }
    }

    public class StudentMarkAllocationViewModel
    {
        public int StudentID { get; set; }
        public string StudentCode { get; set; }
        public string StdentName { get; set; }

        public int SemesterID { get; set; }
        public string SemesterCode { get; set; }
        public string SemesterName { get; set; }

        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }

        public int SemSubConfigID { get; set; }
        public int StuSemConfigID { get; set; }
    }
}

