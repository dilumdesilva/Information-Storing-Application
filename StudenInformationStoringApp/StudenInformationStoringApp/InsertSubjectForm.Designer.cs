namespace StudenInformationStoringApp
{
    partial class InsertSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertSubjectForm));
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.btnInsertSubject = new System.Windows.Forms.Button();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lblSemCode = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblSemName = new System.Windows.Forms.Label();
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.btnSubjectGridInsertOnce = new System.Windows.Forms.Button();
            this.clmSubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(333, 334);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 84;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblCopyright1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright1.Location = new System.Drawing.Point(290, 330);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 83;
            this.lblCopyright1.Text = "Copyright";
            // 
            // btnInsertSubject
            // 
            this.btnInsertSubject.Location = new System.Drawing.Point(41, 258);
            this.btnInsertSubject.Name = "btnInsertSubject";
            this.btnInsertSubject.Size = new System.Drawing.Size(99, 33);
            this.btnInsertSubject.TabIndex = 82;
            this.btnInsertSubject.Text = "Insert Subject";
            this.btnInsertSubject.UseVisualStyleBackColor = true;
            this.btnInsertSubject.Click += new System.EventHandler(this.btnInsertSubject_Click);
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(135, 198);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(179, 20);
            this.txtSubjectCode.TabIndex = 81;
            // 
            // lblSemCode
            // 
            this.lblSemCode.AutoSize = true;
            this.lblSemCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSemCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSemCode.Location = new System.Drawing.Point(38, 201);
            this.lblSemCode.Name = "lblSemCode";
            this.lblSemCode.Size = new System.Drawing.Size(71, 13);
            this.lblSemCode.TabIndex = 80;
            this.lblSemCode.Text = "Subject Code";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(135, 135);
            this.txtSubjectName.Multiline = true;
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(179, 39);
            this.txtSubjectName.TabIndex = 79;
            // 
            // lblSemName
            // 
            this.lblSemName.AutoSize = true;
            this.lblSemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSemName.Location = new System.Drawing.Point(38, 138);
            this.lblSemName.Name = "lblSemName";
            this.lblSemName.Size = new System.Drawing.Size(43, 13);
            this.lblSemName.TabIndex = 78;
            this.lblSemName.Text = "Subject";
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(101, 31);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(154, 59);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 77;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSubjectCode,
            this.clmSubjectName});
            this.dgvSubject.Location = new System.Drawing.Point(363, 31);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.Size = new System.Drawing.Size(281, 206);
            this.dgvSubject.TabIndex = 85;
            // 
            // btnSubjectGridInsertOnce
            // 
            this.btnSubjectGridInsertOnce.Location = new System.Drawing.Point(545, 258);
            this.btnSubjectGridInsertOnce.Name = "btnSubjectGridInsertOnce";
            this.btnSubjectGridInsertOnce.Size = new System.Drawing.Size(99, 33);
            this.btnSubjectGridInsertOnce.TabIndex = 86;
            this.btnSubjectGridInsertOnce.Text = "Update Database";
            this.btnSubjectGridInsertOnce.UseVisualStyleBackColor = true;
            this.btnSubjectGridInsertOnce.Click += new System.EventHandler(this.btnSubjectGridInsertOnce_Click);
            // 
            // clmSubjectCode
            // 
            this.clmSubjectCode.DataPropertyName = "SubjectCode";
            this.clmSubjectCode.HeaderText = "SubjectCode";
            this.clmSubjectCode.Name = "clmSubjectCode";
            this.clmSubjectCode.ReadOnly = true;
            // 
            // clmSubjectName
            // 
            this.clmSubjectName.DataPropertyName = "SubjectName";
            this.clmSubjectName.HeaderText = "SubjectName";
            this.clmSubjectName.Name = "clmSubjectName";
            this.clmSubjectName.ReadOnly = true;
            // 
            // InsertSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 364);
            this.Controls.Add(this.btnSubjectGridInsertOnce);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.btnInsertSubject);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lblSemCode);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.lblSemName);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "InsertSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertSubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.Button btnInsertSubject;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label lblSemCode;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblSemName;
        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.Button btnSubjectGridInsertOnce;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectName;
    }
}