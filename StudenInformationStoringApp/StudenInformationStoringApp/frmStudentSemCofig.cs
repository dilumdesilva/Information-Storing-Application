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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
