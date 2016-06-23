using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TDU.CMS2.DataModels;
using TDU.CMS2.Views;

namespace TDU.CMS2.Modules
{
    public partial class ImportForm : DevExpress.XtraEditors.XtraUserControl
    {
        public User CurrentUser { get; set; }
        public ImportForm()
        {
            InitializeComponent();
            InitBindings();
        }

        private void InitBindings()
        {
            cardRequestListView1.CurrentUser = CurrentUser;
            cardRequestListView1.Start(CardRequestListViewMode.Import);
        }

        private void ImportButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cardRequestListView1.LoadRequestsFromFile(openFileDialog1.FileName);
            }
        }
    }
}
