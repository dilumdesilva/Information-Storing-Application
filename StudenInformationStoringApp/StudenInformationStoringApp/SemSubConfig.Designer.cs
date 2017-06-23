namespace StudenInformationStoringApp
{
    partial class SemSubConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemSubConfig));
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.cmbSemesterSelect = new System.Windows.Forms.ComboBox();
            this.dgvSemesterSubject = new System.Windows.Forms.DataGridView();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubjectSelect = new System.Windows.Forms.ComboBox();
            this.btnSelectionsToGrid = new System.Windows.Forms.Button();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.btnUpdateDatabse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clmSemeterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemesterSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(41, 40);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(165, 67);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 2;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // cmbSemesterSelect
            // 
            this.cmbSemesterSelect.FormattingEnabled = true;
            this.cmbSemesterSelect.Location = new System.Drawing.Point(23, 167);
            this.cmbSemesterSelect.Name = "cmbSemesterSelect";
            this.cmbSemesterSelect.Size = new System.Drawing.Size(183, 21);
            this.cmbSemesterSelect.TabIndex = 3;
            // 
            // dgvSemesterSubject
            // 
            this.dgvSemesterSubject.AllowUserToAddRows = false;
            this.dgvSemesterSubject.AllowUserToDeleteRows = false;
            this.dgvSemesterSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSemesterSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemesterSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSemeterID,
            this.clmSemesterName,
            this.clmSubjectID,
            this.clmSubjectName});
            this.dgvSemesterSubject.Location = new System.Drawing.Point(270, 54);
            this.dgvSemesterSubject.Name = "dgvSemesterSubject";
            this.dgvSemesterSubject.ReadOnly = true;
            this.dgvSemesterSubject.Size = new System.Drawing.Size(315, 196);
            this.dgvSemesterSubject.TabIndex = 4;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(20, 146);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(84, 13);
            this.lblSemester.TabIndex = 5;
            this.lblSemester.Text = "Select Semester";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(20, 207);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(76, 13);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Select Subject";
            // 
            // cmbSubjectSelect
            // 
            this.cmbSubjectSelect.FormattingEnabled = true;
            this.cmbSubjectSelect.Location = new System.Drawing.Point(23, 229);
            this.cmbSubjectSelect.Name = "cmbSubjectSelect";
            this.cmbSubjectSelect.Size = new System.Drawing.Size(183, 21);
            this.cmbSubjectSelect.TabIndex = 7;
            // 
            // btnSelectionsToGrid
            // 
            this.btnSelectionsToGrid.Location = new System.Drawing.Point(23, 271);
            this.btnSelectionsToGrid.Name = "btnSelectionsToGrid";
            this.btnSelectionsToGrid.Size = new System.Drawing.Size(111, 25);
            this.btnSelectionsToGrid.TabIndex = 8;
            this.btnSelectionsToGrid.Text = "Set Selections";
            this.btnSelectionsToGrid.UseVisualStyleBackColor = true;
            this.btnSelectionsToGrid.Click += new System.EventHandler(this.btnSelectionsToGrid_Click);
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(292, 342);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 86;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblCopyright1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright1.Location = new System.Drawing.Point(249, 338);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 85;
            this.lblCopyright1.Text = "Copyright";
            // 
            // btnUpdateDatabse
            // 
            this.btnUpdateDatabse.Location = new System.Drawing.Point(459, 271);
            this.btnUpdateDatabse.Name = "btnUpdateDatabse";
            this.btnUpdateDatabse.Size = new System.Drawing.Size(111, 25);
            this.btnUpdateDatabse.TabIndex = 87;
            this.btnUpdateDatabse.Text = "Update Databse";
            this.btnUpdateDatabse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Your selected details preview";
            // 
            // clmSemeterID
            // 
            this.clmSemeterID.DataPropertyName = "SemesterID";
            this.clmSemeterID.HeaderText = "SemeterID";
            this.clmSemeterID.Name = "clmSemeterID";
            this.clmSemeterID.ReadOnly = true;
            this.clmSemeterID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSemeterID.Visible = false;
            this.clmSemeterID.Width = 82;
            // 
            // clmSemesterName
            // 
            this.clmSemesterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSemesterName.DataPropertyName = "SemesterName";
            this.clmSemesterName.HeaderText = "SemesterName";
            this.clmSemesterName.Name = "clmSemesterName";
            this.clmSemesterName.ReadOnly = true;
            this.clmSemesterName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSemesterName.Width = 104;
            // 
            // clmSubjectID
            // 
            this.clmSubjectID.DataPropertyName = "SubjectID";
            this.clmSubjectID.HeaderText = "SubjectID";
            this.clmSubjectID.Name = "clmSubjectID";
            this.clmSubjectID.ReadOnly = true;
            this.clmSubjectID.Visible = false;
            // 
            // clmSubjectName
            // 
            this.clmSubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSubjectName.DataPropertyName = "SubjectName";
            this.clmSubjectName.HeaderText = "SubjectName";
            this.clmSubjectName.Name = "clmSubjectName";
            this.clmSubjectName.ReadOnly = true;
            this.clmSubjectName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSubjectName.Width = 96;
            // 
            // SemSubConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateDatabse);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.btnSelectionsToGrid);
            this.Controls.Add(this.cmbSubjectSelect);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.dgvSemesterSubject);
            this.Controls.Add(this.cmbSemesterSelect);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "SemSubConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SemesterSubjectAllocationForm";
            this.Load += new System.EventHandler(this.SemSubConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemesterSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.ComboBox cmbSemesterSelect;
        private System.Windows.Forms.DataGridView dgvSemesterSubject;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubjectSelect;
        private System.Windows.Forms.Button btnSelectionsToGrid;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.Button btnUpdateDatabse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemeterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemesterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectName;
    }
}