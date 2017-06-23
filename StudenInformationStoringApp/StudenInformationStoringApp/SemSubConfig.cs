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
    public partial class SemSubConfig : Form
    {
        public SemSubConfig()
        {
            InitializeComponent();
        }

        public void setSemToCmb()
        {
            systemManager objsystemManager1 = new systemManager();
            cmbSemesterSelect.DataSource = objsystemManager1.GetSemestersData();
            cmbSemesterSelect.DisplayMember = "SemesterCode";
            cmbSemesterSelect.ValueMember = "SemesterID";

            cmbSemesterSelect.SelectedIndex =  -1;
        }

        public void setSubToCmb()
        {
            systemManager objsystemManager2 = new systemManager();
            cmbSubjectSelect.DataSource = objsystemManager2.GetSubjectData();
            cmbSubjectSelect.DisplayMember = "SubjectName";
            cmbSubjectSelect.ValueMember = "SubjectID";

            cmbSubjectSelect.SelectedIndex = -1;
        }

        private void SemSubConfig_Load(object sender, EventArgs e)
        {
            try
            {
                setSemToCmb();
                setSubToCmb();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void comboToDatagri()
        {
            string data1 = cmbSemesterSelect.SelectedValue.ToString();
            string data2 = cmbSubjectSelect.SelectedValue.ToString();


        }
    }
}
