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
            dgvStuMarks.AutoGenerateColumns = false;
            List<formDetails> lst = new List<formDetails>();
            dgvStuMarks.DataSource = lst;
        }

        private void frmInsertStudentMarks_Load(object sender, EventArgs e)
        {
            try
            {
                setCmbDepartment();
                setCmbStudent();
                setcmbSemester();
                setcmbSubject();
                //SetMyCustomFormat();


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

        public void fillToGrid()
        {
            //method to add data to the grid 
            List<formDetails> alreadyGridList = new List<formDetails>();
            if(dgvStuMarks.DataSource != null)
            {
                alreadyGridList = (List<formDetails>)dgvStuMarks.DataSource;
            }   
            
            formDetails objmarks = fillStuMarksObject();
            alreadyGridList.Add(objmarks);
            dgvStuMarks.DataSource = null;
            dgvStuMarks.DataSource = alreadyGridList;

        }

        public void sendStuMarks()
        {
            systemManager objsystemManager = new systemManager();
            bool res = objsystemManager.SaveMarks(this.FillStudent());
        }

        private formDetails fillStuMarksObject()
        {
            formDetails objformDetails = new formDetails();
            objformDetails.DepartmentID = (int)cmbDepartment.SelectedValue;
            objformDetails.DepartmentName = cmbDepartment.Text.ToString();
            objformDetails.StudentID = (int)cmbStudentID.SelectedValue;
            objformDetails.universityID = cmbStudentID.Text.ToString();
            objformDetails.stuFullName = txtStudentName.Text;
            objformDetails.Year = Convert.ToInt32(txtYear.Text);
            objformDetails.SemesterID = (int)cmbSemester.SelectedValue;
            objformDetails.SemesterCode = cmbSemester.Text.ToString();
            objformDetails.SubjectID = (int)cmbSubject.SelectedValue;
            objformDetails.SubjectCode = cmbSubject.Text.ToString();
            objformDetails.Mark = Convert.ToInt32(txtMarks.Text);
            objformDetails.Grade = cmbGrade.Text;

            return objformDetails;
        }
        private Student FillStudent()
        {
            Student objStudent = new Student();
            objStudent.ObjDepartment = new Department();
            objStudent.ObjSemesters = new Semesters();
            objStudent.ObjSubjects = new Subjects();
            objStudent.ObjDepartment.DepartmentID = (int)cmbDepartment.SelectedValue;
            objStudent.ObjDepartment.DepartmentName = cmbDepartment.Text.ToString();
            objStudent.StudentID = (int)cmbStudentID.SelectedValue;
            objStudent.FullName = txtStudentName.Text;
            objStudent.ObjSemesters.SemesterID  = (int)cmbSemester.SelectedValue; 
            objStudent.ObjSemesters.SemesterCode = cmbSemester.Text.ToString();
            objStudent.ObjSubjects.SubjectID  = (int)cmbSubject.SelectedValue;
            objStudent.ObjSubjects.SubjectCode = cmbSubject.Text.ToString();
            objStudent.ObjSemesters.year = Convert.ToInt32(txtYear.Text);
            objStudent.ObjSubjects.Mark = Convert.ToInt32(txtMarks.Text);
            objStudent.ObjSubjects.Grade = cmbGrade.Text;

            return objStudent;
        }




        private void btnInsertMarks_Click(object sender, EventArgs e)
        {
            try
            {
                duplicationValidate();
                fillToGrid();
               
            }
            catch (ApplicationException ax)
            {
                MessageBox.Show(ax.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        //the way of changin the format of default DateTimePicker
        //public void SetMyCustomFormat()
        //{
        //    // Set the Format type and the CustomFormat string.
        //    dateTimePicker1.Format = DateTimePickerFormat.Custom;
        //    dateTimePicker1.CustomFormat = "yyyy";
        //}

        private void duplicationValidate()
        {
            //int SubjectID = Convert.ToInt32(cmbSubject.SelectedValue);
            String SubjectName  = cmbSubject.Text.ToString();
            string SemesterName = cmbSemester.Text.ToString();
            string Year = txtYear.Text;

            if (SubjectName == string.Empty || SemesterName == string.Empty || Year == string.Empty)
            {
                throw new ApplicationException("Please enter values to the feilds");
            }

            foreach (DataGridViewRow dr in dgvStuMarks.Rows)
            {
                if (SemesterName == dr.Cells[4].Value.ToString() && SubjectName == dr.Cells[5].Value.ToString())
                {
                    throw new ApplicationException("Record duplication found!\nA student Cannot have multiple mark records for the same subject in " + SemesterName);
                }
            }
        }

        //private void setDataSourceToGrid()
        //{
        //    //here um setting the data source for this data grid 
        //    dgvStuMarks.DataSource = null;
        //    systemManager objsystemManager = new systemManager();
        //    dgvStuMarks.DataSource = objsystemManager


        //}
    }

    public class formDetails
    {
        //crated a class to fill stuMarks form details.
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public int StudentID { get; set; }
        public string stuFullName { get; set; }
        public string universityID { get; set; }
        public int Year { get; set; }
        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int SemesterID { get; set; }
        public string SemesterCode { get; set; }
        public int Mark { get; set; }
        public string Grade { get; set; }

    }
}
