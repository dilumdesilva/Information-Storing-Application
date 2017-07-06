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
    public partial class InsertSemesterDetailsForm : System.Windows.Forms.Form
    {
        public InsertSemesterDetailsForm()
        {
            InitializeComponent();
        }

        public void getSemesterDetails()
        {
            Semesters objSemesters = new Semesters();
            objSemesters.SemesterName = txtSemName.Text;
            objSemesters.SemesterCode = txtSemCode.Text;

            //passing above values as a object to the business layer.
            systemManager objsystemManager = new systemManager();
            objsystemManager.insertSemesters(objSemesters);


        }

        private void btnInsertSemesters_Click(object sender, EventArgs e)
        {
            try
            {
                getSemesterDetails();
                MessageBox.Show(txtSemName.Text + "\nhas been recorded successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
