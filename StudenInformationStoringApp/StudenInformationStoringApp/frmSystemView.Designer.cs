namespace StudenInformationStoringApp
{
    partial class frmSystemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemView));
            this.picBoxLogoMainForm = new System.Windows.Forms.PictureBox();
            this.lblViewInstructions = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogoMainForm
            // 
            this.picBoxLogoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogoMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoMainForm.Image")));
            this.picBoxLogoMainForm.Location = new System.Drawing.Point(55, 24);
            this.picBoxLogoMainForm.Name = "picBoxLogoMainForm";
            this.picBoxLogoMainForm.Size = new System.Drawing.Size(165, 67);
            this.picBoxLogoMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoMainForm.TabIndex = 3;
            this.picBoxLogoMainForm.TabStop = false;
            // 
            // lblViewInstructions
            // 
            this.lblViewInstructions.AutoSize = true;
            this.lblViewInstructions.Location = new System.Drawing.Point(31, 169);
            this.lblViewInstructions.Name = "lblViewInstructions";
            this.lblViewInstructions.Size = new System.Drawing.Size(151, 13);
            this.lblViewInstructions.TabIndex = 4;
            this.lblViewInstructions.Text = "Please select a system to veiw";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "View ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 374);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.lblCopyright2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright2.Location = new System.Drawing.Point(442, 438);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(27, 7);
            this.lblCopyright2.TabIndex = 69;
            this.lblCopyright2.Text = "C 2017";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblCopyright1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright1.Location = new System.Drawing.Point(399, 434);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(45, 12);
            this.lblCopyright1.TabIndex = 68;
            this.lblCopyright1.Text = "Copyright";
            // 
            // frmSystemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 455);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblViewInstructions);
            this.Controls.Add(this.picBoxLogoMainForm);
            this.Name = "frmSystemView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogoMainForm;
        private System.Windows.Forms.Label lblViewInstructions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.Label lblCopyright1;
    }
}