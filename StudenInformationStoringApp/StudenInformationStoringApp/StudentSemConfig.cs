using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Library;

namespace StudenInformationStoringApp
{
    public partial class StudentSemConfig : Form
    {
        bool isSelected = false;
        bool updateSelected = false;
        bool deleteSelected = false;

        int SelectedStuSemConfigID;
        int SelectedStudentID;
        int SelectedSemesterID;
        int SelectedSubjectID;
        string selectedSubjectName;
        string selectedSubCode;
        string selectedSemesterName;


        public StudentSemConfig()
        {
            InitializeComponent();
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

        public void setCmbSemester()
        {
            systemManager objsystemManager = new systemManager();
            cmbSemster.DataSource = objsystemManager.GetSemeDatatoStuSemAllocation();
            cmbSemster.ValueMember = "SemesterID"; 
            cmbSemster.DisplayMember = "SemesterCode";

            //because of this department combo's display inedex will shown as a blank index
            cmbSemster.SelectedIndex = -1;
        }

        public void SendDataToBAL()
        {
            Student objStudent = new Student();
            objStudent.ObjSemesters = new Semesters();

            //objStudent.ObjSemesters.SemSubConfigID = Convert.ToInt32(cmbSemster.SelectedValue);
            objStudent.ObjSemesters.SemesterCode = cmbSemster.Text;
            objStudent.ObjSemesters.SemesterID = Convert.ToInt32(cmbSemster.SelectedValue);
            objStudent.StudentID = Convert.ToInt32(cmbStudentID.SelectedValue);
            objStudent.universityID = cmbStudentID.Text;

            systemManager objsystemManager = new systemManager();
            objsystemManager.sendStuSemConfig(objStudent);

            MessageBox.Show("Student configuration data has been recorded successfully");

        }



        private void StudentSemConfig_Load(object sender, EventArgs e)
        {
            try
            {
                setDataSourceToGrid();
                setCmbStudent();
                setCmbSemester();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbStudentID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var xxx = (List<Student>)cmbStudentID.DataSource;

                //linq query
                //var xxxxx = from t in xxx
                //            where t.StudentID == (int)cmbStudentID.SelectedValue
                //            select t.ObjDepartment.DepartmentName;

                //var xxxxxx = (from t in xxx
                //             where t.StudentID == (int)cmbStudentID.SelectedValue
                //             select t.ObjDepartment.DepartmentName).ToList(); 

                //lamda expression
                txtDepartment.Text = xxx.Find(g => g.StudentID == (int)cmbStudentID.SelectedValue).ObjDepartment.DepartmentName;

                //you can do it without declaring a varible 
                txtStudentName.Text = ((List<Student>)cmbStudentID.DataSource).Find(g => g.StudentID == (int)cmbStudentID.SelectedValue).FullName.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnUpdateSysConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SendDataToBAL();
                setDataSourceToGrid();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void setDataSourceToGrid()
        {
            dgvStuSubSemConfig.AutoGenerateColumns = false;
            dgvStuSubSemConfig.DataSource = null;
            systemManager objsystemManager = new systemManager();
            List<Student> lststuSemAllocationData = new List<Student>();
            lststuSemAllocationData = objsystemManager.getStuSemDataToGrid();
            stuSemAllocationData objstuSemAllocationData;
            List<stuSemAllocationData> lstStuSem = new List<stuSemAllocationData>();

            foreach (var item in lststuSemAllocationData)
            {
                objstuSemAllocationData = new stuSemAllocationData();
                objstuSemAllocationData.StuSemConfigID = item.StuSemConfigID;
                objstuSemAllocationData.StudentID = item.StudentID;
                objstuSemAllocationData.universityID = item.universityID;
                objstuSemAllocationData.FullName = item.FullName;
                objstuSemAllocationData.SemesterID = item.ObjSemesters.SemesterID;
                objstuSemAllocationData.SemesterCode = item.ObjSemesters.SemesterCode;
                objstuSemAllocationData.SemesterName = item.ObjSemesters.SemesterName;
                objstuSemAllocationData.SubjectID = item.ObjSubjects.SubjectID;
                objstuSemAllocationData.SubjectCode = item.ObjSubjects.SubjectCode;
                objstuSemAllocationData.SubjectName = item.ObjSubjects.SubjectName;

                lstStuSem.Add(objstuSemAllocationData);
            }


            dgvStuSubSemConfig.DataSource = lstStuSem;

        }

        private void dgvStuSubSemConfig_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                cmbStudentID.Text = dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmuniversityID.Name].Value.ToString();
                txtStudentName.Text =dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmFullName.Name].Value.ToString();
                txtDepartment.Text = "Select student ID";
                cmbSemster.Text = dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmSemesterCode.Name].Value.ToString();
                SelectedStudentID = Convert.ToInt32(dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmStudentID.Name].Value);
                SelectedSemesterID = Convert.ToInt32(dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmSemesterID.Name].Value);
                SelectedStuSemConfigID = Convert.ToInt32(dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmStuSemConfigID.Name].Value);
                SelectedSubjectID = Convert.ToInt32(dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmSubjectID.Name].Value);
                selectedSemesterName = dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmSemesterName.Name].Value.ToString();
                selectedSubjectName = dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmSubjectName.Name].Value.ToString();
                selectedSubCode = dgvStuSubSemConfig.Rows[e.RowIndex].Cells[clmSubjectCode.Name].Value.ToString();

                cmbStudentID.SelectedValue = SelectedStudentID;
                cmbSemster.SelectedValue = SelectedSemesterID;

                btnInsert.Enabled = false;
                isSelected = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void selectedStuRowDetails()
        {
            if (isSelected == true)
            {
                Student objstuSemAllocationData = new Student();
                objstuSemAllocationData.ObjSemesters = new Semesters();
                objstuSemAllocationData.ObjSubjects = new Subjects();
                objstuSemAllocationData.StudentID = SelectedStudentID;
                objstuSemAllocationData.universityID = cmbStudentID.Text;
                objstuSemAllocationData.FullName = txtStudentName.Text;
                objstuSemAllocationData.ObjSemesters.SemesterID = SelectedSemesterID;
                objstuSemAllocationData.ObjSemesters.SemesterCode = cmbSemster.Text;
                objstuSemAllocationData.ObjSemesters.SemesterName = selectedSemesterName;
                objstuSemAllocationData.ObjSubjects.SubjectID = SelectedSubjectID;
                objstuSemAllocationData.ObjSubjects.SubjectCode = selectedSubCode;
                objstuSemAllocationData.StuSemConfigID = SelectedStuSemConfigID;

                systemManager objsystemManagerUpdateSem = new systemManager();

                if (updateSelected == true)
                {
                    objsystemManagerUpdateSem.updateStuSemConfig(objstuSemAllocationData);
                }
                if (deleteSelected == true)
                {
                    objsystemManagerUpdateSem.DeleteStuSemConfig(objstuSemAllocationData);
                }


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {

                updateSelected = true;
                if (btnInsert.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtStudentName.Text + "\nhas been updated successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deleteSelected = true;
                if (btnInsert.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtStudentName.Text + "\nhas been updated successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class stuSemAllocationData
    {
        public int StuSemConfigID { get; set; }

        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string universityID { get; set; }

        public int SemesterID { get; set; }
        public string SemesterCode { get; set; }
        public string SemesterName { get; set; }

        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }

    }
}
