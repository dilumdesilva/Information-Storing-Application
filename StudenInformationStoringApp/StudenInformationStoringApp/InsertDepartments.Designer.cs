namespace StudenInformationStoringApp
{
    partial class InsertDepartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertDepartments));
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptCode = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblDeptCode = new System.Windows.Forms.Label();
            this.btnInsertDepartment = new System.Windows.Forms.Button();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.clmDepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(85, 47);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(175, 65);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 2;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(141, 166);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(179, 20);
            this.txtDeptName.TabIndex = 3;
            // 
            // txtDeptCode
            // 
            this.txtDeptCode.Location = new System.Drawing.Point(141, 210);
            this.txtDeptCode.Name = "txtDeptCode";
            this.txtDeptCode.Size = new System.Drawing.Size(179, 20);
            this.txtDeptCode.TabIndex = 4;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(25, 169);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(93, 13);
            this.lblDeptName.TabIndex = 5;
            this.lblDeptName.Text = "Department Name";
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.Location = new System.Drawing.Point(25, 213);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(90, 13);
            this.lblDeptCode.TabIndex = 6;
            this.lblDeptCode.Text = "Department Code";
            // 
            // btnInsertDepartment
            // 
            this.btnInsertDepartment.Location = new System.Drawing.Point(28, 262);
            this.btnInsertDepartment.Name = "btnInsertDepartment";
            this.btnInsertDepartment.Size = new System.Drawing.Size(83, 28);
            this.btnInsertDepartment.TabIndex = 7;
            this.btnInsertDepartment.Text = "Insert";
            this.btnInsertDepartment.UseVisualStyleBackColor = true;
            this.btnInsertDepartment.Click += new System.EventHandler(this.btnInsertDepartment_Click);
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDepartmentID,
            this.clmDepartmentCode,
            this.clmDepartmentName});
            this.dgvDepartment.Location = new System.Drawing.Point(354, 34);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.Size = new System.Drawing.Size(333, 196);
            this.dgvDepartment.TabIndex = 8;
            this.dgvDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellContentClick);
            this.dgvDepartment.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDepartment_RowHeaderMouseDoubleClick_1);
            // 
            // clmDepartmentID
            // 
            this.clmDepartmentID.DataPropertyName = "DepartmentID";
            this.clmDepartmentID.HeaderText = "DepartmentID";
            this.clmDepartmentID.Name = "clmDepartmentID";
            this.clmDepartmentID.ReadOnly = true;
            this.clmDepartmentID.Width = 98;
            // 
            // clmDepartmentCode
            // 
            this.clmDepartmentCode.DataPropertyName = "DepartmenCode";
            this.clmDepartmentCode.HeaderText = "DepartmentCode";
            this.clmDepartmentCode.Name = "clmDepartmentCode";
            this.clmDepartmentCode.ReadOnly = true;
            this.clmDepartmentCode.Width = 112;
            // 
            // clmDepartmentName
            // 
            this.clmDepartmentName.DataPropertyName = "DepartmentName";
            this.clmDepartmentName.HeaderText = "DepartmentName";
            this.clmDepartmentName.Name = "clmDepartmentName";
            this.clmDepartmentName.ReadOnly = true;
            this.clmDepartmentName.Width = 115;
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(352, 326);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 67;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblCopyright1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright1.Location = new System.Drawing.Point(309, 322);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 66;
            this.lblCopyright1.Text = "Copyright";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(515, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 28);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(604, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 28);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(117, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 28);
            this.btnReset.TabIndex = 70;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 71;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InsertDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.btnInsertDepartment);
            this.Controls.Add(this.lblDeptCode);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtDeptCode);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "InsertDepartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Department";
            this.Load += new System.EventHandler(this.InsertDepartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptCode;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblDeptCode;
        private System.Windows.Forms.Button btnInsertDepartment;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartmentName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
    }
}