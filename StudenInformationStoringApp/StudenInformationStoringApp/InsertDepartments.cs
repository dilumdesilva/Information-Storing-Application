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
    public partial class InsertDepartments : System.Windows.Forms.Form
    {
        public int selectedDeptID;
        bool isSelected = false;
        bool updateSelected = false;
        bool deleteSelected = false;

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
                setDataSourceToGrid();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
             {
                
                updateSelected = true;
                if (btnInsertDepartment.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtDeptName.Text + "\nhas been updated successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                deleteSelected = true;
                if (btnInsertDepartment.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtDeptName.Text + "\nhas been deleted successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                reset();
                btnInsertDepartment.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
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

        private void dgvDepartment_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtDeptCode.Text = dgvDepartment.Rows[e.RowIndex].Cells[clmDepartmentCode.Name].Value.ToString();
                txtDeptName.Text = dgvDepartment.Rows[e.RowIndex].Cells[clmDepartmentName.Name].Value.ToString();
                selectedDeptID = Convert.ToInt32(dgvDepartment.Rows[e.RowIndex].Cells[clmDepartmentID.Name].Value);
                btnInsertDepartment.Enabled = false;

                isSelected = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void selectedStuRowDetails()
        {
            if (isSelected == true)
            {
                Department objDepartment = new Department();
                objDepartment.DepartmentName = txtDeptName.Text;
                objDepartment.DepartmenCode = txtDeptCode.Text;
                objDepartment.DepartmentID = selectedDeptID;

                systemManager objSystemManager = new systemManager();
                if (updateSelected == true)
                {
                    objSystemManager.updateDepartments(objDepartment);
                    updateSelected = false;
                }
                if (deleteSelected == true)
                {
                    objSystemManager.deleteDepartments(objDepartment);
                    deleteSelected = false;
                }

            }
        }
    }

}
