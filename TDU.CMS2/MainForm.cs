using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TDU.CMS2
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitBindings();
        }

        private void InitBindings()
        {
            //MessageBox.Show( System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last().ToString());
            var f = new Form1 {TopLevel = false, Dock = DockStyle.Fill};
            this.IsMdiContainer = true;
            documentManager1.MdiParent = this;
            tabbedView1.AddDocument(f);
            //throw new NotImplementedException();
        }
    }
}