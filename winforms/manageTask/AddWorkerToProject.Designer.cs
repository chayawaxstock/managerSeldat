namespace manageTask
{
    partial class AddWorkerToProject
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
            this.lbl_worker = new Telerik.WinControls.UI.RadLabel();
            this.lbl_project = new Telerik.WinControls.UI.RadLabel();
            this.btn_addProjectToWorker = new Telerik.WinControls.UI.RadButton();
            this.cmbx_projects = new System.Windows.Forms.ComboBox();
            this.checkedListBoxWorkers = new System.Windows.Forms.CheckedListBox();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addProjectToWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_worker
            // 
            this.lbl_worker.Location = new System.Drawing.Point(29, 59);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(53, 21);
            this.lbl_worker.TabIndex = 1;
            this.lbl_worker.Text = "Worker";
            this.lbl_worker.ThemeName = "MaterialTeal";
            // 
            // lbl_project
            // 
            this.lbl_project.Location = new System.Drawing.Point(29, 24);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(53, 21);
            this.lbl_project.TabIndex = 3;
            this.lbl_project.Text = "Project";
            this.lbl_project.ThemeName = "MaterialTeal";
            // 
            // btn_addProjectToWorker
            // 
            this.btn_addProjectToWorker.Location = new System.Drawing.Point(527, 416);
            this.btn_addProjectToWorker.Name = "btn_addProjectToWorker";
            this.btn_addProjectToWorker.Size = new System.Drawing.Size(236, 36);
            this.btn_addProjectToWorker.TabIndex = 4;
            this.btn_addProjectToWorker.Text = "Add the project to the worker";
            this.btn_addProjectToWorker.ThemeName = "MaterialTeal";
            this.btn_addProjectToWorker.Visible = false;
            // 
            // cmbx_projects
            // 
            this.cmbx_projects.FormattingEnabled = true;
            this.cmbx_projects.Location = new System.Drawing.Point(90, 24);
            this.cmbx_projects.Name = "cmbx_projects";
            this.cmbx_projects.Size = new System.Drawing.Size(121, 21);
            this.cmbx_projects.TabIndex = 6;
            // 
            // checkedListBoxWorkers
            // 
            this.checkedListBoxWorkers.FormattingEnabled = true;
            this.checkedListBoxWorkers.Location = new System.Drawing.Point(29, 83);
            this.checkedListBoxWorkers.Name = "checkedListBoxWorkers";
            this.checkedListBoxWorkers.Size = new System.Drawing.Size(182, 327);
            this.checkedListBoxWorkers.TabIndex = 7;
            // 
            // AddWorkerToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 477);
            this.Controls.Add(this.checkedListBoxWorkers);
            this.Controls.Add(this.cmbx_projects);
            this.Controls.Add(this.btn_addProjectToWorker);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.lbl_worker);
            this.Name = "AddWorkerToProject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Add a worker to a project";
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.AddWorkerToProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addProjectToWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel lbl_worker;
        private Telerik.WinControls.UI.RadLabel lbl_project;
        private Telerik.WinControls.UI.RadButton btn_addProjectToWorker;
        private System.Windows.Forms.ComboBox cmbx_projects;
        private System.Windows.Forms.CheckedListBox checkedListBoxWorkers;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}