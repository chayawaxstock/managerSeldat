namespace manageTask
{
    partial class Reports
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
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("excel");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("clv");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("html");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("pdf");
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.btn_print = new Telerik.WinControls.UI.RadButton();
            this.btn_PrintPreview = new Telerik.WinControls.UI.RadButton();
            this.btn_printSeting = new Telerik.WinControls.UI.RadButton();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radComboBoxSummaries = new Telerik.WinControls.UI.RadDropDownList();
            this.radButtonExport = new Telerik.WinControls.UI.RadButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrintPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_printSeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(44, 34);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(121, 60);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Print";
            this.btn_print.ThemeName = "Material";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_PrintPreview
            // 
            this.btn_PrintPreview.Location = new System.Drawing.Point(188, 34);
            this.btn_PrintPreview.Name = "btn_PrintPreview";
            this.btn_PrintPreview.Size = new System.Drawing.Size(121, 60);
            this.btn_PrintPreview.TabIndex = 1;
            this.btn_PrintPreview.Text = "PrintPreview";
            this.btn_PrintPreview.ThemeName = "Material";
            this.btn_PrintPreview.Click += new System.EventHandler(this.btn_PrintPreview_Click);
            // 
            // btn_printSeting
            // 
            this.btn_printSeting.Location = new System.Drawing.Point(338, 34);
            this.btn_printSeting.Name = "btn_printSeting";
            this.btn_printSeting.Size = new System.Drawing.Size(121, 60);
            this.btn_printSeting.TabIndex = 1;
            this.btn_printSeting.Text = "PrintSeting";
            this.btn_printSeting.ThemeName = "Material";
            this.btn_printSeting.Click += new System.EventHandler(this.btn_printSeting_Click);
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radPrintDocument1.Watermark = radPrintWatermark1;
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(30, 112);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(643, 390);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.ThemeName = "Material";
            // 
            // radListView1
            // 
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 36);
            listViewDataItem1.Text = "excel";
            listViewDataItem2.Text = "clv";
            listViewDataItem3.Text = "html";
            listViewDataItem4.Text = "pdf";
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1,
            listViewDataItem2,
            listViewDataItem3,
            listViewDataItem4});
            this.radListView1.ItemSize = new System.Drawing.Size(200, 36);
            this.radListView1.Location = new System.Drawing.Point(693, 112);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(123, 158);
            this.radListView1.TabIndex = 3;
            this.radListView1.ThemeName = "Material";
            this.radListView1.SelectedIndexChanged += new System.EventHandler(this.radListBox1_SelectedIndexChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(702, 296);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(74, 21);
            this.radLabel2.TabIndex = 10;
            this.radLabel2.Text = "Properties";
            this.radLabel2.ThemeName = "Material";
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
            this.radComboBoxSummaries.Location = new System.Drawing.Point(699, 317);
            this.radComboBoxSummaries.Name = "radComboBoxSummaries";
            this.radComboBoxSummaries.Size = new System.Drawing.Size(125, 36);
            this.radComboBoxSummaries.TabIndex = 11;
            this.radComboBoxSummaries.ThemeName = "Material";
            // 
            // radButtonExport
            // 
            this.radButtonExport.Location = new System.Drawing.Point(706, 367);
            this.radButtonExport.Name = "radButtonExport";
            this.radButtonExport.Size = new System.Drawing.Size(110, 36);
            this.radButtonExport.TabIndex = 12;
            this.radButtonExport.Text = "Export";
            this.radButtonExport.ThemeName = "Material";
            this.radButtonExport.Click += new System.EventHandler(this.radButtonExport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 529);
            this.Controls.Add(this.radButtonExport);
            this.Controls.Add(this.radComboBoxSummaries);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radListView1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btn_PrintPreview);
            this.Controls.Add(this.btn_printSeting);
            this.Controls.Add(this.btn_print);
            this.Name = "Reports";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reports";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PrintPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_printSeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btn_print;
        private Telerik.WinControls.UI.RadButton btn_PrintPreview;
        private Telerik.WinControls.UI.RadButton btn_printSeting;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxSummaries;
        private Telerik.WinControls.UI.RadButton radButtonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}