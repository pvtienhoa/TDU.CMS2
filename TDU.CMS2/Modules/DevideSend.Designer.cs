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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevideSend));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rbiDevide = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDevide = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgFilter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cardRequestListView1 = new TDU.CMS2.Views.CardRequestListView();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.rpgSend = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBasicFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbiDevideHelper = new DevExpress.XtraBars.BarButtonItem();
            this.rbiSend = new DevExpress.XtraBars.BarButtonItem();
            this.rbiClose = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.rbiDevide,
            this.barEditItem1,
            this.rbiDevideHelper,
            this.rbiSend,
            this.rbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
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
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Request Date";
            this.barEditItem1.Edit = this.repositoryItemDateEdit1;
            this.barEditItem1.EditWidth = 100;
            this.barEditItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barEditItem1.Glyph")));
            this.barEditItem1.Id = 2;
            this.barEditItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barEditItem1.LargeGlyph")));
            this.barEditItem1.Name = "barEditItem1";
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDevide,
            this.rpgFilter,
            this.rpgSend,
            this.rpgBasicFunction});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
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
            this.rpgFilter.ItemLinks.Add(this.barEditItem1);
            this.rpgFilter.Name = "rpgFilter";
            this.rpgFilter.Text = "Data Filter";
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
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 491);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(733, 27);
            // 
            // rpgSend
            // 
            this.rpgSend.ItemLinks.Add(this.rbiSend);
            this.rpgSend.Name = "rpgSend";
            this.rpgSend.Text = "Send";
            // 
            // rpgBasicFunction
            // 
            this.rpgBasicFunction.ItemLinks.Add(this.rbiClose);
            this.rpgBasicFunction.Name = "rpgBasicFunction";
            this.rpgBasicFunction.Text = "Basic Function";
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
            // 
            // rbiClose
            // 
            this.rbiClose.Caption = "Close";
            this.rbiClose.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.Glyph")));
            this.rbiClose.Id = 5;
            this.rbiClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.LargeGlyph")));
            this.rbiClose.Name = "rbiClose";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDevide;
        private Views.CardRequestListView cardRequestListView1;
        private DevExpress.XtraBars.BarButtonItem rbiDevide;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFilter;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSend;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBasicFunction;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem rbiDevideHelper;
        private DevExpress.XtraBars.BarButtonItem rbiSend;
        private DevExpress.XtraBars.BarButtonItem rbiClose;
    }
}
