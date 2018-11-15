using manageTask.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace manageTask
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            this.radCheckedListBox1.DataSource = this.CreatePhoneBookEntries();
            this.radCheckedListBox1.VisualItemFormatting += radCheckedListBox1_VisualItemFormatting;
            ListViewDetailColumn nameColumn = new ListViewDetailColumn("Name");
            nameColumn.Width = 30;
            this.radCheckedListBox2.Columns.Add(nameColumn);
            ListViewDetailColumn phoneColumn = new ListViewDetailColumn("Phone");
            phoneColumn.Width = 30;
            this.radCheckedListBox2.Columns.Add(phoneColumn);
            this.radButton1.Click += radButtonAddToContacts_Click;
            this.radButton2.Click += radButtonRemoveFromContacts_Click;

        }

        private void radCheckedListBox1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            BaseListViewVisualItem item = e.VisualItem;
            PhonebookEntry entry = item.Data.Value as PhonebookEntry;
            item.Image = entry.Image.GetThumbnailImage(80,80, null, IntPtr.Zero);
           
            item.Text = "<html>" +
          "<span style=\"font-size:14pt;font-family:Segoe UI;\">" + entry.FirstName + " " + entry.LastName + "</span>" +
          "<br><br><span style=\"font-size:10.5pt;\"><b>Address:</b> <i>" + entry.Address + "</i>" +
          "<br><b>Phone:</b> <i>" + entry.PhoneNumber + "</i></span>";
            if (item.Children.Count > 0)
            {
                ListViewItemCheckbox checkBoxItem = item.Children[0] as ListViewItemCheckbox;
                checkBoxItem.Margin = new Padding(1);
            }
        }

        public class PhonebookEntry
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public Image Image { get; set; }
        }


        private IEnumerable<PhonebookEntry> CreatePhoneBookEntries()
        {
            List<PhonebookEntry> entries = new List<PhonebookEntry>()
    {
        new PhonebookEntry() { FirstName = "Anne", LastName = "Dodsworth", PhoneNumber = "(71) 555-4444", Address = "7 Houndstooth Rd.", Image = Resources.photo_2018_10_29_00_31_38},
        new PhonebookEntry() { FirstName = "Laura", LastName = "Callahan", PhoneNumber = "(206) 555-1189", Address = "4726 - 11th Ave. N.E.", Image = Resources.photo_2018_10_29_00_31_38 },
        new PhonebookEntry() { FirstName = "Robert", LastName = "King", PhoneNumber = "(71) 555-5598", Address = "Edgeham Hollow Winchester Way", Image = Resources.photo_2018_10_29_00_31_38 },
        new PhonebookEntry() { FirstName = "Michael", LastName = "Suyama", PhoneNumber = "(71) 555-7773", Address = "Coventry House Miner Rd.", Image = Resources.photo_2018_10_29_00_31_38},
        new PhonebookEntry() { FirstName = "Steven", LastName = "Buchanan", PhoneNumber = "(71) 555-4848", Address = "14 Garrett Hill", Image = Resources.photo_2018_10_29_00_31_38 },
        new PhonebookEntry() { FirstName = "Margaret", LastName = "Peacock", PhoneNumber = "(206) 555-8122", Address = "4110 Old Redmond Rd.", Image = Resources.photo_2018_10_29_00_31_38 },
        new PhonebookEntry() { FirstName = "Janet", LastName = "Leverling", PhoneNumber = "(206) 555-3412", Address = "722 Moss Bay Blvd.", Image = Resources.photo_2018_10_29_00_31_38 },
        new PhonebookEntry() { FirstName = "Andrew", LastName = "Fuller", PhoneNumber = "(206) 555-9482", Address = "908 W. Capital Way", Image = Resources.photo_2018_10_29_00_31_38 },
        new PhonebookEntry() { FirstName = "Nancy", LastName = "Davolio", PhoneNumber = "(206) 555-9857", Address = "507 - 20th Ave. E. Apt. 2A", Image = Resources.photo_2018_10_29_00_31_38 }
    };
            return entries;
        }


        void radButtonAddToContacts_Click(object sender, EventArgs e)
        {
            foreach (ListViewDataItem item in this.radCheckedListBox1.CheckedItems)
            {
                ListViewDataItem contactItem = new ListViewDataItem();
                this.radCheckedListBox2.Items.Add(contactItem);
                //here you can add logic to avoid duplicating contacts
                PhonebookEntry entry = item.Value as PhonebookEntry;
                contactItem["Name"] = entry.FirstName + " " + entry.LastName;
                contactItem["Phone"] = entry.PhoneNumber;
            }
        }
        void radButtonRemoveFromContacts_Click(object sender, EventArgs e)
        {
            while (this.radCheckedListBox2.CheckedItems.Count > 0)
            {
                this.radCheckedListBox2.Items.Remove(this.radCheckedListBox2.CheckedItems[0]);
            }
        }


    }
}


