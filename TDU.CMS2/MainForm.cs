using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TDU.CMS2.DataBase;
using TDU.CMS2.DataModels;
using TDU.CMS2.Modules;

namespace TDU.CMS2
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public User CurrentUser { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            var currentUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
            if (!UserCheck(currentUserName))
            {
                MessageBox.Show("You do not have right to use this Application!");
                this.Close();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var c = new DevideSend();
            tabbedView1.AddDocument(c);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private bool UserCheck(string currentUserName)
        {
            using (var dbContext = new CMSDbContext())
            {
                CurrentUser = dbContext.Users.FirstOrDefault(u => u.UserName.Equals(currentUserName));

                if (CurrentUser == null)
                    return false;
                UserNameBarItem.Caption = "User Name: " + CurrentUser.EmployeeName;
                DepartmentBarItem.Caption = "Department: " + CurrentUser.Department.Name;
            }
            return true;
        }

        private void ImportBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var c = new ImportForm ();
            c.CurrentUser = CurrentUser;
            tabbedView1.AddDocument(c);
        }
    }
}