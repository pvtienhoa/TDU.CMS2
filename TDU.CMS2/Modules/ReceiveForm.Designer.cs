namespace TDU.CMS2.Modules
{
    partial class ReceiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rbiReceive = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cardRequestListView1 = new TDU.CMS2.Views.CardRequestListView();
            this.rpgDate = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBasicFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbiReturn = new DevExpress.XtraBars.BarButtonItem();
            this.rbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.rdeStartDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rdeEndDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rbiQuery = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.rbiReceive,
            this.rbiReturn,
            this.rbiClose,
            this.rdeStartDate,
            this.rdeEndDate,
            this.rbiQuery});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.Size = new System.Drawing.Size(974, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // rbiReceive
            // 
            this.rbiReceive.Caption = "Receive";
            this.rbiReceive.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiReceive.Glyph")));
            this.rbiReceive.Id = 1;
            this.rbiReceive.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiReceive.LargeGlyph")));
            this.rbiReceive.Name = "rbiReceive";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rpgDate,
            this.rpgBasicFunction});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.rbiReceive);
            this.ribbonPageGroup1.ItemLinks.Add(this.rbiReturn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Receive and Return";
            // 
            // cardRequestListView1
            // 
            this.cardRequestListView1.CurrentUser = null;
            this.cardRequestListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRequestListView1.Location = new System.Drawing.Point(0, 141);
            this.cardRequestListView1.Mode = TDU.CMS2.Views.CardRequestListViewMode.Import;
            this.cardRequestListView1.Name = "cardRequestListView1";
            this.cardRequestListView1.Size = new System.Drawing.Size(974, 625);
            this.cardRequestListView1.TabIndex = 1;
            // 
            // rpgDate
            // 
            this.rpgDate.ItemLinks.Add(this.rdeStartDate);
            this.rpgDate.ItemLinks.Add(this.rdeEndDate);
            this.rpgDate.Name = "rpgDate";
            this.rpgDate.Text = "Date";
            // 
            // rpgBasicFunction
            // 
            this.rpgBasicFunction.ItemLinks.Add(this.rbiQuery);
            this.rpgBasicFunction.ItemLinks.Add(this.rbiClose);
            this.rpgBasicFunction.Name = "rpgBasicFunction";
            this.rpgBasicFunction.Text = "rpgBasicFunction";
            // 
            // rbiReturn
            // 
            this.rbiReturn.Caption = "Return";
            this.rbiReturn.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiReturn.Glyph")));
            this.rbiReturn.Id = 2;
            this.rbiReturn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiReturn.LargeGlyph")));
            this.rbiReturn.Name = "rbiReturn";
            // 
            // rbiClose
            // 
            this.rbiClose.Caption = "Close";
            this.rbiClose.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.Glyph")));
            this.rbiClose.Id = 3;
            this.rbiClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.LargeGlyph")));
            this.rbiClose.Name = "rbiClose";
            // 
            // rdeStartDate
            // 
            this.rdeStartDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.rdeStartDate.Caption = "From";
            this.rdeStartDate.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rdeStartDate.Edit = this.repositoryItemDateEdit2;
            this.rdeStartDate.EditWidth = 100;
            this.rdeStartDate.Glyph = ((System.Drawing.Image)(resources.GetObject("rdeStartDate.Glyph")));
            this.rdeStartDate.Id = 5;
            this.rdeStartDate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rdeStartDate.LargeGlyph")));
            this.rdeStartDate.Name = "rdeStartDate";
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
            // rdeEndDate
            // 
            this.rdeEndDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.rdeEndDate.Caption = "To    ";
            this.rdeEndDate.Edit = this.repositoryItemDateEdit2;
            this.rdeEndDate.EditWidth = 100;
            this.rdeEndDate.Glyph = ((System.Drawing.Image)(resources.GetObject("rdeEndDate.Glyph")));
            this.rdeEndDate.Id = 6;
            this.rdeEndDate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rdeEndDate.LargeGlyph")));
            this.rdeEndDate.Name = "rdeEndDate";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.repositoryItemDateEdit2.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 0, 0);
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // rbiQuery
            // 
            this.rbiQuery.Caption = "Query";
            this.rbiQuery.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiQuery.Glyph")));
            this.rbiQuery.Id = 7;
            this.rbiQuery.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiQuery.LargeGlyph")));
            this.rbiQuery.Name = "rbiQuery";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 739);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(974, 27);
            // 
            // ReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.cardRequestListView1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ReceiveForm";
            this.Size = new System.Drawing.Size(974, 766);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem rbiReceive;
        private Views.CardRequestListView cardRequestListView1;
        private DevExpress.XtraBars.BarButtonItem rbiReturn;
        private DevExpress.XtraBars.BarButtonItem rbiClose;
        private DevExpress.XtraBars.BarEditItem rdeStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem rdeEndDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBasicFunction;
        private DevExpress.XtraBars.BarButtonItem rbiQuery;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    }
}
