namespace manageTask
{
    partial class b
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new Telerik.WinControls.UI.RadMenu();
            this.addProjectToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.managmentWorkersToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.editWorkersDetailsToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.setPermissionToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.deleteWorkerToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.addANewWorkerToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.addWorkerToProjectToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.addWorkerToATeamLeaderToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.reportsToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.addProjectToolStripMenuItem,
            this.managmentWorkersToolStripMenuItem,
            this.addWorkerToATeamLeaderToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 20);
            this.menuStrip1.TabIndex = 5;
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Text = "Add project";
            // 
            // managmentWorkersToolStripMenuItem
            // 
            this.managmentWorkersToolStripMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.editWorkersDetailsToolStripMenuItem,
            this.setPermissionToolStripMenuItem,
            this.deleteWorkerToolStripMenuItem,
            this.addANewWorkerToolStripMenuItem,
            this.addWorkerToProjectToolStripMenuItem});
            this.managmentWorkersToolStripMenuItem.Name = "managmentWorkersToolStripMenuItem";
            this.managmentWorkersToolStripMenuItem.Text = "Managment workers";
            // 
            // editWorkersDetailsToolStripMenuItem
            // 
            this.editWorkersDetailsToolStripMenuItem.Name = "editWorkersDetailsToolStripMenuItem";
            this.editWorkersDetailsToolStripMenuItem.Text = "Edit worker\'s details";
            // 
            // setPermissionToolStripMenuItem
            // 
            this.setPermissionToolStripMenuItem.Name = "setPermissionToolStripMenuItem";
            this.setPermissionToolStripMenuItem.Text = "Set permission";
            // 
            // deleteWorkerToolStripMenuItem
            // 
            this.deleteWorkerToolStripMenuItem.Name = "deleteWorkerToolStripMenuItem";
            this.deleteWorkerToolStripMenuItem.Text = "Delete worker";
            // 
            // addANewWorkerToolStripMenuItem
            // 
            this.addANewWorkerToolStripMenuItem.Name = "addANewWorkerToolStripMenuItem";
            this.addANewWorkerToolStripMenuItem.Text = "Add a new worker";
            // 
            // addWorkerToProjectToolStripMenuItem
            // 
            this.addWorkerToProjectToolStripMenuItem.Name = "addWorkerToProjectToolStripMenuItem";
            this.addWorkerToProjectToolStripMenuItem.Text = "Add worker to project";
            // 
            // addWorkerToATeamLeaderToolStripMenuItem
            // 
            this.addWorkerToATeamLeaderToolStripMenuItem.Name = "addWorkerToATeamLeaderToolStripMenuItem";
            this.addWorkerToATeamLeaderToolStripMenuItem.Text = "Add worker to a team leader";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 684);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "b";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Telerik.WinControls.UI.RadMenu menuStrip1;
        private Telerik.WinControls.UI.RadMenuItem addProjectToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem managmentWorkersToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem editWorkersDetailsToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem setPermissionToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem deleteWorkerToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem addANewWorkerToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem addWorkerToProjectToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem addWorkerToATeamLeaderToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem reportsToolStripMenuItem;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}