
namespace ManagementStore.Form
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtn_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Profile = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonTheme = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage_Product = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_System = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupEmployee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridGroupRole = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridUserRole = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barBtnCreateProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSearchProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSaveProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSaveSale = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteSale = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintSale = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barBtn_Logout,
            this.barBtn_Profile,
            this.skinRibbonTheme,
            this.barBtnCreateProduct,
            this.barBtnEditProduct,
            this.barBtnDeleteProduct,
            this.barBtnSearchProduct,
            this.barBtnSaveProduct,
            this.barBtnPrintProduct,
            this.barBtnSaveSale,
            this.barBtnDeleteSale,
            this.barBtnPrintSale});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_Product});
            this.ribbon.Size = new System.Drawing.Size(1446, 181);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtn_Logout
            // 
            this.barBtn_Logout.Caption = "Logout";
            this.barBtn_Logout.Hint = "Logout account";
            this.barBtn_Logout.Id = 1;
            this.barBtn_Logout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Logout.ImageOptions.SvgImage")));
            this.barBtn_Logout.Name = "barBtn_Logout";
            this.barBtn_Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Logout_ItemClick);
            // 
            // barBtn_Profile
            // 
            this.barBtn_Profile.Caption = "Profile";
            this.barBtn_Profile.Hint = "Edit profile";
            this.barBtn_Profile.Id = 2;
            this.barBtn_Profile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Profile.ImageOptions.SvgImage")));
            this.barBtn_Profile.Name = "barBtn_Profile";
            // 
            // skinRibbonTheme
            // 
            this.skinRibbonTheme.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonTheme.Id = 3;
            this.skinRibbonTheme.Name = "skinRibbonTheme";
            // 
            // ribbonPage_Product
            // 
            this.ribbonPage_Product.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_System,
            this.ribbonGroupEmployee,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage_Product.Name = "ribbonPage_Product";
            this.ribbonPage_Product.Text = "Home";
            // 
            // ribbonPageGroup_System
            // 
            this.ribbonPageGroup_System.ItemLinks.Add(this.barBtn_Logout);
            this.ribbonPageGroup_System.ItemLinks.Add(this.barBtn_Profile);
            this.ribbonPageGroup_System.Name = "ribbonPageGroup_System";
            this.ribbonPageGroup_System.Text = "Systems";
            // 
            // ribbonGroupEmployee
            // 
            this.ribbonGroupEmployee.ItemLinks.Add(this.barBtnSaveSale);
            this.ribbonGroupEmployee.ItemLinks.Add(this.barBtnDeleteSale);
            this.ribbonGroupEmployee.ItemLinks.Add(this.barBtnPrintSale);
            this.ribbonGroupEmployee.Name = "ribbonGroupEmployee";
            this.ribbonGroupEmployee.Text = "Sales Project";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonTheme);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Theme";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 735);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1446, 29);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCreateProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnEditProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDeleteProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnSearchProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnSaveProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnPrintProduct);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Product Management";
            // 
            // gridGroupRole
            // 
            this.gridGroupRole.Location = new System.Drawing.Point(12, 186);
            this.gridGroupRole.MainView = this.gridView1;
            this.gridGroupRole.MenuManager = this.ribbon;
            this.gridGroupRole.Name = "gridGroupRole";
            this.gridGroupRole.Size = new System.Drawing.Size(1422, 263);
            this.gridGroupRole.TabIndex = 2;
            this.gridGroupRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridGroupRole;
            this.gridView1.Name = "gridView1";
            // 
            // gridUserRole
            // 
            this.gridUserRole.Location = new System.Drawing.Point(12, 455);
            this.gridUserRole.MainView = this.gridView2;
            this.gridUserRole.MenuManager = this.ribbon;
            this.gridUserRole.Name = "gridUserRole";
            this.gridUserRole.Size = new System.Drawing.Size(1422, 275);
            this.gridUserRole.TabIndex = 3;
            this.gridUserRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridUserRole;
            this.gridView2.Name = "gridView2";
            // 
            // barBtnCreateProduct
            // 
            this.barBtnCreateProduct.Caption = "Create";
            this.barBtnCreateProduct.Id = 4;
            this.barBtnCreateProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barBtnCreateProduct.Name = "barBtnCreateProduct";
            // 
            // barBtnEditProduct
            // 
            this.barBtnEditProduct.Caption = "Edit";
            this.barBtnEditProduct.Id = 5;
            this.barBtnEditProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barBtnEditProduct.Name = "barBtnEditProduct";
            // 
            // barBtnDeleteProduct
            // 
            this.barBtnDeleteProduct.Caption = "Delete";
            this.barBtnDeleteProduct.Id = 6;
            this.barBtnDeleteProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barBtnDeleteProduct.Name = "barBtnDeleteProduct";
            // 
            // barBtnSearchProduct
            // 
            this.barBtnSearchProduct.Caption = "Search";
            this.barBtnSearchProduct.Id = 7;
            this.barBtnSearchProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barBtnSearchProduct.Name = "barBtnSearchProduct";
            // 
            // barBtnSaveProduct
            // 
            this.barBtnSaveProduct.Caption = "Save";
            this.barBtnSaveProduct.Id = 8;
            this.barBtnSaveProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barBtnSaveProduct.Name = "barBtnSaveProduct";
            // 
            // barBtnPrintProduct
            // 
            this.barBtnPrintProduct.Caption = "Print";
            this.barBtnPrintProduct.Id = 9;
            this.barBtnPrintProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barBtnPrintProduct.Name = "barBtnPrintProduct";
            // 
            // barBtnSaveSale
            // 
            this.barBtnSaveSale.Caption = "Save";
            this.barBtnSaveSale.Id = 10;
            this.barBtnSaveSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage1")));
            this.barBtnSaveSale.Name = "barBtnSaveSale";
            // 
            // barBtnDeleteSale
            // 
            this.barBtnDeleteSale.Caption = "Delete";
            this.barBtnDeleteSale.Id = 11;
            this.barBtnDeleteSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage1")));
            this.barBtnDeleteSale.Name = "barBtnDeleteSale";
            // 
            // barBtnPrintSale
            // 
            this.barBtnPrintSale.Caption = "Print";
            this.barBtnPrintSale.Id = 12;
            this.barBtnPrintSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage1")));
            this.barBtnPrintSale.Name = "barBtnPrintSale";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 764);
            this.Controls.Add(this.gridUserRole);
            this.Controls.Add(this.gridGroupRole);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Product;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_System;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtn_Logout;
        private DevExpress.XtraBars.BarButtonItem barBtn_Profile;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonTheme;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.GridControl gridUserRole;
        public DevExpress.XtraGrid.GridControl gridGroupRole;
        public DevExpress.XtraBars.BarButtonItem barBtnCreateProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnEditProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnDeleteProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnSearchProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnSaveProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnPrintProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnSaveSale;
        public DevExpress.XtraBars.BarButtonItem barBtnDeleteSale;
        public DevExpress.XtraBars.BarButtonItem barBtnPrintSale;
    }
}