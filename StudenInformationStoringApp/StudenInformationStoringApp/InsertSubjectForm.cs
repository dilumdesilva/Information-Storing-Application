﻿using System;
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
        public InsertSubjectForm()
        {
            InitializeComponent();
        }

        public void getSubjectDetails()
        {
            Department objDepartment = new Department();
            objDepartment.SubjectCode = txtSubjectCode.Text;
            objDepartment.SubjectName = txtSubjectName.Text;

            systemManager objsystemManager = new systemManager();
            objsystemManager.insertSubjects(objDepartment);
        }

        private void btnInsertSubject_Click(object sender, EventArgs e)
        {
            try
            {
                getSubjectDetails();
                MessageBox.Show(txtSubjectName.Text + "\nhas been recorded successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}