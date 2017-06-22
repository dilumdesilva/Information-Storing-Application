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
            this.btnInsertSemesters = new System.Windows.Forms.Button();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
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
            // btnInsertSemesters
            // 
            this.btnInsertSemesters.Location = new System.Drawing.Point(35, 212);
            this.btnInsertSemesters.Name = "btnInsertSemesters";
            this.btnInsertSemesters.Size = new System.Drawing.Size(98, 23);
            this.btnInsertSemesters.TabIndex = 74;
            this.btnInsertSemesters.Text = "Insert Semester";
            this.btnInsertSemesters.UseVisualStyleBackColor = true;
            this.btnInsertSemesters.Click += new System.EventHandler(this.btnInsertSemesters_Click);
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(170, 272);
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
            this.lblCopyright1.Location = new System.Drawing.Point(127, 268);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 75;
            this.lblCopyright1.Text = "Copyright";
            // 
            // InsertSemesterDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 289);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.btnInsertSemesters);
            this.Controls.Add(this.txtSemCode);
            this.Controls.Add(this.lblSemCode);
            this.Controls.Add(this.txtSemName);
            this.Controls.Add(this.lblSemName);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "InsertSemesterDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertSemesterDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.TextBox txtSemCode;
        private System.Windows.Forms.Label lblSemCode;
        private System.Windows.Forms.TextBox txtSemName;
        private System.Windows.Forms.Label lblSemName;
        private System.Windows.Forms.Button btnInsertSemesters;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
    }
}