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
            student objStudent = new student();

            objStudent.firstName = txtFirstName.Text;
            objStudent.lastName = txtLastName.Text;
            objStudent.universityID = txtUniversityID.Text;
            objStudent.age = Convert.ToInt32(txtAge.Text);
            objStudent.dateOfBirth = Convert.ToInt32(txtBirthday.Text);
            objStudent.adress = txtAdress.Text;


        }



    }
}
