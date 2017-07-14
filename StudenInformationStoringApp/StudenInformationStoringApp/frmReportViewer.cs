using CrystalDecisions.CrystalReports.Engine;
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
    

    public partial class frmReportViewer : Form
    {
        ReportDocument RptReportDocument;
        ToolStripButton objToolStripButton;
        bool PrintAtOnce = false;
        bool IsPrint = false;

        public frmReportViewer()
        {
            InitializeComponent();
        }

        public frmReportViewer(ReportDocument rptDoc)
        {
            InitializeComponent();
            RptReportDocument = rptDoc;
            crystalReportViewer1.ReportSource = rptDoc;
            crystalReportViewer1.ShowCloseButton = false;
        }


        public frmReportViewer(ReportDocument rptDoc, bool isCustom)
        {
            InitializeComponent();
            RptReportDocument = rptDoc;
            crystalReportViewer1.ReportSource = rptDoc;
            crystalReportViewer1.ShowExportButton = false;
            crystalReportViewer1.ShowPrintButton = false;
            crystalReportViewer1.ShowCloseButton = false;

        }

        public frmReportViewer(ReportDocument rptDoc, bool printAtOnce, bool isCustom)
        {
            InitializeComponent();
            PrintAtOnce = printAtOnce;
            RptReportDocument = rptDoc;
            crystalReportViewer1.ReportSource = rptDoc;
            if (PrintAtOnce)
            {
                crystalReportViewer1.DisplayToolbar = false;
                objToolStripButton = new ToolStripButton();
                objToolStripButton.Text = "Print";
                Size aa = new Size(50, 30);
                objToolStripButton.Size = aa;
                objToolStripButton.Click += new EventHandler(objToolStripButton_Click);
                ToolStrip objToolStrip = new ToolStrip(objToolStripButton);
                crystalReportViewer1.Controls.Add(objToolStrip);

            }
            else
            {
                crystalReportViewer1.ShowPrintButton = false;
                crystalReportViewer1.ShowExportButton = false;
            }

        }

        private void objToolStripButton_Click(object sender, EventArgs e)
        {
            RptReportDocument.PrintToPrinter(1, false, 0, 0);
            IsPrint = true;
            objToolStripButton.Enabled = false;
        }
    }
}
