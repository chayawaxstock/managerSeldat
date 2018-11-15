namespace manageTask
{
    partial class RadForm1
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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radDataFilter1 = new Telerik.WinControls.UI.RadDataFilter();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.Location = new System.Drawing.Point(175, 199);
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.Size = new System.Drawing.Size(259, 115);
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.Click += new System.EventHandler(this.radVirtualGrid1_Click);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea2;
            this.radChartView1.Location = new System.Drawing.Point(161, 12);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(273, 171);
            this.radChartView1.TabIndex = 1;
            // 
            // radDataFilter1
            // 
            this.radDataFilter1.Location = new System.Drawing.Point(13, 24);
            this.radDataFilter1.Name = "radDataFilter1";
            this.radDataFilter1.Size = new System.Drawing.Size(142, 103);
            this.radDataFilter1.TabIndex = 2;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 387);
            this.Controls.Add(this.radDataFilter1);
            this.Controls.Add(this.radChartView1);
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadDataFilter radDataFilter1;
    }
}
