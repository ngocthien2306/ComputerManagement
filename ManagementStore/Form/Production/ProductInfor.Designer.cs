
namespace ManagementStore.Form
{
    partial class ProductInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfor));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtn_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Profile = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonTheme = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barBtnCreateProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSearchProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSaveProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSaveSale = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteSale = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintSale = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_Product = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_System = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupEmployee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlProductInfor = new DevExpress.XtraEditors.GroupControl();
            this.labelDescription = new DevExpress.XtraEditors.LabelControl();
            this.labelPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelCategory = new DevExpress.XtraEditors.LabelControl();
            this.labelProductName = new DevExpress.XtraEditors.LabelControl();
            this.txtInputUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtInputEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtInputLastname = new DevExpress.XtraEditors.TextEdit();
            this.txtInputFirstname = new DevExpress.XtraEditors.TextEdit();
            this.btnProductInforUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.picProductImage = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProductInfor)).BeginInit();
            this.groupControlProductInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(819, 147);
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
            // barBtnCreateProduct
            // 
            this.barBtnCreateProduct.Caption = "Create";
            this.barBtnCreateProduct.Id = 4;
            this.barBtnCreateProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnCreateProduct.ImageOptions.SvgImage")));
            this.barBtnCreateProduct.Name = "barBtnCreateProduct";
            // 
            // barBtnEditProduct
            // 
            this.barBtnEditProduct.Caption = "Edit";
            this.barBtnEditProduct.Id = 5;
            this.barBtnEditProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnEditProduct.ImageOptions.SvgImage")));
            this.barBtnEditProduct.Name = "barBtnEditProduct";
            // 
            // barBtnDeleteProduct
            // 
            this.barBtnDeleteProduct.Caption = "Delete";
            this.barBtnDeleteProduct.Id = 6;
            this.barBtnDeleteProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDeleteProduct.ImageOptions.SvgImage")));
            this.barBtnDeleteProduct.Name = "barBtnDeleteProduct";
            // 
            // barBtnSearchProduct
            // 
            this.barBtnSearchProduct.Caption = "Search";
            this.barBtnSearchProduct.Id = 7;
            this.barBtnSearchProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSearchProduct.ImageOptions.SvgImage")));
            this.barBtnSearchProduct.Name = "barBtnSearchProduct";
            // 
            // barBtnSaveProduct
            // 
            this.barBtnSaveProduct.Caption = "Save";
            this.barBtnSaveProduct.Id = 8;
            this.barBtnSaveProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSaveProduct.ImageOptions.SvgImage")));
            this.barBtnSaveProduct.Name = "barBtnSaveProduct";
            // 
            // barBtnPrintProduct
            // 
            this.barBtnPrintProduct.Caption = "Print";
            this.barBtnPrintProduct.Id = 9;
            this.barBtnPrintProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnPrintProduct.ImageOptions.SvgImage")));
            this.barBtnPrintProduct.Name = "barBtnPrintProduct";
            // 
            // barBtnSaveSale
            // 
            this.barBtnSaveSale.Caption = "Save";
            this.barBtnSaveSale.Id = 10;
            this.barBtnSaveSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSaveSale.ImageOptions.SvgImage")));
            this.barBtnSaveSale.Name = "barBtnSaveSale";
            // 
            // barBtnDeleteSale
            // 
            this.barBtnDeleteSale.Caption = "Delete";
            this.barBtnDeleteSale.Id = 11;
            this.barBtnDeleteSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDeleteSale.ImageOptions.SvgImage")));
            this.barBtnDeleteSale.Name = "barBtnDeleteSale";
            // 
            // barBtnPrintSale
            // 
            this.barBtnPrintSale.Caption = "Print";
            this.barBtnPrintSale.Id = 12;
            this.barBtnPrintSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnPrintSale.ImageOptions.SvgImage")));
            this.barBtnPrintSale.Name = "barBtnPrintSale";
            // 
            // ribbonPage_Product
            // 
            this.ribbonPage_Product.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_System,
            this.ribbonGroupEmployee,
            this.ribbonPageGroup2});
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 598);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(819, 23);
            // 
            // groupControlProductInfor
            // 
            this.groupControlProductInfor.Controls.Add(this.labelDescription);
            this.groupControlProductInfor.Controls.Add(this.labelPrice);
            this.groupControlProductInfor.Controls.Add(this.labelCategory);
            this.groupControlProductInfor.Controls.Add(this.labelProductName);
            this.groupControlProductInfor.Controls.Add(this.txtInputUsername);
            this.groupControlProductInfor.Controls.Add(this.txtInputEmail);
            this.groupControlProductInfor.Controls.Add(this.txtInputLastname);
            this.groupControlProductInfor.Controls.Add(this.txtInputFirstname);
            this.groupControlProductInfor.Controls.Add(this.btnProductInforUpdate);
            this.groupControlProductInfor.Controls.Add(this.picProductImage);
            this.groupControlProductInfor.Location = new System.Drawing.Point(12, 160);
            this.groupControlProductInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlProductInfor.Name = "groupControlProductInfor";
            this.groupControlProductInfor.Size = new System.Drawing.Size(795, 434);
            this.groupControlProductInfor.TabIndex = 22;
            this.groupControlProductInfor.Text = "Product Information";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(320, 176);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 29;
            this.labelDescription.Text = "Description:";
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(320, 133);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(27, 13);
            this.labelPrice.TabIndex = 28;
            this.labelPrice.Text = "Price:";
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(320, 83);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 27;
            this.labelCategory.Text = "Category:";
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(320, 32);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(71, 13);
            this.labelProductName.TabIndex = 26;
            this.labelProductName.Text = "Product Name:";
            // 
            // txtInputUsername
            // 
            this.txtInputUsername.Location = new System.Drawing.Point(409, 174);
            this.txtInputUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Size = new System.Drawing.Size(336, 20);
            this.txtInputUsername.TabIndex = 24;
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.Location = new System.Drawing.Point(409, 131);
            this.txtInputEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.Size = new System.Drawing.Size(336, 20);
            this.txtInputEmail.TabIndex = 23;
            // 
            // txtInputLastname
            // 
            this.txtInputLastname.Location = new System.Drawing.Point(409, 80);
            this.txtInputLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputLastname.Name = "txtInputLastname";
            this.txtInputLastname.Size = new System.Drawing.Size(336, 20);
            this.txtInputLastname.TabIndex = 22;
            // 
            // txtInputFirstname
            // 
            this.txtInputFirstname.Location = new System.Drawing.Point(409, 30);
            this.txtInputFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputFirstname.Name = "txtInputFirstname";
            this.txtInputFirstname.Size = new System.Drawing.Size(336, 20);
            this.txtInputFirstname.TabIndex = 21;
            this.txtInputFirstname.ToolTip = "Enter firstname";
            // 
            // btnProductInforUpdate
            // 
            this.btnProductInforUpdate.Location = new System.Drawing.Point(320, 309);
            this.btnProductInforUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductInforUpdate.Name = "btnProductInforUpdate";
            this.btnProductInforUpdate.Size = new System.Drawing.Size(93, 37);
            this.btnProductInforUpdate.TabIndex = 19;
            this.btnProductInforUpdate.Text = "Update";
            // 
            // picProductImage
            // 
            this.picProductImage.Location = new System.Drawing.Point(20, 33);
            this.picProductImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.picProductImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.picProductImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picProductImage.Size = new System.Drawing.Size(270, 159);
            this.picProductImage.TabIndex = 18;
            // 
            // Productions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 621);
            this.Controls.Add(this.groupControlProductInfor);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Productions";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProductInfor)).EndInit();
            this.groupControlProductInfor.ResumeLayout(false);
            this.groupControlProductInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage.Properties)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraBars.BarButtonItem barBtnCreateProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnEditProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnDeleteProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnSearchProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnSaveProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnPrintProduct;
        public DevExpress.XtraBars.BarButtonItem barBtnSaveSale;
        public DevExpress.XtraBars.BarButtonItem barBtnDeleteSale;
        public DevExpress.XtraBars.BarButtonItem barBtnPrintSale;
        private DevExpress.XtraEditors.GroupControl groupControlProductInfor;
        private DevExpress.XtraEditors.SimpleButton btnProductInforUpdate;
        private DevExpress.XtraEditors.PictureEdit picProductImage;
        private DevExpress.XtraEditors.LabelControl labelDescription;
        private DevExpress.XtraEditors.LabelControl labelPrice;
        private DevExpress.XtraEditors.LabelControl labelCategory;
        private DevExpress.XtraEditors.LabelControl labelProductName;
        private DevExpress.XtraEditors.TextEdit txtInputUsername;
        private DevExpress.XtraEditors.TextEdit txtInputEmail;
        private DevExpress.XtraEditors.TextEdit txtInputLastname;
        private DevExpress.XtraEditors.TextEdit txtInputFirstname;
    }
}