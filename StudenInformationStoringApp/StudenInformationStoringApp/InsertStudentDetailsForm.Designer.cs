﻿namespace StudenInformationStoringApp
{
    partial class frmInsertStudentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertStudentDetails));
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.btnStudentDetailsInsert = new System.Windows.Forms.Button();
            this.txtUniversityID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picBoxLogoMainForm, "picBoxLogoMainForm");
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // lblCopyright2
            // 
            resources.ApplyResources(this.lblCopyright2, "lblCopyright2");
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Name = "lblCopyright2";
            // 
            // lblCopyright1
            // 
            resources.ApplyResources(this.lblCopyright1, "lblCopyright1");
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Name = "lblCopyright1";
            // 
            // btnStudentDetailsInsert
            // 
            resources.ApplyResources(this.btnStudentDetailsInsert, "btnStudentDetailsInsert");
            this.btnStudentDetailsInsert.Name = "btnStudentDetailsInsert";
            this.btnStudentDetailsInsert.UseVisualStyleBackColor = true;
            this.btnStudentDetailsInsert.Click += new System.EventHandler(this.btnStudentDetailsInsert_Click);
            // 
            // txtUniversityID
            // 
            resources.ApplyResources(this.txtUniversityID, "txtUniversityID");
            this.txtUniversityID.Name = "txtUniversityID";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // lblStudentID
            // 
            resources.ApplyResources(this.lblStudentID, "lblStudentID");
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Name = "lblStudentID";
            // 
            // lblStudentName
            // 
            resources.ApplyResources(this.lblStudentName, "lblStudentName");
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Name = "lblStudentName";
            // 
            // lblInstructions
            // 
            resources.ApplyResources(this.lblInstructions, "lblInstructions");
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Name = "lblInstructions";
            // 
            // lblDateOfBirth
            // 
            resources.ApplyResources(this.lblDateOfBirth, "lblDateOfBirth");
            this.lblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            // 
            // txtAge
            // 
            resources.ApplyResources(this.txtAge, "txtAge");
            this.txtAge.Name = "txtAge";
            // 
            // lblAge
            // 
            resources.ApplyResources(this.lblAge, "lblAge");
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Name = "lblAge";
            // 
            // txtAdress
            // 
            resources.ApplyResources(this.txtAdress, "txtAdress");
            this.txtAdress.Name = "txtAdress";
            // 
            // lblAdress
            // 
            resources.ApplyResources(this.lblAdress, "lblAdress");
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Name = "lblAdress";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpBirthDate, "dtpBirthDate");
            this.dtpBirthDate.Name = "dtpBirthDate";
            // 
            // frmInsertStudentDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.btnStudentDetailsInsert);
            this.Controls.Add(this.txtUniversityID);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "frmInsertStudentDetails";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.Button btnStudentDetailsInsert;
        private System.Windows.Forms.TextBox txtUniversityID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}