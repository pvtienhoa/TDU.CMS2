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
            this.rbiImport = new DevExpress.XtraBars.BarButtonItem();
            this.rbiIssue = new DevExpress.XtraBars.BarButtonItem();
            this.rbiReIssue = new DevExpress.XtraBars.BarButtonItem();
            this.rbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.rbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.rpiHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDataFile = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgRequestType = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBasicFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.cardRequestListView1 = new TDU.CMS2.Views.CardRequestListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.rbiImport,
            this.rbiIssue,
            this.rbiReIssue,
            this.rbiSave,
            this.rbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpiHome});
            this.ribbonControl1.Size = new System.Drawing.Size(929, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // rbiImport
            // 
            this.rbiImport.Caption = "From File";
            this.rbiImport.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiImport.Glyph")));
            this.rbiImport.Id = 1;
            this.rbiImport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiImport.LargeGlyph")));
            this.rbiImport.Name = "rbiImport";
            this.rbiImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbiImport_ItemClick);
            // 
            // rbiIssue
            // 
            this.rbiIssue.Caption = "Issue";
            this.rbiIssue.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiIssue.Glyph")));
            this.rbiIssue.Id = 2;
            this.rbiIssue.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiIssue.LargeGlyph")));
            this.rbiIssue.Name = "rbiIssue";
            this.rbiIssue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbiIssue_ItemClick);
            // 
            // rbiReIssue
            // 
            this.rbiReIssue.Caption = "Re-Issue";
            this.rbiReIssue.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiReIssue.Glyph")));
            this.rbiReIssue.Id = 3;
            this.rbiReIssue.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiReIssue.LargeGlyph")));
            this.rbiReIssue.Name = "rbiReIssue";
            this.rbiReIssue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbiReIssue_ItemClick);
            // 
            // rbiSave
            // 
            this.rbiSave.Caption = "Save";
            this.rbiSave.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiSave.Glyph")));
            this.rbiSave.Id = 4;
            this.rbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiSave.LargeGlyph")));
            this.rbiSave.Name = "rbiSave";
            this.rbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbiSave_ItemClick);
            // 
            // rbiClose
            // 
            this.rbiClose.Caption = "Close";
            this.rbiClose.Glyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.Glyph")));
            this.rbiClose.Id = 5;
            this.rbiClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("rbiClose.LargeGlyph")));
            this.rbiClose.Name = "rbiClose";
            // 
            // rpiHome
            // 
            this.rpiHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDataFile,
            this.rpgRequestType,
            this.rpgBasicFunction});
            this.rpiHome.Name = "rpiHome";
            this.rpiHome.Text = "Home";
            // 
            // rpgDataFile
            // 
            this.rpgDataFile.ItemLinks.Add(this.rbiImport);
            this.rpgDataFile.Name = "rpgDataFile";
            this.rpgDataFile.Text = "Data File";
            // 
            // rpgRequestType
            // 
            this.rpgRequestType.ItemLinks.Add(this.rbiIssue);
            this.rpgRequestType.ItemLinks.Add(this.rbiReIssue);
            this.rpgRequestType.Name = "rpgRequestType";
            this.rpgRequestType.Text = "Request Type";
            // 
            // rpgBasicFunction
            // 
            this.rpgBasicFunction.ItemLinks.Add(this.rbiSave);
            this.rpgBasicFunction.ItemLinks.Add(this.rbiClose);
            this.rpgBasicFunction.Name = "rpgBasicFunction";
            this.rpgBasicFunction.Text = "Basic Function";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 670);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(929, 27);
            // 
            // cardRequestListView1
            // 
            this.cardRequestListView1.CurrentUser = null;
            this.cardRequestListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRequestListView1.Location = new System.Drawing.Point(0, 141);
            this.cardRequestListView1.Mode = TDU.CMS2.Views.CardRequestListViewMode.Import;
            this.cardRequestListView1.Name = "cardRequestListView1";
            this.cardRequestListView1.Size = new System.Drawing.Size(929, 529);
            this.cardRequestListView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardRequestListView1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ImportForm";
            this.Size = new System.Drawing.Size(929, 697);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpiHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDataFile;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private Views.CardRequestListView cardRequestListView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRequestType;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBasicFunction;
        private DevExpress.XtraBars.BarButtonItem rbiImport;
        private DevExpress.XtraBars.BarButtonItem rbiIssue;
        private DevExpress.XtraBars.BarButtonItem rbiReIssue;
        private DevExpress.XtraBars.BarButtonItem rbiSave;
        private DevExpress.XtraBars.BarButtonItem rbiClose;
    }
}
