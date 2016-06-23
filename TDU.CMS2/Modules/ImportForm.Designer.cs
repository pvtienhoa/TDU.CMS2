namespace TDU.CMS2.Modules
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ImportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.IssueButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ReIssueButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.FileFunctionPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RequestTypePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BasicFunctionPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.cardRequestListView1 = new TDU.CMS2.Views.CardRequestListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ImportButtonItem,
            this.barButtonItem2,
            this.barButtonItem3,
            this.IssueButtonItem,
            this.ReIssueButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(982, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ImportButtonItem
            // 
            this.ImportButtonItem.Caption = "From Excel";
            this.ImportButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ImportButtonItem.Glyph")));
            this.ImportButtonItem.Id = 1;
            this.ImportButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ImportButtonItem.LargeGlyph")));
            this.ImportButtonItem.Name = "ImportButtonItem";
            this.ImportButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ImportButtonItem_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Save";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Close";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // IssueButtonItem
            // 
            this.IssueButtonItem.Caption = "Issue";
            this.IssueButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("IssueButtonItem.Glyph")));
            this.IssueButtonItem.Id = 4;
            this.IssueButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("IssueButtonItem.LargeGlyph")));
            this.IssueButtonItem.Name = "IssueButtonItem";
            // 
            // ReIssueButtonItem
            // 
            this.ReIssueButtonItem.Caption = "Re-Issue";
            this.ReIssueButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ReIssueButtonItem.Glyph")));
            this.ReIssueButtonItem.Id = 5;
            this.ReIssueButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ReIssueButtonItem.LargeGlyph")));
            this.ReIssueButtonItem.Name = "ReIssueButtonItem";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.FileFunctionPageGroup,
            this.RequestTypePageGroup,
            this.BasicFunctionPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // FileFunctionPageGroup
            // 
            this.FileFunctionPageGroup.ItemLinks.Add(this.ImportButtonItem);
            this.FileFunctionPageGroup.Name = "FileFunctionPageGroup";
            this.FileFunctionPageGroup.Text = "Batch Import";
            // 
            // RequestTypePageGroup
            // 
            this.RequestTypePageGroup.ItemLinks.Add(this.IssueButtonItem);
            this.RequestTypePageGroup.ItemLinks.Add(this.ReIssueButtonItem);
            this.RequestTypePageGroup.Name = "RequestTypePageGroup";
            this.RequestTypePageGroup.Text = "Request Type";
            // 
            // BasicFunctionPageGroup
            // 
            this.BasicFunctionPageGroup.ItemLinks.Add(this.barButtonItem2);
            this.BasicFunctionPageGroup.ItemLinks.Add(this.barButtonItem3);
            this.BasicFunctionPageGroup.Name = "BasicFunctionPageGroup";
            this.BasicFunctionPageGroup.Text = "Basic";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 676);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(982, 27);
            // 
            // cardRequestListView1
            // 
            this.cardRequestListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRequestListView1.Location = new System.Drawing.Point(0, 141);
            this.cardRequestListView1.Mode = TDU.CMS2.Views.CardRequestListViewMode.Import;
            this.cardRequestListView1.Name = "cardRequestListView1";
            this.cardRequestListView1.Size = new System.Drawing.Size(982, 535);
            this.cardRequestListView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardRequestListView1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ImportForm";
            this.Size = new System.Drawing.Size(982, 703);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup FileFunctionPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BasicFunctionPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private Views.CardRequestListView cardRequestListView1;
        private DevExpress.XtraBars.BarButtonItem ImportButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem IssueButtonItem;
        private DevExpress.XtraBars.BarButtonItem ReIssueButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RequestTypePageGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
