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
            objStudent.lastName = txtLastName.Text;
            objStudent.universityID = txtUniversityID.Text;
            objStudent.age = Convert.ToInt32(txtAge.Text);
            objStudent.dateOfBirth = Convert.ToDateTime(dtpBirthDate.Value);
            objStudent.adress = txtAdress.Text;
            objStudent.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);

            systemManager objsystemManager = new systemManager();
            objsystemManager.insertStudentDetails(objStudent);


        }

        private void btnStudentDetailsInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    if (SemDtlduplicateValidation())
                    {
                        fillToGrid();
                        getData();
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
                setCmbDepartment();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void fillToGrid()
        {
            //method to add data to the grid 
            List<Student> alreadyGridList = new List<Student>();
            if (dgvStudentDetails.DataSource != null)
            {
                alreadyGridList = (List<Student>)dgvStudentDetails.DataSource;
            }

            Student objStudent = fillStudentDetailsObject();
            alreadyGridList.Add(objStudent);
            dgvStudentDetails.DataSource = null;
            dgvStudentDetails.DataSource = alreadyGridList;
        }
        private Student fillStudentDetailsObject()
        {
            Student objStudent = new Student();
            objStudent.firstName = txtFirstName.Text;
            objStudent.lastName = txtLastName.Text;
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
            if (txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty || txtUniversityID.Text == String.Empty || txtAdress.Text == String.Empty || cmbDepartment.SelectedIndex == -1 || txtAge.Text == String.Empty)
            {
                flag = false;
            }
            
            return flag;
        }

        //this method will check for whether user is going to insert duplicated records.
        private Boolean SemDtlduplicateValidation()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string universityID = txtUniversityID.Text;
            

            bool flag = true;

            foreach (DataGridViewRow dr in dgvStudentDetails.Rows)
            {
                if (firstName == dr.Cells[0].Value.ToString() || lastName == dr.Cells[1].Value.ToString() || universityID == dr.Cells[2].Value.ToString())
                {
                    flag = false;
                }
            }
            return flag;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }

}
