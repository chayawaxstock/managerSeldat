namespace manageTask
{
    partial class CompanyWorker
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new Telerik.WinControls.UI.RadMenu();
            this.setTimeToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.graphHoursStatusToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.cotactTheManagerToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.yourTasksToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.setTimeToolStripMenuItem,
            this.graphHoursStatusToolStripMenuItem,
            this.cotactTheManagerToolStripMenuItem,
            this.yourTasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1537, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setTimeToolStripMenuItem
            // 
            this.setTimeToolStripMenuItem.Name = "setTimeToolStripMenuItem";
            this.setTimeToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.setTimeToolStripMenuItem.Text = "Set time";
            this.setTimeToolStripMenuItem.Click += this.setTimeToolStripMenuItem_Click;
            // 
            // graphHoursStatusToolStripMenuItem
            // 
            this.graphHoursStatusToolStripMenuItem.Name = "graphHoursStatusToolStripMenuItem";
            this.graphHoursStatusToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.graphHoursStatusToolStripMenuItem.Text = "Graph hours status";
            this.graphHoursStatusToolStripMenuItem.Click += this.graphHoursStatusToolStripMenuItem_Click;
            // 
            // cotactTheManagerToolStripMenuItem
            // 
            this.cotactTheManagerToolStripMenuItem.Name = "cotactTheManagerToolStripMenuItem";
            this.cotactTheManagerToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cotactTheManagerToolStripMenuItem.Text = "Cotact the manager";
            this.cotactTheManagerToolStripMenuItem.Click += this.cotactTheManagerToolStripMenuItem_Click;
            // 
            // yourTasksToolStripMenuItem
            // 
            this.yourTasksToolStripMenuItem.Name = "yourTasksToolStripMenuItem";
            this.yourTasksToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.yourTasksToolStripMenuItem.Text = "Your tasks";
            this.yourTasksToolStripMenuItem.Click += this.yourTasksToolStripMenuItem_Click;
            // 
            // CompanyWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 875);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompanyWorker";
            this.Text = "CompanyWorker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadMenu menuStrip1;
        private Telerik.WinControls.UI.RadMenuItem setTimeToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem graphHoursStatusToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem cotactTheManagerToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem yourTasksToolStripMenuItem;
    }
}