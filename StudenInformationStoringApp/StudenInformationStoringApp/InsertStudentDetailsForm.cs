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

            systemManager objsystemManager = new systemManager();
            objsystemManager.insertStudentDetails(objStudent);


        }

        private void btnStudentDetailsInsert_Click(object sender, EventArgs e)
        {
            try
            {
                getData();
                MessageBox.Show(txtFirstName.Text+" has been recorded successfuly!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
