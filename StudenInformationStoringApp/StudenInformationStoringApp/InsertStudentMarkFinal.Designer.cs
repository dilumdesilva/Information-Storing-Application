namespace StudenInformationStoringApp
{
    partial class InsertStudentMarkFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertStudentMarkFinal));
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnInsertMarks = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.dgvStuMarks = new System.Windows.Forms.DataGridView();
            this.clmStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "A+",
            "A",
            "B",
            "C",
            "S",
            "F"});
            this.cmbGrade.Location = new System.Drawing.Point(145, 304);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(146, 21);
            this.cmbGrade.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(145, 164);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(146, 20);
            this.txtStudentName.TabIndex = 86;
            // 
            // btnInsertMarks
            // 
            this.btnInsertMarks.Location = new System.Drawing.Point(47, 361);
            this.btnInsertMarks.Name = "btnInsertMarks";
            this.btnInsertMarks.Size = new System.Drawing.Size(90, 23);
            this.btnInsertMarks.TabIndex = 85;
            this.btnInsertMarks.Text = "Insert Marks";
            this.btnInsertMarks.UseVisualStyleBackColor = true;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(145, 234);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(146, 21);
            this.cmbSubject.TabIndex = 84;
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(145, 200);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(146, 21);
            this.cmbSemester.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Subject";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(145, 269);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(146, 20);
            this.txtMarks.TabIndex = 80;
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(145, 128);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(146, 21);
            this.cmbStudentID.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Student ID";
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(87, 28);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(165, 60);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 92;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // dgvStuMarks
            // 
            this.dgvStuMarks.AllowUserToAddRows = false;
            this.dgvStuMarks.AllowUserToDeleteRows = false;
            this.dgvStuMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStudent,
            this.clmStudentID,
            this.clmSemester,
            this.clmSubject,
            this.clmMarks,
            this.clmGrade});
            this.dgvStuMarks.Location = new System.Drawing.Point(316, 28);
            this.dgvStuMarks.Name = "dgvStuMarks";
            this.dgvStuMarks.ReadOnly = true;
            this.dgvStuMarks.Size = new System.Drawing.Size(627, 356);
            this.dgvStuMarks.TabIndex = 93;
            // 
            // clmStudent
            // 
            this.clmStudent.DataPropertyName = "stuFullName";
            this.clmStudent.HeaderText = "Student";
            this.clmStudent.Name = "clmStudent";
            this.clmStudent.ReadOnly = true;
            // 
            // clmStudentID
            // 
            this.clmStudentID.DataPropertyName = "universityID";
            this.clmStudentID.HeaderText = "Student ID";
            this.clmStudentID.Name = "clmStudentID";
            this.clmStudentID.ReadOnly = true;
            // 
            // clmSemester
            // 
            this.clmSemester.DataPropertyName = "SemesterCode";
            this.clmSemester.HeaderText = "Semester";
            this.clmSemester.Name = "clmSemester";
            this.clmSemester.ReadOnly = true;
            // 
            // clmSubject
            // 
            this.clmSubject.DataPropertyName = "SubjectCode";
            this.clmSubject.HeaderText = "Subject";
            this.clmSubject.Name = "clmSubject";
            this.clmSubject.ReadOnly = true;
            // 
            // clmMarks
            // 
            this.clmMarks.DataPropertyName = "Mark";
            this.clmMarks.HeaderText = "Marks";
            this.clmMarks.Name = "clmMarks";
            this.clmMarks.ReadOnly = true;
            // 
            // clmGrade
            // 
            this.clmGrade.DataPropertyName = "Grade";
            this.clmGrade.HeaderText = "Grade";
            this.clmGrade.Name = "clmGrade";
            this.clmGrade.ReadOnly = true;
            // 
            // InsertStudentMarkFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 422);
            this.Controls.Add(this.dgvStuMarks);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnInsertMarks);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.cmbStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InsertStudentMarkFinal";
            this.Text = "InsertStudentMarkFinal";
            this.Load += new System.EventHandler(this.InsertStudentMarkFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnInsertMarks;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.DataGridView dgvStuMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrade;
    }
}