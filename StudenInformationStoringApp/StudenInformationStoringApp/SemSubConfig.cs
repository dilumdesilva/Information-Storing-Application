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

  
        public void FillToGrid()
        {
            List<SemesterSubject> lstSemesterSubject = new List<SemesterSubject>();
            SemesterSubject objSemesterSubject = new SemesterSubject();

            if(dgvSemesterSubject.DataSource != null)
            {
                lstSemesterSubject = (List<SemesterSubject>)dgvSemesterSubject.DataSource;
                objSemesterSubject.SemesterID = Convert.ToInt32(cmbSemesterSelect.SelectedValue);
                objSemesterSubject.SemesterName = cmbSemesterSelect.Text;
                objSemesterSubject.SubjectID = Convert.ToInt32(cmbSubjectSelect.SelectedValue);
                objSemesterSubject.SubjectName = cmbSubjectSelect.Text;
                lstSemesterSubject.Add(objSemesterSubject);

                dgvSemesterSubject.AutoGenerateColumns = false;
                dgvSemesterSubject.DataSource = null;
                dgvSemesterSubject.DataSource = lstSemesterSubject;
            }
            else
            {
                objSemesterSubject.SemesterID = Convert.ToInt32(cmbSemesterSelect.SelectedValue);
                objSemesterSubject.SemesterName = cmbSemesterSelect.Text;
                objSemesterSubject.SubjectID = Convert.ToInt32(cmbSubjectSelect.SelectedValue);
                objSemesterSubject.SubjectName = cmbSubjectSelect.Text;
                lstSemesterSubject.Add(objSemesterSubject);

                dgvSemesterSubject.AutoGenerateColumns = false;
                dgvSemesterSubject.DataSource = null;
                dgvSemesterSubject.DataSource = lstSemesterSubject;
            }

            
        }

        private void btnSelectionsToGrid_Click(object sender, EventArgs e)
        {
            try
            {
                duplicateValidation();
                FillToGrid();

            }
            catch(ApplicationException ax)  
            {
                MessageBox.Show(ax.Message,"Warnning",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void duplicateValidation()
        {
            int selectedSubID = Convert.ToInt32(cmbSubjectSelect.SelectedValue);
            int selectedSemID = Convert.ToInt32(cmbSemesterSelect.SelectedValue);

            foreach (DataGridViewRow dr in dgvSemesterSubject.Rows)
            {
                if (selectedSubID == Convert.ToInt32(dr.Cells[2].Value) && selectedSemID == Convert.ToInt32(dr.Cells[0].Value))
                {
                    throw new ApplicationException("Record duplication found!\nCannot enter a same subject to the semester");
                }
            }
        }

    }


    public class SemesterSubject
    {
        public int SemesterID { get; set; }
        public string SemesterName { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}
