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
    public partial class frmInsertStudentMarks : Form
    {
        public frmInsertStudentMarks()
        {
            InitializeComponent();
        }

        private void frmInsertStudentMarks_Load(object sender, EventArgs e)
        {
            try
            {
                setCmbDepartment();
                setCmbStudent();
                setcmbSemester();
                setcmbSubject();


    }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //method which loads the departments to the combobox.
        public void setCmbDepartment()
        {
            systemManager objsystemManager = new systemManager();
            cmbDepartment.DataSource = objsystemManager.LoadDepartmentToGrid();
            cmbDepartment.ValueMember = "DepartmentID";
            cmbDepartment.DisplayMember = "DepartmentName";

            //because of this department combo's display inedex will shown as a blank index
            cmbDepartment.SelectedIndex = -1;
        }

        //method which loads the semesters and name into the combobox.
        public void setcmbSemester()
        {
            systemManager objsystemManager = new systemManager();
            cmbSemester.DataSource = objsystemManager.GetSemestersData();
            cmbSemester.ValueMember = "SemesterID";
            cmbSemester.DisplayMember = "SemesterCode";


            //because of this department combo's display inedex will shown as a blank index
            cmbSemester.SelectedIndex = -1;
        }

        //method which loads the semesters and name into the combobox.
        public void setcmbSubject()
        {
            systemManager objsystemManager = new systemManager();
            cmbSubject.DataSource = objsystemManager.GetSubjectData();
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubjectName";
            
            //because of this department combo's display inedex will shown as a blank index
            cmbSubject.SelectedIndex = -1;
        }

        //method which loads the studentID and name into the combobox.
        public void setCmbStudent()
        {
            systemManager objsystemManager = new systemManager();
            cmbStudentID.DataSource = objsystemManager.GetStudentBasicData();
            cmbStudentID.ValueMember = "StudentID"; 
            cmbStudentID.DisplayMember = "universityID";
           

            //because of this department combo's display inedex will shown as a blank index
            cmbStudentID.SelectedIndex = -1;
        }

        private void cmbStudentID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                List<Student> lstStudent = new List<Student>();
                lstStudent = (List<Student>)cmbStudentID.DataSource;
                if(lstStudent != null && lstStudent.Count > 0)
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

                throw ex ;
            }
        }

        f
        
       
    }
}
