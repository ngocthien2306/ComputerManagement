
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
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCreate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSearchProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStatisticProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserMgt = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdminPage = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatisticEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_Product = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_System = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupEmployee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
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
            this.skinRibbonTheme});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_Product});
            this.ribbon.Size = new System.Drawing.Size(1022, 147);
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
            this.barBtn_Profile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Profile_ItemClick);
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
            this.ribbonPageGroup1});
            this.ribbonPage_Product.Name = "ribbonPage_Product";
            this.ribbonPage_Product.Text = "Product";
            // 
            // ribbonPageGroup_System
            // 
            this.ribbonPageGroup_System.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup_System.ItemLinks.Add(this.barBtn_Profile);
            this.ribbonPageGroup_System.ItemLinks.Add(this.barBtn_Logout);
            this.ribbonPageGroup_System.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup_System.Name = "ribbonPageGroup_System";
            this.ribbonPageGroup_System.Text = "Systems";
            // 
            // ribbonPageGroupProduct
            // 
            this.ribbonPageGroupProduct.ItemLinks.Add(this.barBtnProduct);
            this.ribbonPageGroupProduct.ItemLinks.Add(this.barBtnSearchProduct);
            this.ribbonPageGroupProduct.ItemLinks.Add(this.barBtnStatisticProduct);
            this.ribbonPageGroupProduct.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroupProduct.Name = "ribbonPageGroupProduct";
            this.ribbonPageGroupProduct.Text = "Product Task";
            // 
            // ribbonPageGroupExportData
            // 
            this.ribbonPageGroupExportData.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroupExportData.Name = "ribbonPageGroupExportData";
            this.ribbonPageGroupExportData.Text = "Export Data";
            // 
            // ribbonPageGroupNotify
            // 
            this.ribbonPageGroupNotify.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroupNotify.Name = "ribbonPageGroupNotify";
            this.ribbonPageGroupNotify.Text = "Notify";
            // 
            // ribbonPageEmployee
            // 
            this.ribbonPageEmployee.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupEmployee,
            this.ribbonPageStatistic});
            this.ribbonPageEmployee.Name = "ribbonPageEmployee";
            this.ribbonPageEmployee.Text = "Employee";
            // 
            // ribbonPageGroupEmployee
            // 
            this.ribbonPageGroupEmployee.ItemLinks.Add(this.btnUserMgt);
            this.ribbonPageGroupEmployee.ItemLinks.Add(this.btnAdminPage);
            this.ribbonPageGroupEmployee.Name = "ribbonPageGroupEmployee";
            this.ribbonPageGroupEmployee.Text = "Management";
            // 
            // ribbonPageStatistic
            // 
            this.ribbonPageStatistic.ItemLinks.Add(this.btnStatisticEmployee);
            this.ribbonPageStatistic.Name = "ribbonPageStatistic";
            this.ribbonPageStatistic.Text = "Statistics";
            // 
            this.ribbonGroupEmployee.Name = "ribbonGroupEmployee";
            this.ribbonGroupEmployee.Text = "Employee";
            // 
            // ribbonPageGroup1
            // 
            // ribbonPageGroupTheme
            // 
            this.ribbonPageGroupTheme.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroupTheme.Name = "ribbonPageGroupTheme";
            this.ribbonPageGroupTheme.Text = "Theme";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 518);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1022, 23);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 541);
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
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageTheme;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupTheme;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barBtnCreate;
        private DevExpress.XtraBars.BarButtonItem barBtnSearchProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnStatisticProduct;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupEmployee;
    }
}