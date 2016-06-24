namespace TDU.CMS2.Modules
{
    partial class DevideSend
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevideSend));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rbiDevide = new DevExpress.XtraBars.BarButtonItem();
            this.rdeRequestDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rbiDevideHelper = new DevExpress.XtraBars.BarButtonItem();
            this.rbiSend = new DevExpress.XtraBars.BarButtonItem();
            this.rbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.rcbPin = new DevExpress.XtraBars.BarCheckItem();
            this.rcbCard = new DevExpress.XtraBars.BarCheckItem();
            this.rleCardType = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rpiHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDevide = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgFilter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSend = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBasicFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.cardRequestListView1 = new TDU.CMS2.Views.CardRequestListView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.rbiDevide,
            this.rdeRequestDate,
            this.rbiDevideHelper,
            this.rbiSend,
            this.rbiClose,
            this.barButtonGroup1,
            this.rcbPin,
            this.rcbCard,
            this.rleCardType});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpiHome});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemLookUpEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(733, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // rbiDevide
            // 
            this.rbiDevide.Caption = "Devide";
            this.rbiDevide.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiDevide.Glyph")));
            this.rbiDevide.Id = 1;
            this.rbiDevide.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiDevide.LargeGlyph")));
            this.rbiDevide.Name = "rbiDevide";
            // 
            // rdeRequestDate
            // 
            this.rdeRequestDate.Caption = "Request Date";
            this.rdeRequestDate.Edit = this.repositoryItemDateEdit1;
            this.rdeRequestDate.EditWidth = 100;
            this.rdeRequestDate.Glyph = ((System.Drawing.Image)(resources.GetObject("rdeRequestDate.Glyph")));
            this.rdeRequestDate.Id = 2;
            this.rdeRequestDate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rdeRequestDate.LargeGlyph")));
            this.rdeRequestDate.Name = "rdeRequestDate";
            this.rdeRequestDate.EditValueChanged += new System.EventHandler(this.rdeRequestDate_EditValueChanged);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // rbiDevideHelper
            // 
            this.rbiDevideHelper.Caption = "Devide Helper";
            this.rbiDevideHelper.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiDevideHelper.Glyph")));
            this.rbiDevideHelper.Id = 3;
            this.rbiDevideHelper.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiDevideHelper.LargeGlyph")));
            this.rbiDevideHelper.Name = "rbiDevideHelper";
            // 
            // rbiSend
            // 
            this.rbiSend.Caption = "Send";
            this.rbiSend.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiSend.Glyph")));
            this.rbiSend.Id = 4;
            this.rbiSend.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiSend.LargeGlyph")));
            this.rbiSend.Name = "rbiSend";
            this.rbiSend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbiSend_ItemClick);
            // 
            // rbiClose
            // 
            this.rbiClose.Caption = "Close";
            this.rbiClose.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.Glyph")));
            this.rbiClose.Id = 5;
            this.rbiClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.LargeGlyph")));
            this.rbiClose.Name = "rbiClose";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 6;
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.OptionsMultiColumn.ShowItemText = DevExpress.Utils.DefaultBoolean.True;
            // 
            // rcbPin
            // 
            this.rcbPin.BindableChecked = true;
            this.rcbPin.Caption = "Pin";
            this.rcbPin.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.rcbPin.Checked = true;
            this.rcbPin.Id = 8;
            this.rcbPin.Name = "rcbPin";
            // 
            // rcbCard
            // 
            this.rcbCard.BindableChecked = true;
            this.rcbCard.Caption = "Card";
            this.rcbCard.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.rcbCard.Checked = true;
            this.rcbCard.Id = 10;
            this.rcbCard.Name = "rcbCard";
            // 
            // rleCardType
            // 
            this.rleCardType.Caption = "Card Type";
            this.rleCardType.Edit = this.repositoryItemLookUpEdit1;
            this.rleCardType.EditWidth = 116;
            this.rleCardType.Glyph = ((System.Drawing.Image)(resources.GetObject("rleCardType.Glyph")));
            this.rleCardType.Id = 13;
            this.rleCardType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rleCardType.LargeGlyph")));
            this.rleCardType.Name = "rleCardType";
            this.rleCardType.EditValueChanged += new System.EventHandler(this.rleCardType_EditValueChanged);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // rpiHome
            // 
            this.rpiHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDevide,
            this.rpgFilter,
            this.rpgSend,
            this.rpgBasicFunction});
            this.rpiHome.Name = "rpiHome";
            this.rpiHome.Text = "Home";
            // 
            // rpgDevide
            // 
            this.rpgDevide.ItemLinks.Add(this.rbiDevide);
            this.rpgDevide.ItemLinks.Add(this.rbiDevideHelper);
            this.rpgDevide.Name = "rpgDevide";
            this.rpgDevide.Text = "Devide";
            // 
            // rpgFilter
            // 
            this.rpgFilter.ItemLinks.Add(this.rdeRequestDate);
            this.rpgFilter.ItemLinks.Add(this.rleCardType);
            this.rpgFilter.Name = "rpgFilter";
            this.rpgFilter.Text = "Data Filter";
            // 
            // rpgSend
            // 
            this.rpgSend.AllowTextClipping = false;
            this.rpgSend.ItemLinks.Add(this.rbiSend);
            this.rpgSend.ItemLinks.Add(this.rcbCard);
            this.rpgSend.ItemLinks.Add(this.rcbPin);
            this.rpgSend.Name = "rpgSend";
            this.rpgSend.Text = "Send";
            // 
            // rpgBasicFunction
            // 
            this.rpgBasicFunction.ItemLinks.Add(this.rbiClose);
            this.rpgBasicFunction.Name = "rpgBasicFunction";
            this.rpgBasicFunction.Text = "Basic Function";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 491);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(733, 27);
            // 
            // cardRequestListView1
            // 
            this.cardRequestListView1.CurrentUser = null;
            this.cardRequestListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRequestListView1.Location = new System.Drawing.Point(0, 141);
            this.cardRequestListView1.Mode = TDU.CMS2.Views.CardRequestListViewMode.Import;
            this.cardRequestListView1.Name = "cardRequestListView1";
            this.cardRequestListView1.Size = new System.Drawing.Size(733, 377);
            this.cardRequestListView1.TabIndex = 1;
            // 
            // DevideSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.cardRequestListView1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DevideSend";
            this.Size = new System.Drawing.Size(733, 518);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpiHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDevide;
        private Views.CardRequestListView cardRequestListView1;
        private DevExpress.XtraBars.BarButtonItem rbiDevide;
        private DevExpress.XtraBars.BarEditItem rdeRequestDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFilter;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSend;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBasicFunction;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem rbiDevideHelper;
        private DevExpress.XtraBars.BarButtonItem rbiSend;
        private DevExpress.XtraBars.BarButtonItem rbiClose;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarCheckItem rcbPin;
        private DevExpress.XtraBars.BarCheckItem rcbCard;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarEditItem rleCardType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
