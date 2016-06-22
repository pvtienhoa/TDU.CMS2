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

            cardRequestListView1.Mode = CardRequestListViewMode.Receive;
            cardRequestListView1.InitBindings();
        }
    }
}
