using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.WinControls;
using System.Diagnostics;
using System.IO;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI.Export;

namespace manageTask
{
    public partial class Reports : Telerik.WinControls.UI.RadForm
    {
        List<Project> data = new List<Project>();
        string type;
        private string[] columnNames = new string[] { "numHour", "name", "dateBegin", "dateEnd", "isFinish", "customerName", "managerId", "userName", "numWorker", "sumHourWork", "numDaysStay",
          "presentDoing", "numHourDoDaysWorker" };
        private Type[] typeColums = new Type[] {typeof(int), typeof(string), typeof(DateTime), typeof(DateTime)
        ,typeof(bool),typeof(string),typeof(int),typeof(string),typeof(int),typeof(decimal),typeof(decimal),typeof(decimal),typeof(decimal)};
        public Reports()
        {
            InitializeComponent();
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.EnableAlternatingRowColor = true;
            FillData();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            this.radGridView1.Print(true, this.radPrintDocument1);
        }

        private void btn_PrintPreview_Click(object sender, EventArgs e)
        {
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.ThemeName = this.radGridView1.ThemeName;
            dialog.Document = this.radPrintDocument1;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }

        private void btn_printSeting_Click(object sender, EventArgs e)
        {
            GridViewPrintSettingsDialog dialog = new GridViewPrintSettingsDialog();
            dialog.ThemeName = this.radGridView1.ThemeName;
            dialog.ShowPreviewButton = false;
            dialog.PrintDocument = this.radPrintDocument1;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btn_PrintPreview_Click(sender, e);
            }
        }

         DataTable dt = new DataTable();
        public void FillData()
        {
           for (int i = 0; i < columnNames.Length; i++)
           {
                dt.Columns.Add(columnNames[i], typeColums[i]);
            }
           
            for (int i = 0; i < 30; i++)
            {
                dt.Rows.Add(i, "Item" + i);
            }
            this.radGridView1.DataSource = dt;
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.MasterTemplate.DataView.BypassFilter = true;
            this.radGridView1.FilterChanged += radGridView1_FilterChanged;
        }
        #region VirtualGrid events 

        private void radGridView1_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.ItemChanged)
            {
                dt.DefaultView.RowFilter = this.radGridView1.FilterDescriptors.Expression;
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                dt.DefaultView.RowFilter = "";
            }
        }

        #endregion
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           // this.AddSummaries();
           // SetConditions();

            this.radListView1.SelectedIndex = 0;
            this.radComboBoxSummaries.SelectedIndex = 0;
          //  this.radGridView1.Columns[0].Width = 30;
        }

        private void radButtonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (saveFileDialog.FileName.Equals(String.Empty))
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show("Please enter a file name.");
                return;
            }

            string fileName = this.saveFileDialog.FileName;
            bool openExportFile = false;

            switch (this.radListView1.SelectedIndex)
            {
                case 0: //export to excelML
                    RunExportToExcelML(fileName, ref openExportFile);
                    break;

                case 1: //export to CSV
                    RunExportToCSV(fileName, ref openExportFile);
                    break;

                case 2: //export to HTML
                    RunExportToHTML(fileName, ref openExportFile);
                    break;

                case 3: //export to PDF
                    RunExportToPDF(fileName, ref openExportFile);
                    break;
            }

            if (openExportFile)
            {
                try
                {
                    Process.Start(fileName);
                }
                catch (Exception ex)
                {
                    string message = String.Format("The file cannot be opened on your system.\nError message: {0}", ex.Message);
                    RadMessageBox.Show(message, "Open File", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }

        private void RunExportToExcelML(string fileName, ref bool openExportFile)
        {
            ExportToExcelML excelExporter = new ExportToExcelML(this.radGridView1);


            excelExporter.SummariesExportOption = SummariesOption.ExportAll;
            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    excelExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    excelExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set exporting visual settings
            excelExporter.ExportVisualSettings = true;
            try
            {
                excelExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to Excel", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void RunExportToCSV(string fileName, ref bool openExportFile)
        {
            ExportToCSV csvExporter = new ExportToCSV(this.radGridView1);
            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    csvExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    csvExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }
            try
            {
                csvExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to CSV", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void RunExportToHTML(string fileName, ref bool openExportFile)
        {
            ExportToHTML htmlExporter = new ExportToHTML(this.radGridView1);

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    htmlExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set exporting visual settings
            htmlExporter.ExportVisualSettings = true;


            try
            {
                htmlExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to HTML", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void RunExportToPDF(string fileName, ref bool openExportFile)
        {

            GridViewPdfExport pdfExporter = new GridViewPdfExport(this.radGridView1);
            pdfExporter.FileExtension = ".pdf";
            pdfExporter.ShowHeaderAndFooter = true;
            pdfExporter.FitToPageWidth = true;

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    pdfExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set exporting visual settings
            pdfExporter.ExportVisualSettings = true;


            try
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    PdfExportRenderer renderer = new PdfExportRenderer();
                    pdfExporter.RunExport(ms, renderer);

                    using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                    {
                        ms.WriteTo(fileStream);
                    }
                }
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to PDF", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }

            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void radListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Excel (*.xls)|*.xls";

            switch (this.radListView1.SelectedIndex)
            {
                case 0: //export to excelML 
                    this.radComboBoxSummaries.Enabled = true;

                    break;
                case 1: //export to CSV
                    saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
                    this.radComboBoxSummaries.Enabled = true;

                    break;
                case 2: //export to HTML
                    saveFileDialog.Filter = "Html File (*.htm)|*.htm";
                    this.radComboBoxSummaries.Enabled = true;

                    break;
                case 3: //export to PDF
                    saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
                    this.radComboBoxSummaries.Enabled = true;

                    break;
            }
        }
    }
}
