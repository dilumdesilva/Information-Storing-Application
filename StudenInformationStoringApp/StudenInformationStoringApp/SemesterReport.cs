using BALayer;
using CrystalDecisions.CrystalReports.Engine;
using StudenInformationStoringApp.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudenInformationStoringApp
{
    public partial class SemesterReport : Form
    {
        public SemesterReport()
        {
            InitializeComponent();
        }

        private void btnViewSemReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                systemManager objsystemManager = new systemManager();
                dt = objsystemManager.ViewSemestersData();

                if (dt != null && dt.Rows.Count > 0)
                {
                    ReportDocument rptDoc = new ReportDocument();
                    rptSemesterDetails rpt = new rptSemesterDetails();
                    rptDoc = rpt;
                    rptDoc.SetDataSource(dt);
                    frmReportViewer objfrmReportViewer = new frmReportViewer(rptDoc);
                    objfrmReportViewer.Show();
                }
                else
                {

                    MessageBox.Show("No Records");
                }
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
    }
}
