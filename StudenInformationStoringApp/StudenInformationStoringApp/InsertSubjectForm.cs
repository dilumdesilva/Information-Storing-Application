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
                    //MessageBox.Show(txtSubjectName.Text + "\nhas been recorded successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }

   
}
