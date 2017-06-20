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
            Department objDepartment = new Department();
            objDepartment.DepartmentName = txtDeptName.Text;
            objDepartment.DepartmenCode = txtDeptCode.Text;

            systemManager objsystemManager = new systemManager();
            objsystemManager.insertDepartments(objDepartment);


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
    }

}
