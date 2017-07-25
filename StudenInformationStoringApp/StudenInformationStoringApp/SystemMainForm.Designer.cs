namespace StudenInformationStoringApp
{
    partial class SystemMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemMainForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.insertSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterSubjectAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentSemsterAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertSystemToolStripMenuItem,
            this.veiwToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // insertSystemToolStripMenuItem
            // 
            this.insertSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.studentMarksToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.semestersToolStripMenuItem,
            this.subjectsToolStripMenuItem});
            this.insertSystemToolStripMenuItem.Name = "insertSystemToolStripMenuItem";
            this.insertSystemToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.insertSystemToolStripMenuItem.Text = "Insert";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // studentMarksToolStripMenuItem
            // 
            this.studentMarksToolStripMenuItem.Name = "studentMarksToolStripMenuItem";
            this.studentMarksToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.studentMarksToolStripMenuItem.Text = "Student Marks";
            this.studentMarksToolStripMenuItem.Click += new System.EventHandler(this.studentMarksToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.departmentsToolStripMenuItem.Text = "Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // semestersToolStripMenuItem
            // 
            this.semestersToolStripMenuItem.Name = "semestersToolStripMenuItem";
            this.semestersToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.semestersToolStripMenuItem.Text = "Semesters";
            this.semestersToolStripMenuItem.Click += new System.EventHandler(this.semestersToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            this.subjectsToolStripMenuItem.Click += new System.EventHandler(this.subjectsToolStripMenuItem_Click);
            // 
            // veiwToolStripMenuItem
            // 
            this.veiwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem1,
            this.marksToolStripMenuItem});
            this.veiwToolStripMenuItem.Name = "veiwToolStripMenuItem";
            this.veiwToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.veiwToolStripMenuItem.Text = "Veiw";
            // 
            // studentDetailsToolStripMenuItem1
            // 
            this.studentDetailsToolStripMenuItem1.Name = "studentDetailsToolStripMenuItem1";
            this.studentDetailsToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.studentDetailsToolStripMenuItem1.Text = "Student Details";
            // 
            // marksToolStripMenuItem
            // 
            this.marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            this.marksToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.marksToolStripMenuItem.Text = "Marks";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemReportToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.generateToolStripMenuItem.Text = "Reports";
            // 
            // systemReportToolStripMenuItem
            // 
            this.systemReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semesterDetailsReportToolStripMenuItem});
            this.systemReportToolStripMenuItem.Name = "systemReportToolStripMenuItem";
            this.systemReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.systemReportToolStripMenuItem.Text = "System report";
            // 
            // semesterDetailsReportToolStripMenuItem
            // 
            this.semesterDetailsReportToolStripMenuItem.Name = "semesterDetailsReportToolStripMenuItem";
            this.semesterDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.semesterDetailsReportToolStripMenuItem.Text = "Semester Details Report";
            this.semesterDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.semesterDetailsReportToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semesterSubjectAllocationToolStripMenuItem,
            this.studentSemsterAllocationToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // semesterSubjectAllocationToolStripMenuItem
            // 
            this.semesterSubjectAllocationToolStripMenuItem.Name = "semesterSubjectAllocationToolStripMenuItem";
            this.semesterSubjectAllocationToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.semesterSubjectAllocationToolStripMenuItem.Text = "Semester Subject allocation";
            this.semesterSubjectAllocationToolStripMenuItem.Click += new System.EventHandler(this.semesterSubjectAllocationToolStripMenuItem_Click);
            // 
            // studentSemsterAllocationToolStripMenuItem
            // 
            this.studentSemsterAllocationToolStripMenuItem.Name = "studentSemsterAllocationToolStripMenuItem";
            this.studentSemsterAllocationToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.studentSemsterAllocationToolStripMenuItem.Text = "Student Semster allocation";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSystemToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutSystemToolStripMenuItem
            // 
            this.aboutSystemToolStripMenuItem.Name = "aboutSystemToolStripMenuItem";
            this.aboutSystemToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutSystemToolStripMenuItem.Text = "About system";
            // 
            // SystemMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1230, 503);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "SystemMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem insertSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterSubjectAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentSemsterAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semesterDetailsReportToolStripMenuItem;
    }
}

