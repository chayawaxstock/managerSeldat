namespace manageTask
{
    partial class ReportProject
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("excel");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("clv");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("html");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("pdf");
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.radButtonPrint = new Telerik.WinControls.UI.RadButton();
            this.radButtonPrintPreview = new Telerik.WinControls.UI.RadButton();
            this.printSeting = new Telerik.WinControls.UI.RadButton();
            this.radListBox1 = new Telerik.WinControls.UI.RadListView();
            this.radButtonExport = new Telerik.WinControls.UI.RadButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.radComboBoxSummaries = new Telerik.WinControls.UI.RadDropDownList();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrintPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(31, 49);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowRowResize = false;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.EnableSorting = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(403, 336);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.ThemeName = "TelerikMetroTouch";
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radPrintDocument1.Watermark = radPrintWatermark1;
            // 
            // radButtonPrint
            // 
            this.radButtonPrint.Location = new System.Drawing.Point(31, 7);
            this.radButtonPrint.Name = "radButtonPrint";
            this.radButtonPrint.Size = new System.Drawing.Size(110, 35);
            this.radButtonPrint.TabIndex = 1;
            this.radButtonPrint.Text = "print";
            this.radButtonPrint.ThemeName = "TelerikMetroTouch";
            this.radButtonPrint.Click += new System.EventHandler(this.radButtonPrint_Click);
            // 
            // radButtonPrintPreview
            // 
            this.radButtonPrintPreview.Location = new System.Drawing.Point(148, 7);
            this.radButtonPrintPreview.Name = "radButtonPrintPreview";
            this.radButtonPrintPreview.Size = new System.Drawing.Size(110, 35);
            this.radButtonPrintPreview.TabIndex = 2;
            this.radButtonPrintPreview.Text = "PrintPreview";
            this.radButtonPrintPreview.ThemeName = "TelerikMetroTouch";
            this.radButtonPrintPreview.Click += new System.EventHandler(this.radButtonPrintPreview_Click);
            // 
            // printSeting
            // 
            this.printSeting.Location = new System.Drawing.Point(264, 7);
            this.printSeting.Name = "printSeting";
            this.printSeting.Size = new System.Drawing.Size(120, 36);
            this.printSeting.TabIndex = 3;
            this.printSeting.Text = "printSeting";
            this.printSeting.ThemeName = "TelerikMetroTouch";
            this.printSeting.Click += new System.EventHandler(this.radButtonPrintSettings_Click);
            // 
            // radListBox1
            // 
            this.radListBox1.GroupItemSize = new System.Drawing.Size(200, 36);
            listViewDataItem1.Text = "excel";
            listViewDataItem2.Text = "clv";
            listViewDataItem3.Text = "html";
            listViewDataItem4.Text = "pdf";
            this.radListBox1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1,
            listViewDataItem2,
            listViewDataItem3,
            listViewDataItem4});
            this.radListBox1.ItemSize = new System.Drawing.Size(200, 36);
            this.radListBox1.Location = new System.Drawing.Point(440, 49);
            this.radListBox1.Name = "radListBox1";
            this.radListBox1.Size = new System.Drawing.Size(120, 118);
            this.radListBox1.TabIndex = 4;
            this.radListBox1.ThemeName = "Breeze";
            this.radListBox1.SelectedIndexChanged += new System.EventHandler(this.radListBox1_SelectedIndexChanged);
            // 
            // radButtonExport
            // 
            this.radButtonExport.Location = new System.Drawing.Point(445, 244);
            this.radButtonExport.Name = "radButtonExport";
            this.radButtonExport.Size = new System.Drawing.Size(110, 32);
            this.radButtonExport.TabIndex = 7;
            this.radButtonExport.Text = "Export";
            this.radButtonExport.ThemeName = "TelerikMetroTouch";
            this.radButtonExport.Click += new System.EventHandler(this.radButtonExport_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(440, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(100, 23);
            this.radLabel1.TabIndex = 8;
            this.radLabel1.Text = "Export setting";
            this.radLabel1.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(441, 174);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(75, 23);
            this.radLabel2.TabIndex = 9;
            this.radLabel2.Text = "Properties";
            this.radLabel2.ThemeName = "TelerikMetroTouch";
            // 
            // radComboBoxSummaries
            // 
            radListDataItem1.Text = "ExportAll";
            radListDataItem2.Text = "ExportOnlyTop";
            radListDataItem3.Text = "ExportOnlyBottom";
            radListDataItem4.Text = "DoNotExport";
            this.radComboBoxSummaries.Items.Add(radListDataItem1);
            this.radComboBoxSummaries.Items.Add(radListDataItem2);
            this.radComboBoxSummaries.Items.Add(radListDataItem3);
            this.radComboBoxSummaries.Items.Add(radListDataItem4);
            this.radComboBoxSummaries.Location = new System.Drawing.Point(438, 203);
            this.radComboBoxSummaries.Name = "radComboBoxSummaries";
            this.radComboBoxSummaries.Size = new System.Drawing.Size(125, 24);
            this.radComboBoxSummaries.TabIndex = 10;
            this.radComboBoxSummaries.ThemeName = "Fluent";
            // 
            // ReportProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 419);
            this.Controls.Add(this.radComboBoxSummaries);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButtonExport);
            this.Controls.Add(this.radListBox1);
            this.Controls.Add(this.printSeting);
            this.Controls.Add(this.radButtonPrintPreview);
            this.Controls.Add(this.radButtonPrint);
            this.Controls.Add(this.radGridView1);
            this.Name = "ReportProject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ReportProject";
            this.ThemeName = "TelerikMetroTouch";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrintPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadButton radButtonPrint;
        private Telerik.WinControls.UI.RadButton radButtonPrintPreview;
        private Telerik.WinControls.UI.RadButton printSeting;
        private Telerik.WinControls.UI.RadListView radListBox1;
        private Telerik.WinControls.UI.RadButton radButtonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxSummaries;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
    }
}
