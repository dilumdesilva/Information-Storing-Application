namespace StudenInformationStoringApp
{
    partial class InsertSemesterDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertSemesterDetailsForm));
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.txtSemCode = new System.Windows.Forms.TextBox();
            this.lblSemCode = new System.Windows.Forms.Label();
            this.txtSemName = new System.Windows.Forms.TextBox();
            this.lblSemName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.dgvSemDetails = new System.Windows.Forms.DataGridView();
            this.clmSemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemsterCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSemesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(86, 30);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(154, 59);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 2;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // txtSemCode
            // 
            this.txtSemCode.Location = new System.Drawing.Point(152, 165);
            this.txtSemCode.Name = "txtSemCode";
            this.txtSemCode.Size = new System.Drawing.Size(154, 20);
            this.txtSemCode.TabIndex = 73;
            // 
            // lblSemCode
            // 
            this.lblSemCode.AutoSize = true;
            this.lblSemCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSemCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSemCode.Location = new System.Drawing.Point(32, 168);
            this.lblSemCode.Name = "lblSemCode";
            this.lblSemCode.Size = new System.Drawing.Size(79, 13);
            this.lblSemCode.TabIndex = 72;
            this.lblSemCode.Text = "Semester Code";
            // 
            // txtSemName
            // 
            this.txtSemName.Location = new System.Drawing.Point(152, 132);
            this.txtSemName.Name = "txtSemName";
            this.txtSemName.Size = new System.Drawing.Size(154, 20);
            this.txtSemName.TabIndex = 71;
            // 
            // lblSemName
            // 
            this.lblSemName.AutoSize = true;
            this.lblSemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSemName.Location = new System.Drawing.Point(32, 135);
            this.lblSemName.Name = "lblSemName";
            this.lblSemName.Size = new System.Drawing.Size(82, 13);
            this.lblSemName.TabIndex = 70;
            this.lblSemName.Text = "Semester Name";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(35, 212);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(76, 23);
            this.btnInsert.TabIndex = 74;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsertSemesters_Click);
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(363, 269);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 76;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblCopyright1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright1.Location = new System.Drawing.Point(320, 265);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 75;
            this.lblCopyright1.Text = "Copyright";
            // 
            // dgvSemDetails
            // 
            this.dgvSemDetails.AllowUserToAddRows = false;
            this.dgvSemDetails.AllowUserToDeleteRows = false;
            this.dgvSemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSemesterID,
            this.clmSemsterCode,
            this.clmSemesterName});
            this.dgvSemDetails.Location = new System.Drawing.Point(342, 30);
            this.dgvSemDetails.Name = "dgvSemDetails";
            this.dgvSemDetails.ReadOnly = true;
            this.dgvSemDetails.Size = new System.Drawing.Size(306, 155);
            this.dgvSemDetails.TabIndex = 77;
            this.dgvSemDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSemDetails_CellContentClick);
            this.dgvSemDetails.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSemDetails_RowHeaderMouseDoubleClick_1);
            // 
            // clmSemesterID
            // 
            this.clmSemesterID.DataPropertyName = "SemesterID";
            this.clmSemesterID.HeaderText = "SemesterID";
            this.clmSemesterID.Name = "clmSemesterID";
            this.clmSemesterID.ReadOnly = true;
            // 
            // clmSemsterCode
            // 
            this.clmSemsterCode.DataPropertyName = "SemesterCode";
            this.clmSemsterCode.HeaderText = "Semster Code";
            this.clmSemsterCode.Name = "clmSemsterCode";
            this.clmSemsterCode.ReadOnly = true;
            // 
            // clmSemesterName
            // 
            this.clmSemesterName.DataPropertyName = "SemesterName";
            this.clmSemesterName.HeaderText = "Semester Name";
            this.clmSemesterName.Name = "clmSemesterName";
            this.clmSemesterName.ReadOnly = true;
            this.clmSemesterName.Width = 170;
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(490, 212);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(76, 23);
            this.btnUpdateDB.TabIndex = 78;
            this.btnUpdateDB.Text = "Upadate";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(572, 212);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(76, 23);
            this.btnDeleteDB.TabIndex = 79;
            this.btnDeleteDB.Text = "Delete";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(117, 212);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 23);
            this.btnReset.TabIndex = 80;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // InsertSemesterDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 291);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.dgvSemDetails);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSemCode);
            this.Controls.Add(this.lblSemCode);
            this.Controls.Add(this.txtSemName);
            this.Controls.Add(this.lblSemName);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "InsertSemesterDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertSemesterDetailsForm";
            this.Load += new System.EventHandler(this.InsertSemesterDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.TextBox txtSemCode;
        private System.Windows.Forms.Label lblSemCode;
        private System.Windows.Forms.TextBox txtSemName;
        private System.Windows.Forms.Label lblSemName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.DataGridView dgvSemDetails;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemesterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemsterCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSemesterName;
    }
}