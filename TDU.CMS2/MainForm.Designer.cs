namespace TDU.CMS2
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ReceiveBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.UserNameBarItem = new DevExpress.XtraBars.BarStaticItem();
            this.DepartmentBarItem = new DevExpress.XtraBars.BarStaticItem();
            this.DevideBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.InvidualBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.CompanyButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DestroyBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ImportBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ReceiveBarItem,
            this.UserNameBarItem,
            this.DepartmentBarItem,
            this.DevideBarItem,
            this.InvidualBarItem,
            this.CompanyButtonItem,
            this.DestroyBarItem,
            this.ImportBarItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.Size = new System.Drawing.Size(649, 130);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ReceiveBarItem
            // 
            this.ReceiveBarItem.Caption = "Receive";
            this.ReceiveBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ReceiveBarItem.Glyph")));
            this.ReceiveBarItem.Id = 1;
            this.ReceiveBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ReceiveBarItem.LargeGlyph")));
            this.ReceiveBarItem.Name = "ReceiveBarItem";
            this.ReceiveBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // UserNameBarItem
            // 
            this.UserNameBarItem.Caption = "UserName:";
            this.UserNameBarItem.Id = 3;
            this.UserNameBarItem.Name = "UserNameBarItem";
            this.UserNameBarItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // DepartmentBarItem
            // 
            this.DepartmentBarItem.Caption = "Department:";
            this.DepartmentBarItem.Id = 4;
            this.DepartmentBarItem.Name = "DepartmentBarItem";
            this.DepartmentBarItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // DevideBarItem
            // 
            this.DevideBarItem.Caption = "Devide";
            this.DevideBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DevideBarItem.Glyph")));
            this.DevideBarItem.Id = 8;
            this.DevideBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DevideBarItem.LargeGlyph")));
            this.DevideBarItem.Name = "DevideBarItem";
            // 
            // InvidualBarItem
            // 
            this.InvidualBarItem.Caption = "Invidual";
            this.InvidualBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("InvidualBarItem.Glyph")));
            this.InvidualBarItem.Id = 10;
            this.InvidualBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("InvidualBarItem.LargeGlyph")));
            this.InvidualBarItem.Name = "InvidualBarItem";
            // 
            // CompanyButtonItem
            // 
            this.CompanyButtonItem.Caption = "Company";
            this.CompanyButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("CompanyButtonItem.Glyph")));
            this.CompanyButtonItem.Id = 11;
            this.CompanyButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("CompanyButtonItem.LargeGlyph")));
            this.CompanyButtonItem.Name = "CompanyButtonItem";
            // 
            // DestroyBarItem
            // 
            this.DestroyBarItem.Caption = "Destroy";
            this.DestroyBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DestroyBarItem.Glyph")));
            this.DestroyBarItem.Id = 12;
            this.DestroyBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DestroyBarItem.LargeGlyph")));
            this.DestroyBarItem.Name = "DestroyBarItem";
            // 
            // ImportBarItem
            // 
            this.ImportBarItem.Caption = "Import";
            this.ImportBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ImportBarItem.Glyph")));
            this.ImportBarItem.Id = 13;
            this.ImportBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ImportBarItem.LargeGlyph")));
            this.ImportBarItem.Name = "ImportBarItem";
            this.ImportBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ImportBarItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.ImportBarItem);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Request";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ReceiveBarItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DevideBarItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Card and Pin";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.InvidualBarItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.CompanyButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Delivery";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.DestroyBarItem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Destruction";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.UserNameBarItem, true);
            this.ribbonStatusBar.ItemLinks.Add(this.DepartmentBarItem);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 485);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(649, 31);
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 516);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem ReceiveBarItem;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarStaticItem UserNameBarItem;
        private DevExpress.XtraBars.BarStaticItem DepartmentBarItem;
        private DevExpress.XtraBars.BarButtonItem DevideBarItem;
        private DevExpress.XtraBars.BarButtonItem InvidualBarItem;
        private DevExpress.XtraBars.BarButtonItem CompanyButtonItem;
        private DevExpress.XtraBars.BarButtonItem DestroyBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem ImportBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}