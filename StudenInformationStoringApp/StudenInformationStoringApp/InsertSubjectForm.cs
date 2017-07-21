using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using Shared_Library;

namespace StudenInformationStoringApp
{
    public partial class InsertSubjectForm : Form
    {
        public int selectedSubID;
        bool isSelected = false;
        bool updateSelected = false;
        bool deleteSelected = false;

        Boolean flag;
        public InsertSubjectForm()
        {
            InitializeComponent();
            dgvSubject.AutoGenerateColumns = false;
            List<Subjects> lst = new List<Subjects>();
            dgvSubject.DataSource = lst; 
        }

        public void getSubjectDetails()
        {

            Subjects objSubjects = new Subjects();
            objSubjects.SubjectCode = txtSubjectCode.Text;
            objSubjects.SubjectName = txtSubjectName.Text;
           
                systemManager objsystemManager = new systemManager();
               objsystemManager.insertSubjects(objSubjects);
           
        }

        private void btnInsertSubject_Click(object sender, EventArgs e)
                    {
            try
            {

                if (Validation())
                {
                    getSubjectDetails();
                    fillToGrid();
                    MessageBox.Show(txtSubjectName.Text + "\nhas been recorded successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if(!Validation())
                {
                    MessageBox.Show("Empty records has found\nPlease fill the feilds before proceed...","Empty records",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private Boolean Validation()
        {
            bool flag = true;
            if (txtSubjectCode.Text == String.Empty || txtSubjectName.Text == String.Empty)
            {
                flag = false;
            }
            return flag;
        }

        public void fillToGrid()
        {
            List<Subjects> alreadyGridList = (List<Subjects>)dgvSubject.DataSource;
            Subjects objSubjects = getSubjects();
            alreadyGridList.Add(objSubjects);
            dgvSubject.DataSource = null;
            dgvSubject.DataSource = alreadyGridList;
        }

        private Subjects getSubjects()
        {
            Subjects objSubjects = new Subjects();
            objSubjects.SubjectName =  txtSubjectName.Text.ToString();
            objSubjects.SubjectCode = txtSubjectCode.Text.ToString();
            return objSubjects;
        }

        private void btnSubjectGridInsertOnce_Click(object sender, EventArgs e)
        {

        }

        private void setDataSourceToGrid()
        {
            //here um setting the data source for this data grid 
            systemManager objsystemManager = new systemManager();
            dgvSubject.DataSource = objsystemManager.GetSubjectData();
          

        }

        private void InsertSubjectForm_Load(object sender, EventArgs e)
        {
            try
            {
                setDataSourceToGrid();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        private void dgvSubject_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtSubjectName.Text = dgvSubject.Rows[e.RowIndex].Cells[clmSubjectName.Name].Value.ToString();
                txtSubjectCode.Text = dgvSubject.Rows[e.RowIndex].Cells[clmSubjectCode.Name].Value.ToString();
                selectedSubID = Convert.ToInt32(dgvSubject.Rows[e.RowIndex].Cells[clmSubjectID.Name].Value);
                btnInsertSubject.Enabled = false;

                isSelected = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void selectedStuRowDetails()
        {
            if (isSelected == true)
            {
                Subjects objSubjects = new Subjects();
                objSubjects.SubjectName = txtSubjectName.Text;
                objSubjects.SubjectCode = txtSubjectCode.Text;
                objSubjects.SubjectID = selectedSubID;

                systemManager objSystemManager = new systemManager();
                if (updateSelected == true)
                {
                    objSystemManager.updateSubjects(objSubjects);
                    updateSelected = false;
                }
                if (deleteSelected == true)
                {
                    objSystemManager.deleteSubjects(objSubjects);
                    deleteSelected = false;
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                updateSelected = true;
                if (btnInsertSubject.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtSubjectName.Text + "\nhas been updated successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deleteSelected = true;
                if (btnInsertSubject.Enabled == false)
                {
                    selectedStuRowDetails();
                    MessageBox.Show(txtSubjectName.Text + "\nhas been deleted successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

   
}
