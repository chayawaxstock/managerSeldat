namespace manageTask
{
    partial class RadForm2
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
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radCheckedListBox1 = new Telerik.WinControls.UI.RadCheckedListBox();
            this.radListView2 = new Telerik.WinControls.UI.RadListView();
            this.radCheckAllButton = new Telerik.WinControls.UI.RadButton();
            this.radCheckSelectedButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAllButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckSelectedButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            this.radListView1.ItemSpacing = -1;
            this.radListView1.Location = new System.Drawing.Point(25, 29);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(224, 496);
            this.radListView1.TabIndex = 0;
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // radCheckedListBox1
            // 
            this.radCheckedListBox1.Location = new System.Drawing.Point(28, 65);
            this.radCheckedListBox1.Name = "radCheckedListBox1";
            this.radCheckedListBox1.Size = new System.Drawing.Size(221, 457);
            this.radCheckedListBox1.TabIndex = 0;
            this.radCheckedListBox1.SelectedItemChanged += new System.EventHandler(this.radCheckedListBox1_SelectedItemsChanged);
            this.radCheckedListBox1.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radCheckedListBox1_ItemCheckedChanged);
            // 
            // radListView2
            // 
            this.radListView2.ItemSpacing = -1;
            this.radListView2.Location = new System.Drawing.Point(415, 150);
            this.radListView2.Name = "radListView2";
            this.radListView2.Size = new System.Drawing.Size(157, 341);
            this.radListView2.TabIndex = 1;
            this.radListView2.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // radCheckAllButton
            // 
            this.radCheckAllButton.Location = new System.Drawing.Point(25, 544);
            this.radCheckAllButton.Name = "radCheckAllButton";
            this.radCheckAllButton.Size = new System.Drawing.Size(110, 24);
            this.radCheckAllButton.TabIndex = 2;
            this.radCheckAllButton.Text = "checkall";
            this.radCheckAllButton.Click += new System.EventHandler(this.radCheckAllButton_Click);
            // 
            // radCheckSelectedButton
            // 
            this.radCheckSelectedButton.Location = new System.Drawing.Point(255, 544);
            this.radCheckSelectedButton.Name = "radCheckSelectedButton";
            this.radCheckSelectedButton.Size = new System.Drawing.Size(154, 24);
            this.radCheckSelectedButton.TabIndex = 3;
            this.radCheckSelectedButton.Text = "radCheckSelected";
            this.radCheckSelectedButton.Click += new System.EventHandler(this.radCheckSelectedButton_Click);
            // 
            // RadForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 610);
            this.Controls.Add(this.radCheckSelectedButton);
            this.Controls.Add(this.radCheckAllButton);
            this.Controls.Add(this.radListView2);
            this.Controls.Add(this.radCheckedListBox1);
            this.Controls.Add(this.radListView1);
            this.Name = "RadForm2";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm2";
            this.Load += new System.EventHandler(this.RadForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAllButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckSelectedButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadCheckedListBox radCheckedListBox1;
        private Telerik.WinControls.UI.RadListView radListView2;
        private Telerik.WinControls.UI.RadButton radCheckAllButton;
        private Telerik.WinControls.UI.RadButton radCheckSelectedButton;
    }
}
