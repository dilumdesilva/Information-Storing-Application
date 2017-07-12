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
        bool isSelected = false;
        int selectedSemID = 0;
        public InsertSemesterDetailsForm()
        {
            InitializeComponent();
            dgvSemDetails.AutoGenerateColumns = false;
            List<Semesters> lst = new List<Semesters>();
            dgvSemDetails.DataSource = lst;
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
                //dgvSemDetails.DataSource = null;
                
                if (Validation())
                {

                    if (SemDtlduplicateValidation())
                    {
                        fillToGrid();
                        getSemesterDetails();
                        MessageBox.Show(txtSemName.Text + "\nhas been recorded successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }                   
                    else
                    {
                        throw new ApplicationException("Record duplication found!\nCannot proceed with same records");
                    }

                }

                else
                {
                    MessageBox.Show("Empty records has found\nPlease fill the feilds before proceed...", "Empty records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(ApplicationException ax)
            {
                MessageBox.Show(ax.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //method which fills the grid with user entered data.
        public void fillToGrid()
        {
            List<Semesters> alreadyGridList = (List<Semesters>)dgvSemDetails.DataSource;
            Semesters objSemesters = getSemstersDtl();
            alreadyGridList.Add(objSemesters);
            dgvSemDetails.DataSource = null;
            dgvSemDetails.DataSource = alreadyGridList;
        }

        //method which get user enterd data.
        private Semesters getSemstersDtl()
        {
            Semesters objSemesters = new Semesters();
            objSemesters.SemesterCode = txtSemCode.Text.ToString();
            objSemesters.SemesterName = txtSemName.Text.ToString();
            return objSemesters;
        }

        //this method will check whether the textboxes(feilds) are empty when user insert data.
        private Boolean Validation()
        {
            bool flag = true;
            if (txtSemCode.Text == String.Empty || txtSemName.Text == String.Empty)
            {
                flag = false;
            }
            return flag;
        }

        //this method will check for whether user is going to insert duplicated records.
        private Boolean SemDtlduplicateValidation()
        {
            string SemesterCode = txtSemCode.Text.ToString();
            string SemesterName = txtSemName.Text.ToString();
            bool flag = true;

            foreach (DataGridViewRow dr in dgvSemDetails.Rows)
            {
                if (SemesterCode == dr.Cells[0].Value.ToString() || SemesterName == dr.Cells[1].Value.ToString())
                {
                    flag = false;
                }
            }
            return flag;
        }



        private void setDataSourceToGrid()
        {
            //here um setting the data source for this data grid 
            dgvSemDetails.DataSource = null;
            systemManager objsystemManager = new systemManager();
            dgvSemDetails.DataSource = objsystemManager.GetSemestersData();


        }

        private void InsertSemesterDetailsForm_Load(object sender, EventArgs e)
        {
            setDataSourceToGrid();
        }

        private void dgvSemDetails_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtSemCode.Text = dgvSemDetails.Rows[e.RowIndex].Cells[clmSemsterCode.Name].Value.ToString();
                txtSemName.Text = dgvSemDetails.Rows[e.RowIndex].Cells[clmSemesterName.Name].Value.ToString();
                selectedSemID = Convert.ToInt32(dgvSemDetails.Rows[e.RowIndex].Cells[clmSemesterID.Name].Value);
                btnInsert.Enabled = false;
                isSelected = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void selectedSemeRowDetails()
        {
            if (isSelected == true)
            {
                Semesters objUpdateSemesters = new Semesters();
                objUpdateSemesters.SemesterCode = txtSemCode.Text;
                objUpdateSemesters.SemesterName = txtSemName.Text;
                objUpdateSemesters.SemesterID = selectedSemID;

                systemManager objsystemManagerUpdateSem = new systemManager();
                objsystemManagerUpdateSem.passSemesterDetails(objUpdateSemesters);

            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnInsert.Enabled == false)
                {
                    selectedSemeRowDetails();
                    MessageBox.Show(txtSemName.Text + "\nhas been updated successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSemDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnInsert.Enabled == false)
                {
                    selectedSemeRowDetails();
                    MessageBox.Show(txtSemName.Text + "\nhas been deleted successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDataSourceToGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void reset()
        {
            try
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control ctrl in controls)
                        if (ctrl is TextBox)
                        {
                            (ctrl as TextBox).Clear();
                        }

                        else if (ctrl is ComboBox)
                        {
                            (ctrl as ComboBox).SelectedValue = -1;
                        }
                        else
                            func(ctrl.Controls);
                };

                func(Controls);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

