using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace manageTask
{
    public partial class report2 : Telerik.WinControls.UI.RadForm
    {
        private string[] columnNames = new string[] { "numHour", "name", "dateBegin", "dateEnd", "isFinish", "customerName", "managerId", "userName", "numWorker", "sumHourWork", "numDaysStay",
          "presentDoing", "numHourDoDaysWorker" };
        private Type[] typeColums = new Type[] {typeof(int), typeof(string), typeof(DateTime), typeof(DateTime)
        ,typeof(bool),typeof(string),typeof(int),typeof(string),typeof(int),typeof(decimal),typeof(decimal),typeof(decimal),typeof(decimal)};
        public report2()
        {
            InitializeComponent();
           // this.radGridView1.ColumnCount = columnNames.Length;
            FillData();
        }

        private void radVirtualGrid1_Click(object sender, EventArgs e)
        {

        }

        DataTable dt = new DataTable();
        public void FillData()
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
               // dt.Columns.Add(columnNames[i], typeColums[i]);
            }

          
            this.radGridView1.DataSource = dt;
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.MasterTemplate.DataView.BypassFilter = true;
          //  this.radGridView1.FilterChanged += radGridView1_FilterChanged;
        }
    }
}
