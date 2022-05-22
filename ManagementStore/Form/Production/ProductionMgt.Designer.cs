﻿
namespace ManagementStore.Form.Production
{
    partial class ProductionMgt
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionMgt));
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.cardViewProduct = new DevExpress.XtraGrid.Views.Card.CardView();
            this.PId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Brand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Picture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPictureEditProduct = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.Mainboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CPU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VGA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCreate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExport = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnStockOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnStockIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnHistoryStock = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ccbWarehouse = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtInputProductId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ccbPrice = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ccbRams = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ccbCategory = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ccbBrands = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInputPName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProviderProductID = new System.Windows.Forms.ErrorProvider(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.DetailHeight = 284;
            this.gridViewProduct.GridControl = this.gridControlProduct;
            this.gridViewProduct.Name = "gridViewProduct";
            // 
            // gridControlProduct
            // 
            this.gridControlProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.LevelTemplate = this.gridViewProduct;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlProduct.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlProduct.Location = new System.Drawing.Point(3, 5);
            this.gridControlProduct.MainView = this.cardViewProduct;
            this.gridControlProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProduct.MenuManager = this.ribbonControl1;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.Size = new System.Drawing.Size(987, 583);
            this.gridControlProduct.TabIndex = 0;
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardViewProduct,
            this.gridViewProduct});
            // 
            // cardViewProduct
            // 
            this.cardViewProduct.Appearance.FieldCaption.BackColor = System.Drawing.Color.White;
            this.cardViewProduct.Appearance.FieldCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.cardViewProduct.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardViewProduct.Appearance.FieldCaption.Options.UseForeColor = true;
            this.cardViewProduct.CardWidth = 231;
            this.cardViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PId,
            this.ProductName,
            this.Price,
            this.Brand,
            this.Category,
            this.Picture,
            this.Mainboard,
            this.WarehouseName,
            this.Quantity,
            this.CPU,
            this.VGA,
            this.RAM,
            this.SSD,
            this.CreatedBy,
            this.CreatedAt});
            this.cardViewProduct.DetailHeight = 284;
            this.cardViewProduct.GridControl = this.gridControlProduct;
            this.cardViewProduct.MaximumCardColumns = 4;
            this.cardViewProduct.MaximumCardRows = 10;
            this.cardViewProduct.Name = "cardViewProduct";
            this.cardViewProduct.OptionsPrint.AutoHorzWidth = true;
            this.cardViewProduct.OptionsPrint.PrintCardCaption = false;
            this.cardViewProduct.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.cardViewProduct_FocusedRowChanged);
            this.cardViewProduct.Click += new System.EventHandler(this.cardViewProduct_Click);
            // 
            // PId
            // 
            this.PId.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.PId.AppearanceCell.Options.UseForeColor = true;
            this.PId.Caption = "Product ID";
            this.PId.FieldName = "PId";
            this.PId.MinWidth = 21;
            this.PId.Name = "PId";
            this.PId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.PId.Visible = true;
            this.PId.VisibleIndex = 0;
            this.PId.Width = 60;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 21;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.ReadOnly = true;
            this.ProductName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 91;
            // 
            // Price
            // 
            this.Price.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.Price.AppearanceCell.Options.UseForeColor = true;
            this.Price.Caption = "Price";
            this.Price.DisplayFormat.FormatString = "{0:#,0# VND}";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 21;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.ReadOnly = true;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 91;
            // 
            // Brand
            // 
            this.Brand.Caption = "Brand";
            this.Brand.FieldName = "Brand";
            this.Brand.MinWidth = 21;
            this.Brand.Name = "Brand";
            this.Brand.OptionsColumn.ReadOnly = true;
            this.Brand.Visible = true;
            this.Brand.VisibleIndex = 3;
            this.Brand.Width = 91;
            // 
            // Category
            // 
            this.Category.Caption = "Category";
            this.Category.FieldName = "CategoryId";
            this.Category.MinWidth = 21;
            this.Category.Name = "Category";
            this.Category.OptionsColumn.ReadOnly = true;
            this.Category.Visible = true;
            this.Category.VisibleIndex = 4;
            this.Category.Width = 94;
            // 
            // Picture
            // 
            this.Picture.Caption = "Picture";
            this.Picture.ColumnEdit = this.itemPictureEditProduct;
            this.Picture.FieldName = "Picture";
            this.Picture.MinWidth = 21;
            this.Picture.Name = "Picture";
            this.Picture.OptionsColumn.ReadOnly = true;
            this.Picture.Visible = true;
            this.Picture.VisibleIndex = 5;
            this.Picture.Width = 65;
            // 
            // itemPictureEditProduct
            // 
            this.itemPictureEditProduct.CustomHeight = 50;
            this.itemPictureEditProduct.Name = "itemPictureEditProduct";
            this.itemPictureEditProduct.ReadOnly = true;
            this.itemPictureEditProduct.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // Mainboard
            // 
            this.Mainboard.Caption = "Mainboard";
            this.Mainboard.FieldName = "Mainboard";
            this.Mainboard.MinWidth = 21;
            this.Mainboard.Name = "Mainboard";
            this.Mainboard.OptionsColumn.ReadOnly = true;
            this.Mainboard.Width = 93;
            // 
            // WarehouseName
            // 
            this.WarehouseName.Caption = "WH Name";
            this.WarehouseName.FieldName = "WHName";
            this.WarehouseName.MinWidth = 21;
            this.WarehouseName.Name = "WarehouseName";
            this.WarehouseName.Visible = true;
            this.WarehouseName.VisibleIndex = 11;
            this.WarehouseName.Width = 81;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Total";
            this.Quantity.MinWidth = 21;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 12;
            this.Quantity.Width = 81;
            // 
            // CPU
            // 
            this.CPU.Caption = "CPU";
            this.CPU.FieldName = "CPU";
            this.CPU.MinWidth = 21;
            this.CPU.Name = "CPU";
            this.CPU.OptionsColumn.ReadOnly = true;
            this.CPU.Visible = true;
            this.CPU.VisibleIndex = 6;
            this.CPU.Width = 99;
            // 
            // VGA
            // 
            this.VGA.Caption = "VGA";
            this.VGA.FieldName = "VGA";
            this.VGA.MinWidth = 21;
            this.VGA.Name = "VGA";
            this.VGA.OptionsColumn.ReadOnly = true;
            this.VGA.Visible = true;
            this.VGA.VisibleIndex = 7;
            this.VGA.Width = 107;
            // 
            // RAM
            // 
            this.RAM.Caption = "RAM";
            this.RAM.FieldName = "RAM";
            this.RAM.MinWidth = 21;
            this.RAM.Name = "RAM";
            this.RAM.OptionsColumn.ReadOnly = true;
            this.RAM.Visible = true;
            this.RAM.VisibleIndex = 8;
            this.RAM.Width = 50;
            // 
            // SSD
            // 
            this.SSD.Caption = "SSD";
            this.SSD.FieldName = "SSD";
            this.SSD.MinWidth = 21;
            this.SSD.Name = "SSD";
            this.SSD.OptionsColumn.ReadOnly = true;
            this.SSD.Visible = true;
            this.SSD.VisibleIndex = 9;
            this.SSD.Width = 45;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Caption = "Created By";
            this.CreatedBy.FieldName = "CreatedBy";
            this.CreatedBy.MinWidth = 21;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.OptionsColumn.ReadOnly = true;
            this.CreatedBy.Visible = true;
            this.CreatedBy.VisibleIndex = 10;
            this.CreatedBy.Width = 111;
            // 
            // CreatedAt
            // 
            this.CreatedAt.Caption = "Created At";
            this.CreatedAt.ColumnEdit = this.repositoryItemDateEdit1;
            this.CreatedAt.FieldName = "CreatedAt";
            this.CreatedAt.MinWidth = 21;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.OptionsColumn.ReadOnly = true;
            this.CreatedAt.Width = 169;
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
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnSearch,
            this.barBtnReload,
            this.barBtnCreate,
            this.barBtnExport,
            this.barBtnClose,
            this.btnStockOut,
            this.btnStockIn,
            this.btnHistoryStock});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1186, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barBtnSearch
            // 
            this.barBtnSearch.Caption = "Search";
            this.barBtnSearch.Hint = "Fill information and click hero to search data by option";
            this.barBtnSearch.Id = 1;
            this.barBtnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSearch.ImageOptions.SvgImage")));
            this.barBtnSearch.Name = "barBtnSearch";
            this.barBtnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSearch_ItemClick);
            // 
            // barBtnReload
            // 
            this.barBtnReload.Caption = "Reload";
            this.barBtnReload.Id = 2;
            this.barBtnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnReload.ImageOptions.SvgImage")));
            this.barBtnReload.Name = "barBtnReload";
            // 
            // barBtnCreate
            // 
            this.barBtnCreate.Caption = "Create";
            this.barBtnCreate.Id = 3;
            this.barBtnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnCreate.ImageOptions.SvgImage")));
            this.barBtnCreate.Name = "barBtnCreate";
            this.barBtnCreate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCreate_ItemClick);
            // 
            // barBtnExport
            // 
            this.barBtnExport.Caption = "Export Excel";
            this.barBtnExport.Id = 4;
            this.barBtnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnExport.ImageOptions.SvgImage")));
            this.barBtnExport.Name = "barBtnExport";
            this.barBtnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExport_ItemClick);
            // 
            // barBtnClose
            // 
            this.barBtnClose.Caption = "Close";
            this.barBtnClose.Id = 5;
            this.barBtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnClose.ImageOptions.SvgImage")));
            this.barBtnClose.Name = "barBtnClose";
            this.barBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnClose_ItemClick);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Caption = "Stock Out";
            this.btnStockOut.Id = 6;
            this.btnStockOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStockOut.ImageOptions.SvgImage")));
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStockOut_ItemClick);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Caption = "Stock In";
            this.btnStockIn.Id = 7;
            this.btnStockIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStockIn.ImageOptions.SvgImage")));
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStockIn_ItemClick);
            // 
            // btnHistoryStock
            // 
            this.btnHistoryStock.Caption = "History Update Stock";
            this.btnHistoryStock.Id = 8;
            this.btnHistoryStock.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHistoryStock.ImageOptions.SvgImage")));
            this.btnHistoryStock.Name = "btnHistoryStock";
            this.btnHistoryStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHistoryStock_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Product Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnReload);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCreate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStockIn);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStockOut);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHistoryStock);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Warehouse ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "System";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 616);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1186, 23);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 147);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ccbWarehouse);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputProductId);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.ccbPrice);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.ccbRams);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.ccbCategory);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.ccbBrands);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputPName);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlProduct);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 469);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // ccbWarehouse
            // 
            this.ccbWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ccbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbWarehouse.FormattingEnabled = true;
            this.ccbWarehouse.Location = new System.Drawing.Point(126, 219);
            this.ccbWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbWarehouse.Name = "ccbWarehouse";
            this.ccbWarehouse.Size = new System.Drawing.Size(271, 21);
            this.ccbWarehouse.TabIndex = 21;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(20, 226);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Warehouse:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(325, 72);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 18);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Go Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtInputProductId
            // 
            this.txtInputProductId.Location = new System.Drawing.Point(126, 72);
            this.txtInputProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputProductId.MenuManager = this.ribbonControl1;
            this.txtInputProductId.Name = "txtInputProductId";
            this.txtInputProductId.Size = new System.Drawing.Size(194, 20);
            this.txtInputProductId.TabIndex = 18;
            this.txtInputProductId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputProductId_KeyPress);
            this.txtInputProductId.Validating += new System.ComponentModel.CancelEventHandler(this.txtInputProductId_Validating);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(20, 76);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Product ID:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(20, 34);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 22);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Open edit";
            // 
            // ccbPrice
            // 
            this.ccbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ccbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbPrice.FormattingEnabled = true;
            this.ccbPrice.Location = new System.Drawing.Point(126, 270);
            this.ccbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbPrice.Name = "ccbPrice";
            this.ccbPrice.Size = new System.Drawing.Size(271, 21);
            this.ccbPrice.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 128);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(109, 22);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Option search";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 420);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Ram:";
            // 
            // ccbRams
            // 
            this.ccbRams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbRams.FormattingEnabled = true;
            this.ccbRams.Location = new System.Drawing.Point(126, 418);
            this.ccbRams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbRams.Name = "ccbRams";
            this.ccbRams.Size = new System.Drawing.Size(271, 21);
            this.ccbRams.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 374);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Category:";
            // 
            // ccbCategory
            // 
            this.ccbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbCategory.FormattingEnabled = true;
            this.ccbCategory.Location = new System.Drawing.Point(126, 367);
            this.ccbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbCategory.Name = "ccbCategory";
            this.ccbCategory.Size = new System.Drawing.Size(271, 21);
            this.ccbCategory.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 327);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Brands:";
            // 
            // ccbBrands
            // 
            this.ccbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbBrands.FormattingEnabled = true;
            this.ccbBrands.Location = new System.Drawing.Point(126, 321);
            this.ccbBrands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbBrands.Name = "ccbBrands";
            this.ccbBrands.Size = new System.Drawing.Size(271, 21);
            this.ccbBrands.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 276);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Price:";
            // 
            // txtInputPName
            // 
            this.txtInputPName.Location = new System.Drawing.Point(126, 171);
            this.txtInputPName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputPName.MenuManager = this.ribbonControl1;
            this.txtInputPName.Name = "txtInputPName";
            this.txtInputPName.Size = new System.Drawing.Size(271, 20);
            this.txtInputPName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 174);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Product Name:";
            // 
            // errorProviderProductID
            // 
            this.errorProviderProductID.ContainerControl = this;
            // 
            // ProductionMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductionMgt";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Production";
            this.Load += new System.EventHandler(this.ProductionMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInputProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barBtnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraBars.BarButtonItem barBtnReload;
        private DevExpress.XtraBars.BarButtonItem barBtnExport;
        private System.Windows.Forms.ComboBox ccbPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox ccbRams;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox ccbCategory;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox ccbBrands;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtInputPName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.ErrorProvider errorProviderProductID;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox ccbWarehouse;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn PId;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Brand;
        private DevExpress.XtraGrid.Columns.GridColumn Category;
        private DevExpress.XtraGrid.Columns.GridColumn Picture;
        private DevExpress.XtraGrid.Columns.GridColumn Mainboard;
        private DevExpress.XtraGrid.Columns.GridColumn CPU;
        private DevExpress.XtraGrid.Columns.GridColumn VGA;
        private DevExpress.XtraGrid.Columns.GridColumn RAM;
        private DevExpress.XtraGrid.Columns.GridColumn SSD;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedAt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn WarehouseName;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraBars.BarButtonItem btnHistoryStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit itemPictureEditProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        public DevExpress.XtraBars.BarButtonItem barBtnCreate;
        public DevExpress.XtraBars.BarButtonItem btnStockOut;
        public DevExpress.XtraBars.BarButtonItem btnStockIn;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.TextEdit txtInputProductId;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}