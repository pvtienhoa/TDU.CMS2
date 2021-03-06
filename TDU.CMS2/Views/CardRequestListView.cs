﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TDU.CMS2.DataBase;
using TDU.CMS2.DataModels;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using TDU.CMS2.Modules;

namespace TDU.CMS2.Views
{
    public enum CardRequestListViewMode
    {
        Import,
        Devide,
        Receive,
        Company,
        Destroy
    }

    public partial class CardRequestListView : DevExpress.XtraEditors.XtraUserControl
    {
        public List<CardRequest> CardRequests { get; private set; }
        public CardRequestListViewMode Mode { get; set; }
        public CMSDbContext DbContext { get; private set; }
        public User CurrentUser { get; set; }

        public CardRequestListView()
        {
            InitializeComponent();
            //        // This line of code is generated by Data Source Configuration Wizard
            //        // Instantiate a new DBContext
            //        TDU.CMS2.DataBase.CMSDbContext dbContext = new TDU.CMS2.DataBase.CMSDbContext();
            //        // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            //        dbContext.CardRequests.LoadAsync().ContinueWith(loadTask =>
            //        {
            //// Bind data to control when loading complete
            //cardRequestsBindingSource.DataSource = dbContext.CardRequests.Local.ToBindingList();
            //        }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void Start(CardRequestListViewMode mode)
        {
            Mode = mode;
            InitBindings();
        }

        public void InitBindings()
        {
            DbContext = new CMSDbContext();
            LoadRequestsToList(Mode);
            cardRequestsBindingSource.DataSource = CardRequests;
            //throw new NotImplementedException();
        }

        private void LoadRequestsToList(CardRequestListViewMode mode)
        {
            switch (mode)
            {
                case CardRequestListViewMode.Import:
                    CardRequests = new List<CardRequest>();
                    //throw new NotImplementedException();
                    break;
                case CardRequestListViewMode.Devide:
                    throw new NotImplementedException();
                //break;
                case CardRequestListViewMode.Receive:
                    var requests = from r in DbContext.CardRequests
                        where
                            r.State.Equals(RequestState.Producing) ||
                            (r.State.Equals(RequestState.Devided) &&
                             (r.CardLocation.Equals(CurrentUser.DeptID) || r.PinLocation.Equals(CurrentUser.DeptID)))
                        select r;
                    CardRequests = requests.ToList();
                    break;
                //throw new NotImplementedException();
                //break;
                case CardRequestListViewMode.Destroy:
                    throw new NotImplementedException();
                //break;

                default:
                    throw new NotImplementedException();
                //break;
            }
        }

        public void LoadRequestsFromFile(string filePath)
        {
            CardRequests = DataFileHandler.ReadEssemcardFile(filePath);
            foreach (var cardRequest in CardRequests)
            {
                cardRequest.PinLocation = 0;
                cardRequest.CardLocation = 0;
                cardRequest.EmployeeName = CurrentUser.EmployeeName;
                cardRequest.State = RequestState.Producing;
                cardRequest.Type = RequestType.Issue;
            }
            Reload();
        }

        public void Reload()
        {
            cardRequestsBindingSource.DataSource = CardRequests;
        }

        public void RefreshData()
        {
            gridView1.RefreshData();
        }

        public void Save()
        {
            gridView1.PostEditor();
            DbContext.SaveChanges();
            gridView1.RefreshData();
        }

        public void AddListToDatabase()
        {
            if (CardRequests == null)
            {
                return;
            }
            DbContext.CardRequests.AddOrUpdate(CardRequests.ToArray());
        }

        public void SetAllRequestToType(RequestType type)
        {
            if (CardRequests == null)
            {
                return;
            }
            SetSelectedRowCellValue("Type", type);
            //foreach (var request in CardRequests)
            //{
            //    request.Type = type;
            //}
            //Reload();
        }

        public void FilterByDate(DateTime filterDate)
        {
            CardRequests =
                DbContext.CardRequests.Where(request => request.RequestDate.Date.Equals(filterDate.Date)).ToList();
            Reload();
        }

        public void SendCard(bool cardSend, bool pinSend)
        {
            var rowHandlesToCheck = gridView1.GetSelectedRows();
            foreach (var i in rowHandlesToCheck)
            {
                if (gridView1.GetRowCellValue(i, "DevideValue") == null)
                {
                    gridView1.UnselectRow(i);
                }
            }
            if (cardSend)
            {
                SetSelectedRowCellValue("CardLocation", "DevideValue");
            }
            if (pinSend)
            {
                SetSelectedRowCellValue("PinLocation", "DevideValue");
            }
            foreach (var i in rowHandlesToCheck)
            {
                var pinLoc = gridView1.GetRowCellValue(i, "Pinlocation");
                var cardLoc = gridView1.GetRowCellValue(i, "Cardlocation");
                if ((long) pinLoc == 2 || (long) cardLoc == 2) continue;
                gridView1.SetRowCellValue(i, "State",
                    gridView1.GetRowCellValue(i, "DevideValue") == (object) DepartmentType.MainDept
                        ? RequestState.InDept
                        : RequestState.Devided);
            }
        }

        private void SetSelectedRowCellValue(string fieldName, object value)
        {
            var selectedRowHandles = gridView1.GetSelectedRows();
            foreach (var i in selectedRowHandles)
            {
                gridView1.SetRowCellValue(i, fieldName, value);
            }
        }

        private void SetSelectedRowCellValue(string fieldName, string fieldNameToCopy)
        {
            var selectedRowHandles = gridView1.GetSelectedRows();
            foreach (var i in selectedRowHandles)
            {
                gridView1.SetRowCellValue(i, fieldName, gridView1.GetRowCellValue(i, fieldNameToCopy));
            }
        }
    }
}