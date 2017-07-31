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

        private void InsertStudentMarkFinal_Load(object sender, EventArgs e)
        {
            try
            {
                GetStudentAllocatedData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<Student> GetStudentAllocatedData()
        {
            systemManager objsystemManager = new systemManager();

            List<Student> lstStudentData = new List<Student>();
            lstStudentData = objsystemManager.GetStudentAllocationData();

            return lstStudentData;
        }

        public List<ViewModelStudentMarkAllocation> GetStuData()
        {
            
            List<Student> StuAllocatedData = new List<Student>();
            StuAllocatedData = this.GetStudentAllocatedData();

            List<ViewModelStudentMarkAllocation> lstStuData = new List<ViewModelStudentMarkAllocation>();
            ViewModelStudentMarkAllocation objViewModelStudentMarkAllocation = null;

            foreach (var item in StuAllocatedData)
            {
                objViewModelStudentMarkAllocation = new ViewModelStudentMarkAllocation();
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

    }

    public class ViewModelStudentMarkAllocation
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

