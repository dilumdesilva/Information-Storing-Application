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
    public partial class InsertDepartments : Form
    {
        public InsertDepartments()
        {
            InitializeComponent();
        }

        public void getDepartmentData()
        {
            //setting the user userinputs to a object of student class which is in the shared library
            Department objDepartment1 = new Department();
            objDepartment1.DepartmentName = txtDeptName.Text;
            objDepartment1.DepartmenCode = txtDeptCode.Text;

            //passing above values as a object to the business layer.
            systemManager objsystemManager = new systemManager();
            objsystemManager.insertDepartments(objDepartment1);


        }

        private void btnInsertDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                getDepartmentData();
                MessageBox.Show("Departmet "+txtDeptName.Text + "\nhas been recorded successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception EX)
            {

                throw EX;
            }

        }

        private void setDataSourceToGrid()
        {   
            //here um setting the data source for this data grid and hide the coloumn name which is called
            //clmDepratmentID 
            systemManager objsystemManager2 = new systemManager();
            dgvDepartment.DataSource = objsystemManager2.LoadDepartmentToGrid();
            this.dgvDepartment.Columns["clmDepartmentID"].Visible = false;
              
        }

        private void InsertDepartments_Load(object sender, EventArgs e)
        {
            try
            {
                //Loading the data grid data during the main form get refreshed.
                setDataSourceToGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

}
