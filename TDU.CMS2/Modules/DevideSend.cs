using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TDU.CMS2.Views;

namespace TDU.CMS2.Modules
{
    public partial class DevideSend : DevExpress.XtraEditors.XtraUserControl
    {
        public DevideSend()
        {
            InitializeComponent();
            InitBindings();

            
        }

        private void InitBindings()
        {
            rdeRequestDate.EditValue = DateTime.Now;
            


            cardRequestListView1.Mode = CardRequestListViewMode.Devide;
            cardRequestListView1.InitBindings();
        }

        private void rdeRequestDate_EditValueChanged(object sender, EventArgs e)
        {
            cardRequestListView1.FilterByDate((DateTime)rdeRequestDate.EditValue);
        }
        
        private void rcbCardType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void rbiSend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void rleCardType_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
