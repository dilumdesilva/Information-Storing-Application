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
            dgvSemesterSubject.AutoGenerateColumns = false;
            List<SemesterSubject> lst = new List<SemesterSubject>();
            dgvSemesterSubject.DataSource = lst;
            

            
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
            List<SemesterSubject> alreadyGridList = (List<SemesterSubject>)dgvSemesterSubject.DataSource;
            SemesterSubject obj = FillSemesterObject();
            alreadyGridList.Add(obj);
            dgvSemesterSubject.DataSource = null;
            dgvSemesterSubject.DataSource = alreadyGridList;
            
            
            

            // an alternative way to get grid values to a list.

            //List<SemesterSubject> lstSemesterSubject = new List<SemesterSubject>();
            //SemesterSubject objSemesterSubject = new SemesterSubject();

            //if(dgvSemesterSubject.DataSource != null)
            //{
            //    lstSemesterSubject = (List<SemesterSubject>)dgvSemesterSubject.DataSource;
            //    objSemesterSubject.SemesterID = Convert.ToInt32(cmbSemesterSelect.SelectedValue);
            //    objSemesterSubject.SemesterName = cmbSemesterSelect.Text;
            //    objSemesterSubject.SubjectID = Convert.ToInt32(cmbSubjectSelect.SelectedValue);
            //    objSemesterSubject.SubjectName = cmbSubjectSelect.Text;
            //    lstSemesterSubject.Add(objSemesterSubject);

            //    dgvSemesterSubject.AutoGenerateColumns = false;
            //    dgvSemesterSubject.DataSource = null;
            //    dgvSemesterSubject.DataSource = lstSemesterSubject;
            //}
            //else
            //{
            //    objSemesterSubject.SemesterID = Convert.ToInt32(cmbSemesterSelect.SelectedValue);
            //    objSemesterSubject.SemesterName = cmbSemesterSelect.Text;
            //    objSemesterSubject.SubjectID = Convert.ToInt32(cmbSubjectSelect.SelectedValue);
            //    objSemesterSubject.SubjectName = cmbSubjectSelect.Text;
            //    lstSemesterSubject.Add(objSemesterSubject);

            //    dgvSemesterSubject.AutoGenerateColumns = false;
            //    dgvSemesterSubject.DataSource = null;
            //    dgvSemesterSubject.DataSource = lstSemesterSubject;
            //}


        }

        private SemesterSubject FillSemesterObject()
        {

            SemesterSubject obj = new SemesterSubject();
            obj.SemesterID = (int)cmbSemesterSelect.SelectedValue;
            obj.SemesterName = cmbSemesterSelect.Text.ToString();
            obj.SubjectID = (int)cmbSubjectSelect.SelectedValue;
            obj.SubjectName = cmbSubjectSelect.Text.ToString();
            return obj;
        }

        private void btnSelectionsToGrid_Click(object sender, EventArgs e)
        {
            try
            {
                SubduplicateValidation();
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

        //this method will avoid duolications of the subjects 
        private void SubduplicateValidation()
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

        //created an array which holds all the values of semIDs
        //public Array insertSubSemGridToDb()
        //{
        //    int[] semID = new int[dgvSemesterSubject.RowCount];
        //    int[] subID = new int[dgvSemesterSubject.RowCount];

        //    foreach (DataGridViewRow dr in dgvSemesterSubject.Rows)
        //    {
        //        for (int i =0;  i < dgvSemesterSubject.RowCount; i++)
        //        {
        //            int semesterID = Convert.ToInt32(dr.Cells[0].Value);
        //            semID[i] = i; 
        //        }

        //        for (int x =0;  x < dgvSemesterSubject.RowCount; x++)
        //        {
        //            int subjectID = Convert.ToInt32(dr.Cells[0].Value);
        //            subID[x] = x;
        //        }

        //    }

        //    return semID;
        //}

        private void btnUpdateDatabse_Click(object sender, EventArgs e)
        {
            //validataSave();

            List<SemesterSubject> saveList = (List<SemesterSubject>)dgvSemesterSubject.DataSource;
            

        }

        private void validataSave()
        {
            throw new NotImplementedException();
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
