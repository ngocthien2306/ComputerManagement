
namespace ManagementStore.Form.Production
{
    partial class StockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateWH = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageStockIn = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ccbPrice = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupStockInItem = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInputProductId = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControlWarehouse = new DevExpress.XtraEditors.LabelControl();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelControlQuantity = new DevExpress.XtraEditors.LabelControl();
            this.ccbWarehouse = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ccbCategory = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ccbBrands = new System.Windows.Forms.ComboBox();
            this.txtInputPName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupStockInItem)).BeginInit();
            this.groupStockInItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSearch,
            this.btnUpdateWH});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageStockIn});
            this.ribbon.Size = new System.Drawing.Size(1484, 181);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSearch
            // 
            this.btnSearch.Caption = "Search";
            this.btnSearch.Id = 1;
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Name = "btnSearch";
            // 
            // btnUpdateWH
            // 
            this.btnUpdateWH.Caption = "Update Warehouse";
            this.btnUpdateWH.Id = 2;
            this.btnUpdateWH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateWH.ImageOptions.SvgImage")));
            this.btnUpdateWH.Name = "btnUpdateWH";
            // 
            // ribbonPageStockIn
            // 
            this.ribbonPageStockIn.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageStockIn.Name = "ribbonPageStockIn";
            this.ribbonPageStockIn.Text = "Warehouse";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdateWH);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Task";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 734);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1484, 29);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 187);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ccbPrice);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupStockInItem);
            this.splitContainerControl1.Panel1.Controls.Add(this.ccbWarehouse);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.ccbCategory);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.ccbBrands);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtInputPName);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlProduct);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1469, 533);
            this.splitContainerControl1.SplitterPosition = 466;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // ccbPrice
            // 
            this.ccbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ccbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbPrice.FormattingEnabled = true;
            this.ccbPrice.Location = new System.Drawing.Point(160, 254);
            this.ccbPrice.Name = "ccbPrice";
            this.ccbPrice.Size = new System.Drawing.Size(273, 24);
            this.ccbPrice.TabIndex = 50;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(36, 257);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 16);
            this.labelControl5.TabIndex = 49;
            this.labelControl5.Text = "Price:";
            // 
            // groupStockInItem
            // 
            this.groupStockInItem.Controls.Add(this.labelControl2);
            this.groupStockInItem.Controls.Add(this.txtInputProductId);
            this.groupStockInItem.Controls.Add(this.comboBox1);
            this.groupStockInItem.Controls.Add(this.labelControlWarehouse);
            this.groupStockInItem.Controls.Add(this.numericQuantity);
            this.groupStockInItem.Controls.Add(this.labelControlQuantity);
            this.groupStockInItem.Location = new System.Drawing.Point(18, 311);
            this.groupStockInItem.Name = "groupStockInItem";
            this.groupStockInItem.Size = new System.Drawing.Size(447, 214);
            this.groupStockInItem.TabIndex = 48;
            this.groupStockInItem.Text = "Stock In Information";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Product ID:";
            // 
            // txtInputProductId
            // 
            this.txtInputProductId.Location = new System.Drawing.Point(142, 48);
            this.txtInputProductId.Name = "txtInputProductId";
            this.txtInputProductId.Size = new System.Drawing.Size(273, 22);
            this.txtInputProductId.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // labelControlWarehouse
            // 
            this.labelControlWarehouse.Location = new System.Drawing.Point(18, 165);
            this.labelControlWarehouse.Name = "labelControlWarehouse";
            this.labelControlWarehouse.Size = new System.Drawing.Size(70, 16);
            this.labelControlWarehouse.TabIndex = 33;
            this.labelControlWarehouse.Text = "Warehouse:";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(142, 105);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(273, 23);
            this.numericQuantity.TabIndex = 32;
            // 
            // labelControlQuantity
            // 
            this.labelControlQuantity.Location = new System.Drawing.Point(18, 107);
            this.labelControlQuantity.Name = "labelControlQuantity";
            this.labelControlQuantity.Size = new System.Drawing.Size(56, 16);
            this.labelControlQuantity.TabIndex = 31;
            this.labelControlQuantity.Text = "Quantity: ";
            // 
            // ccbWarehouse
            // 
            this.ccbWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ccbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbWarehouse.FormattingEnabled = true;
            this.ccbWarehouse.Location = new System.Drawing.Point(160, 110);
            this.ccbWarehouse.Name = "ccbWarehouse";
            this.ccbWarehouse.Size = new System.Drawing.Size(273, 24);
            this.ccbWarehouse.TabIndex = 47;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(36, 118);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(70, 16);
            this.labelControl9.TabIndex = 46;
            this.labelControl9.Text = "Warehouse:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(140, 28);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Option search";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(36, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Category:";
            // 
            // ccbCategory
            // 
            this.ccbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbCategory.FormattingEnabled = true;
            this.ccbCategory.Location = new System.Drawing.Point(160, 204);
            this.ccbCategory.Name = "ccbCategory";
            this.ccbCategory.Size = new System.Drawing.Size(273, 24);
            this.ccbCategory.TabIndex = 40;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 16);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Brands:";
            // 
            // ccbBrands
            // 
            this.ccbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbBrands.FormattingEnabled = true;
            this.ccbBrands.Location = new System.Drawing.Point(160, 155);
            this.ccbBrands.Name = "ccbBrands";
            this.ccbBrands.Size = new System.Drawing.Size(273, 24);
            this.ccbBrands.TabIndex = 38;
            // 
            // txtInputPName
            // 
            this.txtInputPName.Location = new System.Drawing.Point(160, 66);
            this.txtInputPName.Name = "txtInputPName";
            this.txtInputPName.Size = new System.Drawing.Size(273, 22);
            this.txtInputPName.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 16);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Product Name:";
            // 
            // gridControlProduct
            // 
            this.gridControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProduct.Location = new System.Drawing.Point(0, 0);
            this.gridControlProduct.MainView = this.gridViewProduct;
            this.gridControlProduct.MenuManager = this.ribbon;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.Size = new System.Drawing.Size(988, 533);
            this.gridControlProduct.TabIndex = 0;
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduct});
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PId,
            this.ProductName});
            this.gridViewProduct.GridControl = this.gridControlProduct;
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewProduct_RowClick);
            this.gridViewProduct.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProduct_FocusedRowChanged);
            // 
            // PId
            // 
            this.PId.Caption = "Product ID";
            this.PId.FieldName = "PId";
            this.PId.MinWidth = 25;
            this.PId.Name = "PId";
            this.PId.OptionsColumn.ReadOnly = true;
            this.PId.Visible = true;
            this.PId.VisibleIndex = 0;
            this.PId.Width = 94;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.ReadOnly = true;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 94;
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 763);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "StockIn";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.StockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupStockInItem)).EndInit();
            this.groupStockInItem.ResumeLayout(false);
            this.groupStockInItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageStockIn;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupStockInItem;
        private System.Windows.Forms.ComboBox ccbWarehouse;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox ccbCategory;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox ccbBrands;
        private DevExpress.XtraEditors.TextEdit txtInputPName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnSearch;
        private DevExpress.XtraBars.BarButtonItem btnUpdateWH;
        public System.Windows.Forms.ComboBox comboBox1;
        public DevExpress.XtraEditors.LabelControl labelControlWarehouse;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        public DevExpress.XtraEditors.LabelControl labelControlQuantity;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtInputProductId;
        private System.Windows.Forms.ComboBox ccbPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn PId;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
    }
}