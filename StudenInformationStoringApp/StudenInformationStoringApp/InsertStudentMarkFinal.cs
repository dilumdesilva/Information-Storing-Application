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
            systemManager objsystemManager = new systemManager();
           
            List<Student> lstStudent = new List<Student>();
            lstStudent = objsystemManager.GetStudentAllocationData();
        }

    }

    public class ViewModelStudentMarkAllocation
    {
        public int StudentID { get; set; }
        public string StudentCode { get; set; }
        public string StdentName { get; set; }

        public int SemesterID { get; set; }
        public string SemesterCode { get; set; }
        public int SemesterName { get; set; }

        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }

        public int SemSubConfigID { get; set; }
        public int StuSemConfigID { get; set; }
    }
}

