
namespace ManagementStore.Form.Production
{
    partial class StockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOut));
            this.W = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateWH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ccbPrice = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupStockInItem = new DevExpress.XtraEditors.GroupControl();
            this.ccbWHSave = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInputProductId = new DevExpress.XtraEditors.TextEdit();
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
            this.WHName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemOutStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Brand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupStockInItem)).BeginInit();
            this.groupStockInItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // W
            // 
            this.W.ExpandCollapseItem.Id = 0;
            this.W.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.W.ExpandCollapseItem,
            this.btnSearch,
            this.btnUpdateWH,
            this.barButtonItem3,
            this.barSubItem2,
            this.btnClose,
            this.W.SearchEditItem});
            this.W.Location = new System.Drawing.Point(0, 0);
            this.W.MaxItemId = 6;
            this.W.Name = "W";
            this.W.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.W.Size = new System.Drawing.Size(1804, 181);
            this.W.StatusBar = this.ribbonStatusBar;
            // 
            // btnSearch
            // 
            this.btnSearch.Caption = "Search";
            this.btnSearch.Id = 1;
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearch_ItemClick);
            // 
            // btnUpdateWH
            // 
            this.btnUpdateWH.Caption = "Update Out Stock";
            this.btnUpdateWH.Id = 2;
            this.btnUpdateWH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateWH.ImageOptions.SvgImage")));
            this.btnUpdateWH.Name = "btnUpdateWH";
            this.btnUpdateWH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateWH_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Export Warehouse";
            this.barSubItem2.Id = 4;
            this.barSubItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem2.ImageOptions.SvgImage")));
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Id = 5;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Warehouse";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdateWH);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Task";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "System";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 742);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.W;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1804, 29);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 196);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1779, 533);
            this.splitContainerControl1.SplitterPosition = 466;
            this.splitContainerControl1.TabIndex = 3;
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
            this.groupStockInItem.Controls.Add(this.ccbWHSave);
            this.groupStockInItem.Controls.Add(this.labelControl2);
            this.groupStockInItem.Controls.Add(this.txtInputProductId);
            this.groupStockInItem.Controls.Add(this.labelControlWarehouse);
            this.groupStockInItem.Controls.Add(this.numericQuantity);
            this.groupStockInItem.Controls.Add(this.labelControlQuantity);
            this.groupStockInItem.Location = new System.Drawing.Point(18, 311);
            this.groupStockInItem.Name = "groupStockInItem";
            this.groupStockInItem.Size = new System.Drawing.Size(447, 222);
            this.groupStockInItem.TabIndex = 48;
            this.groupStockInItem.Text = "Stock Out Information";
            // 
            // ccbWHSave
            // 
            this.ccbWHSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbWHSave.FormattingEnabled = true;
            this.ccbWHSave.Location = new System.Drawing.Point(142, 162);
            this.ccbWHSave.Name = "ccbWHSave";
            this.ccbWHSave.Size = new System.Drawing.Size(273, 24);
            this.ccbWHSave.TabIndex = 37;
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
            this.numericQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(273, 23);
            this.numericQuantity.TabIndex = 32;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.gridControlProduct.MenuManager = this.W;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControlProduct.Size = new System.Drawing.Size(1298, 533);
            this.gridControlProduct.TabIndex = 0;
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduct});
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.Appearance.GroupRow.BackColor = System.Drawing.Color.LightGray;
            this.gridViewProduct.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewProduct.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.LightGray;
            this.gridViewProduct.AppearancePrint.GroupRow.Options.UseBackColor = true;
            this.gridViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PId,
            this.ProductName,
            this.WHName,
            this.TotalQuantity,
            this.ItemInStock,
            this.ItemOutStock,
            this.Price,
            this.Brand,
            this.CategoryId,
            this.CreatedBy,
            this.CreatedAt});
            this.gridViewProduct.GridControl = this.gridControlProduct;
            this.gridViewProduct.GroupCount = 1;
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.OptionsPrint.PrintPreview = true;
            this.gridViewProduct.OptionsView.ShowFooter = true;
            this.gridViewProduct.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.WHName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewProduct.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProduct_FocusedRowChanged);
            // 
            // PId
            // 
            this.PId.Caption = "Product ID";
            this.PId.FieldName = "PId";
            this.PId.MinWidth = 25;
            this.PId.Name = "PId";
            this.PId.OptionsColumn.ReadOnly = true;
            this.PId.Width = 61;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 0;
            this.ProductName.Width = 109;
            // 
            // WHName
            // 
            this.WHName.AppearanceCell.BackColor = System.Drawing.Color.LightGray;
            this.WHName.AppearanceCell.Options.UseBackColor = true;
            this.WHName.Caption = "Warehouse Name";
            this.WHName.FieldName = "WHName";
            this.WHName.MinWidth = 25;
            this.WHName.Name = "WHName";
            this.WHName.OptionsColumn.ReadOnly = true;
            this.WHName.Visible = true;
            this.WHName.VisibleIndex = 1;
            this.WHName.Width = 112;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.Caption = "Quantity";
            this.TotalQuantity.FieldName = "Total";
            this.TotalQuantity.MinWidth = 25;
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.OptionsColumn.ReadOnly = true;
            this.TotalQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:0.##}")});
            this.TotalQuantity.Visible = true;
            this.TotalQuantity.VisibleIndex = 1;
            this.TotalQuantity.Width = 70;
            // 
            // ItemInStock
            // 
            this.ItemInStock.Caption = "In Stock";
            this.ItemInStock.FieldName = "ItemInWH";
            this.ItemInStock.MinWidth = 25;
            this.ItemInStock.Name = "ItemInStock";
            this.ItemInStock.OptionsColumn.ReadOnly = true;
            this.ItemInStock.Visible = true;
            this.ItemInStock.VisibleIndex = 2;
            this.ItemInStock.Width = 59;
            // 
            // ItemOutStock
            // 
            this.ItemOutStock.Caption = "Out Stock";
            this.ItemOutStock.FieldName = "ItemOutWh";
            this.ItemOutStock.MinWidth = 25;
            this.ItemOutStock.Name = "ItemOutStock";
            this.ItemOutStock.OptionsColumn.ReadOnly = true;
            this.ItemOutStock.Visible = true;
            this.ItemOutStock.VisibleIndex = 3;
            this.ItemOutStock.Width = 70;
            // 
            // Price
            // 
            this.Price.Caption = "Price";
            this.Price.DisplayFormat.FormatString = "{0:#,0# VND}";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 25;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.ReadOnly = true;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 100;
            // 
            // Brand
            // 
            this.Brand.Caption = "Brand";
            this.Brand.FieldName = "Brand";
            this.Brand.MinWidth = 25;
            this.Brand.Name = "Brand";
            this.Brand.OptionsColumn.ReadOnly = true;
            this.Brand.Visible = true;
            this.Brand.VisibleIndex = 5;
            this.Brand.Width = 101;
            // 
            // CategoryId
            // 
            this.CategoryId.Caption = "Category";
            this.CategoryId.FieldName = "CategoryId";
            this.CategoryId.MinWidth = 25;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.OptionsColumn.ReadOnly = true;
            this.CategoryId.Visible = true;
            this.CategoryId.VisibleIndex = 6;
            this.CategoryId.Width = 90;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Caption = "Created By";
            this.CreatedBy.FieldName = "CreatedBy";
            this.CreatedBy.MinWidth = 25;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.OptionsColumn.ReadOnly = true;
            this.CreatedBy.Visible = true;
            this.CreatedBy.VisibleIndex = 7;
            this.CreatedBy.Width = 87;
            // 
            // CreatedAt
            // 
            this.CreatedAt.Caption = "Created At";
            this.CreatedAt.ColumnEdit = this.repositoryItemDateEdit1;
            this.CreatedAt.FieldName = "CreatedAt";
            this.CreatedAt.MinWidth = 25;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.OptionsColumn.ReadOnly = true;
            this.CreatedAt.Visible = true;
            this.CreatedAt.VisibleIndex = 8;
            this.CreatedAt.Width = 477;
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
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Task";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Export Warehouse";
            this.barSubItem1.Id = 5;
            this.barSubItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem1.ImageOptions.SvgImage")));
            this.barSubItem1.Name = "barSubItem1";
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 771);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.W);
            this.Name = "StockOut";
            this.Ribbon = this.W;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Stock Out";
            this.Load += new System.EventHandler(this.StockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.W)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl W;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ComboBox ccbPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupStockInItem;
        private System.Windows.Forms.ComboBox ccbWHSave;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtInputProductId;
        public DevExpress.XtraEditors.LabelControl labelControlWarehouse;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        public DevExpress.XtraEditors.LabelControl labelControlQuantity;
        private System.Windows.Forms.ComboBox ccbWarehouse;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox ccbCategory;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox ccbBrands;
        private DevExpress.XtraEditors.TextEdit txtInputPName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn PId;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn WHName;
        private DevExpress.XtraGrid.Columns.GridColumn TotalQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn ItemInStock;
        private DevExpress.XtraGrid.Columns.GridColumn ItemOutStock;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Brand;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnSearch;
        private DevExpress.XtraBars.BarButtonItem btnUpdateWH;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}