namespace StudenInformationStoringApp
{
    partial class SemesterReport
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
            this.btnViewSemReport = new System.Windows.Forms.Button();
            this.lblSemesterReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewSemReport
            // 
            this.btnViewSemReport.Location = new System.Drawing.Point(151, 142);
            this.btnViewSemReport.Name = "btnViewSemReport";
            this.btnViewSemReport.Size = new System.Drawing.Size(75, 23);
            this.btnViewSemReport.TabIndex = 0;
            this.btnViewSemReport.Text = "View";
            this.btnViewSemReport.UseVisualStyleBackColor = true;
            this.btnViewSemReport.Click += new System.EventHandler(this.btnViewSemReport_Click);
            // 
            // lblSemesterReport
            // 
            this.lblSemesterReport.AutoSize = true;
            this.lblSemesterReport.Location = new System.Drawing.Point(129, 61);
            this.lblSemesterReport.Name = "lblSemesterReport";
            this.lblSemesterReport.Size = new System.Drawing.Size(121, 13);
            this.lblSemesterReport.TabIndex = 1;
            this.lblSemesterReport.Text = "Semester Details Report";
            // 
            // SemesterReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 217);
            this.Controls.Add(this.lblSemesterReport);
            this.Controls.Add(this.btnViewSemReport);
            this.Name = "SemesterReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewSemReport;
        private System.Windows.Forms.Label lblSemesterReport;
    }
}