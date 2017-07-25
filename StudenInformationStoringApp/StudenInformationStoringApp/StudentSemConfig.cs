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

        private void StudentSemConfig_Load(object sender, EventArgs e)
        {
            try
            {
                setCmbStudent();
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

                //var xxxxx = from t in xxx
                //            where t.StudentID == (int)cmbStudentID.SelectedValue
                //            select t.ObjDepartment.DepartmentName;

                //var xxxxxx = (from t in xxx
                //             where t.StudentID == (int)cmbStudentID.SelectedValue
                //             select t.ObjDepartment.DepartmentName).ToList(); 

                //here i've write the above code using a lamda expression
                txtDepartment.Text = xxx.Find(g => g.StudentID == (int)cmbStudentID.SelectedValue).ObjDepartment.DepartmentName;

                //you can do it without declaring a varible 
                txtStudentName.Text = ((List<Student>)cmbStudentID.DataSource).Find(g => g.StudentID == (int)cmbStudentID.SelectedValue).FullName.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
