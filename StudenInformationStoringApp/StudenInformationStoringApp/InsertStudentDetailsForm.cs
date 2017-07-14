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
using BALayer;

namespace StudenInformationStoringApp
{
    public partial class frmInsertStudentDetails : Form
    {
        bool isSelected = false;

        int SelectedStudentID;
        int SelectedDeptID;

        bool updateSelected = false;
        bool deleteSelected = false;

        public frmInsertStudentDetails()
        {
            InitializeComponent();

            dgvStudentDetails.AutoGenerateColumns = false;
            List<Student> lst = new List<Student>();
            dgvStudentDetails.DataSource = lst;

        }

        //to get user inputs
        public void getData()
        {
            //creating a object from student class
            Student objStudent = new Student();

            objStudent.firstName = txtFirstName.Text;
            //objStudent.lastName = txtLastName.Text;
            objStudent.universityID = txtUniversityID.Text;
            objStudent.age = Convert.ToInt32(txtAge.Text);
            objStudent.dateOfBirth = Convert.ToDateTime(dtpBirthDate.Value);
            objStudent.adress = txtAdress.Text;
            objStudent.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);

            systemManager objsystemManager = new systemManager();
            objsystemManager.InsertStudentDetails(objStudent);


        }

        private void btnStudentDetailsInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    if (DtlduplicateValidation())
                    {
                        //fillToGrid();
                        getData();
                        setDataSourceToGrid();
                        MessageBox.Show(txtFirstName.Text + " has been recorded successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new ApplicationException("Record duplication found!\nCannot proceed with same records");
                    }
                }
                else
                {
                    MessageBox.Show("Empty records has found\nPlease fill the feilds before proceed...", "Empty records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (ApplicationException ax)
            {
                MessageBox.Show(ax.Message);
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

        private void frmInsertStudentDetails_Load(object sender, EventArgs e)
        {
            try
            {
                setDataSourceToGrid();
                setCmbDepartment();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //public void fillToGrid()
        //{
        //    //method to add data to the grid 
        //    List<StudentDetails> alreadyGridList = new List<StudentDetails>();
        //    if (dgvStudentDetails.DataSource != null)
        //    {
        //        alreadyGridList = (List<StudentDetails>)dgvStudentDetails.DataSource;
        //    }

        //    StudentDetails objStudent = fillStudentDetailsObject();
        //    alreadyGridList.Add(objStudent);
        //    dgvStudentDetails.DataSource = null;
        //    dgvStudentDetails.DataSource = alreadyGridList;
        //}
        private Student fillStudentDetailsObject()
        {
            Student objStudent = new Student();
            objStudent.firstName = txtFirstName.Text;

            objStudent.universityID = txtUniversityID.Text;

            objStudent.ObjDepartment = new Department();
            objStudent.ObjDepartment.DepartmentName = cmbDepartment.Text.ToString();
            objStudent.ObjDepartment.DepartmentID = (int)cmbDepartment.SelectedValue;
            objStudent.dateOfBirth = Convert.ToDateTime(dtpBirthDate.Value);
            objStudent.age = Convert.ToInt32(txtAge.Text);
            objStudent.adress = txtAdress.Text;

            return objStudent;
        }

        //this method will check whether the textboxes(feilds) are empty when user insert data.
        private Boolean Validation()
        {
            bool flag = true;
            if (txtFirstName.Text == String.Empty || txtUniversityID.Text == String.Empty || txtAdress.Text == String.Empty || cmbDepartment.SelectedIndex == -1 || txtAge.Text == String.Empty)
            {
                flag = false;
            }

            return flag;
        }

        //this method will check for whether user is going to insert duplicated records.
        private Boolean DtlduplicateValidation()
        {
            string firstName = txtFirstName.Text;

            string universityID = txtUniversityID.Text;


            bool flag = true;

            foreach (DataGridViewRow dr in dgvStudentDetails.Rows)
            {
                if (firstName == dr.Cells[0].Value.ToString() || universityID == dr.Cells[2].Value.ToString())
                {
                    flag = false;
                }
            }
            return flag;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
            btnStudentDetailsInsert.Enabled = true;
        }

        private void dgvStudentDetails_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtFirstName.Text = dgvStudentDetails.Rows[e.RowIndex].Cells[clmFirstName.Name].Value.ToString();
                txtUniversityID.Text = dgvStudentDetails.Rows[e.RowIndex].Cells[clmUniversityID.Name].Value.ToString();
                txtAge.Text = dgvStudentDetails.Rows[e.RowIndex].Cells[clmAge.Name].Value.ToString();
                txtAdress.Text = dgvStudentDetails.Rows[e.RowIndex].Cells[clmAddress.Name].Value.ToString();
                //cmbDepartment.Text = dgvStudentDetails.Rows[e.RowIndex].Cells[cmbDepartment.Name].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(dgvStudentDetails.Rows[e.RowIndex].Cells[clmDataOfBirth.Name].Value);
                SelectedStudentID = Convert.ToInt32(dgvStudentDetails.Rows[e.RowIndex].Cells[clmStudentID.Name].Value);
                SelectedDeptID = Convert.ToInt32(dgvStudentDetails.Rows[e.RowIndex].Cells[clmDepartmentID.Name].Value);

                Student obj = new Student();
                obj.StudentID = SelectedStudentID;

                cmbDepartment.SelectedValue = SelectedDeptID;
                btnStudentDetailsInsert.Enabled = false;
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
                Student objUpdateStudens = new Student();
                objUpdateStudens.StudentID = SelectedStudentID;
                objUpdateStudens.firstName = txtFirstName.Text;
                objUpdateStudens.universityID = txtUniversityID.Text;
                objUpdateStudens.age = Convert.ToInt32(txtAge.Text);
                objUpdateStudens.adress = txtAdress.Text;
                objUpdateStudens.dateOfBirth = dtpBirthDate.Value;

                objUpdateStudens.ObjDepartment = new Department();
                objUpdateStudens.ObjDepartment.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);

              

                systemManager objsystemManagerUpdateSem = new systemManager();

                if (updateSelected == true)
                {
                    objsystemManagerUpdateSem.UpdateStudentDetails(objUpdateStudens);
                }
                if (deleteSelected == true)
                {
                    objsystemManagerUpdateSem.DeleteStudentDetails(objUpdateStudens);
                }
               

            }
        }

        private void setDataSourceToGrid()
        {
            //here um setting the data source for this data grid 
            dgvStudentDetails.DataSource = null;
            systemManager objsystemManager = new systemManager();
            List<Student> lstStudent = new List<Student>();
            lstStudent = objsystemManager.GetStudentBasicData();
            StudentDetails objStudentDetails;
            List<StudentDetails> lstStudentDetails = new List<StudentDetails>();

            foreach (var item in lstStudent)
            {
                objStudentDetails = new StudentDetails();
                objStudentDetails.firstName = item.FullName;
                objStudentDetails.age = item.age;
                objStudentDetails.dateOfBirth = item.dateOfBirth;
                objStudentDetails.universityID = item.universityID;
                objStudentDetails.StudentID = item.StudentID;
                objStudentDetails.adress = item.adress;
                objStudentDetails.DepartmentName = item.ObjDepartment.DepartmentName;
                objStudentDetails.DepartmentID = item.ObjDepartment.DepartmentID;
                lstStudentDetails.Add(objStudentDetails);
            }


            dgvStudentDetails.DataSource = lstStudentDetails;
        }

        public void reset()
        {
            try
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control ctrl in controls)
                        if (ctrl is TextBox)
                        {
                            (ctrl as TextBox).Clear();
                        }

                        else if (ctrl is ComboBox)
                        {
                            (ctrl as ComboBox).SelectedValue = -1;
                        }
                        else
                            func(ctrl.Controls);
                };

                func(Controls);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                updateSelected = true;
                if (btnStudentDetailsInsert.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtFirstName.Text + "\nhas been updated successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deleteSelected = true;
                if (btnStudentDetailsInsert.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtFirstName.Text + "\nhas been updated successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

    public class StudentDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string universityID { get; set; }
        public int StudentID { get; set; }
        public string adress { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmenCode { get; set; }
        public int DepartmentID { get; set; }
        public string FullName { get; set; }
    }

}
