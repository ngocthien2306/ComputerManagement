
namespace ManagementStore.Form.Production
{
    partial class HistoryStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryStock));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatistics = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.History = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupOptionSearch = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ccbRams = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ccbStockInorOut = new System.Windows.Forms.ComboBox();
            this.endDateHis = new DevExpress.XtraEditors.DateEdit();
            this.startDateHis = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ccbWarehouse = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ccbCategory = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ccbBrands = new System.Windows.Forms.ComboBox();
            this.txtInputPName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlHistory = new DevExpress.XtraGrid.GridControl();
            this.gridViewHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemInWH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemOutWh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InOrOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Brand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WHName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UpdatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UpdatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupOptionSearch)).BeginInit();
            this.groupOptionSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateHis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateHis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateHis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateHis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSearch,
            this.btnExportExcel,
            this.btnStatistics,
            this.barButtonItem4,
            this.btnReload});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.History});
            this.ribbon.Size = new System.Drawing.Size(1507, 181);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSearch
            // 
            this.btnSearch.Caption = "Search";
            this.btnSearch.Id = 1;
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearch_ItemClick);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Caption = "Export Excel";
            this.btnExportExcel.Id = 2;
            this.btnExportExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcel.ImageOptions.SvgImage")));
            this.btnExportExcel.Name = "btnExportExcel";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Caption = "Statistic Stock";
            this.btnStatistics.Id = 3;
            this.btnStatistics.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStatistics.ImageOptions.SvgImage")));
            this.btnStatistics.Name = "btnStatistics";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Close";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // History
            // 
            this.History.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.History.Name = "History";
            this.History.Text = "History";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExportExcel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReload);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Task";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStatistics);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Statistics";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "System";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1507, 29);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 181);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupOptionSearch);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlHistory);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1507, 528);
            this.splitContainerControl1.SplitterPosition = 398;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // groupOptionSearch
            // 
            this.groupOptionSearch.Controls.Add(this.labelControl7);
            this.groupOptionSearch.Controls.Add(this.ccbRams);
            this.groupOptionSearch.Controls.Add(this.labelControl2);
            this.groupOptionSearch.Controls.Add(this.ccbStockInorOut);
            this.groupOptionSearch.Controls.Add(this.endDateHis);
            this.groupOptionSearch.Controls.Add(this.startDateHis);
            this.groupOptionSearch.Controls.Add(this.labelControl6);
            this.groupOptionSearch.Controls.Add(this.labelControl5);
            this.groupOptionSearch.Controls.Add(this.ccbWarehouse);
            this.groupOptionSearch.Controls.Add(this.labelControl9);
            this.groupOptionSearch.Controls.Add(this.labelControl4);
            this.groupOptionSearch.Controls.Add(this.ccbCategory);
            this.groupOptionSearch.Controls.Add(this.labelControl3);
            this.groupOptionSearch.Controls.Add(this.ccbBrands);
            this.groupOptionSearch.Controls.Add(this.txtInputPName);
            this.groupOptionSearch.Controls.Add(this.labelControl1);
            this.groupOptionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupOptionSearch.Location = new System.Drawing.Point(0, 0);
            this.groupOptionSearch.Name = "groupOptionSearch";
            this.groupOptionSearch.Size = new System.Drawing.Size(398, 528);
            this.groupOptionSearch.TabIndex = 0;
            this.groupOptionSearch.Text = "Option Search";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(20, 468);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 16);
            this.labelControl7.TabIndex = 80;
            this.labelControl7.Text = "Rams:";
            // 
            // ccbRams
            // 
            this.ccbRams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbRams.FormattingEnabled = true;
            this.ccbRams.Location = new System.Drawing.Point(130, 460);
            this.ccbRams.Name = "ccbRams";
            this.ccbRams.Size = new System.Drawing.Size(238, 24);
            this.ccbRams.TabIndex = 79;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Stock In/Out:";
            // 
            // ccbStockInorOut
            // 
            this.ccbStockInorOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbStockInorOut.FormattingEnabled = true;
            this.ccbStockInorOut.Location = new System.Drawing.Point(130, 112);
            this.ccbStockInorOut.Name = "ccbStockInorOut";
            this.ccbStockInorOut.Size = new System.Drawing.Size(238, 24);
            this.ccbStockInorOut.TabIndex = 77;
            // 
            // endDateHis
            // 
            this.endDateHis.EditValue = null;
            this.endDateHis.Location = new System.Drawing.Point(130, 405);
            this.endDateHis.MenuManager = this.ribbon;
            this.endDateHis.Name = "endDateHis";
            this.endDateHis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateHis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateHis.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.endDateHis.Properties.MaxValue = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            this.endDateHis.Properties.MinValue = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.endDateHis.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.endDateHis.Size = new System.Drawing.Size(238, 22);
            this.endDateHis.TabIndex = 76;
            // 
            // startDateHis
            // 
            this.startDateHis.EditValue = null;
            this.startDateHis.Location = new System.Drawing.Point(130, 347);
            this.startDateHis.MenuManager = this.ribbon;
            this.startDateHis.Name = "startDateHis";
            this.startDateHis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateHis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateHis.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.startDateHis.Properties.MaxValue = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            this.startDateHis.Properties.MinValue = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.startDateHis.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.startDateHis.Size = new System.Drawing.Size(238, 22);
            this.startDateHis.TabIndex = 75;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 408);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 16);
            this.labelControl6.TabIndex = 74;
            this.labelControl6.Text = "End Date:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 347);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 16);
            this.labelControl5.TabIndex = 73;
            this.labelControl5.Text = "Start Date:";
            // 
            // ccbWarehouse
            // 
            this.ccbWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ccbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbWarehouse.FormattingEnabled = true;
            this.ccbWarehouse.Location = new System.Drawing.Point(130, 172);
            this.ccbWarehouse.Name = "ccbWarehouse";
            this.ccbWarehouse.Size = new System.Drawing.Size(238, 24);
            this.ccbWarehouse.TabIndex = 70;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(20, 180);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(70, 16);
            this.labelControl9.TabIndex = 69;
            this.labelControl9.Text = "Warehouse:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 298);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "Category:";
            // 
            // ccbCategory
            // 
            this.ccbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbCategory.FormattingEnabled = true;
            this.ccbCategory.Location = new System.Drawing.Point(130, 290);
            this.ccbCategory.Name = "ccbCategory";
            this.ccbCategory.Size = new System.Drawing.Size(238, 24);
            this.ccbCategory.TabIndex = 66;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 240);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 16);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "Brands:";
            // 
            // ccbBrands
            // 
            this.ccbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbBrands.FormattingEnabled = true;
            this.ccbBrands.Location = new System.Drawing.Point(130, 232);
            this.ccbBrands.Name = "ccbBrands";
            this.ccbBrands.Size = new System.Drawing.Size(238, 24);
            this.ccbBrands.TabIndex = 64;
            // 
            // txtInputPName
            // 
            this.txtInputPName.Location = new System.Drawing.Point(130, 49);
            this.txtInputPName.Name = "txtInputPName";
            this.txtInputPName.Size = new System.Drawing.Size(238, 22);
            this.txtInputPName.TabIndex = 63;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 16);
            this.labelControl1.TabIndex = 62;
            this.labelControl1.Text = "Product Name:";
            // 
            // gridControlHistory
            // 
            this.gridControlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHistory.Location = new System.Drawing.Point(0, 0);
            this.gridControlHistory.MainView = this.gridViewHistory;
            this.gridControlHistory.MenuManager = this.ribbon;
            this.gridControlHistory.Name = "gridControlHistory";
            this.gridControlHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControlHistory.Size = new System.Drawing.Size(1094, 528);
            this.gridControlHistory.TabIndex = 0;
            this.gridControlHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHistory});
            // 
            // gridViewHistory
            // 
            this.gridViewHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HId,
            this.Amount,
            this.ItemInWH,
            this.ItemOutWh,
            this.InOrOut,
            this.ProductName,
            this.CategoryName,
            this.RAM,
            this.Brand,
            this.WHName,
            this.UpdatedBy,
            this.UpdatedAt});
            this.gridViewHistory.GridControl = this.gridControlHistory;
            this.gridViewHistory.Name = "gridViewHistory";
            this.gridViewHistory.OptionsView.ShowFooter = true;
            // 
            // HId
            // 
            this.HId.Caption = "ID";
            this.HId.FieldName = "HId";
            this.HId.MinWidth = 25;
            this.HId.Name = "HId";
            this.HId.Width = 94;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Amount.FieldName = "Amount";
            this.Amount.MinWidth = 25;
            this.Amount.Name = "Amount";
            this.Amount.OptionsColumn.ReadOnly = true;
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 2;
            this.Amount.Width = 56;
            // 
            // ItemInWH
            // 
            this.ItemInWH.Caption = "Stock In";
            this.ItemInWH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ItemInWH.FieldName = "ItemInWH";
            this.ItemInWH.MinWidth = 25;
            this.ItemInWH.Name = "ItemInWH";
            this.ItemInWH.OptionsColumn.ReadOnly = true;
            this.ItemInWH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ItemInWH", "SUM={0:0.##}")});
            this.ItemInWH.Visible = true;
            this.ItemInWH.VisibleIndex = 3;
            this.ItemInWH.Width = 57;
            // 
            // ItemOutWh
            // 
            this.ItemOutWh.Caption = "Stock Out";
            this.ItemOutWh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ItemOutWh.FieldName = "ItemOutWh";
            this.ItemOutWh.MinWidth = 25;
            this.ItemOutWh.Name = "ItemOutWh";
            this.ItemOutWh.OptionsColumn.ReadOnly = true;
            this.ItemOutWh.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ItemOutWh", "SUM={0:0.##}")});
            this.ItemOutWh.Visible = true;
            this.ItemOutWh.VisibleIndex = 4;
            this.ItemOutWh.Width = 66;
            // 
            // InOrOut
            // 
            this.InOrOut.Caption = "Stock In/Out";
            this.InOrOut.FieldName = "InOrOut";
            this.InOrOut.MinWidth = 25;
            this.InOrOut.Name = "InOrOut";
            this.InOrOut.OptionsColumn.ReadOnly = true;
            this.InOrOut.Visible = true;
            this.InOrOut.VisibleIndex = 5;
            this.InOrOut.Width = 84;
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
            this.ProductName.Width = 93;
            // 
            // CategoryName
            // 
            this.CategoryName.Caption = "Category";
            this.CategoryName.FieldName = "CategoryName";
            this.CategoryName.MinWidth = 25;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.ReadOnly = true;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 6;
            this.CategoryName.Width = 84;
            // 
            // RAM
            // 
            this.RAM.Caption = "RAM";
            this.RAM.FieldName = "RAM";
            this.RAM.MinWidth = 25;
            this.RAM.Name = "RAM";
            this.RAM.OptionsColumn.ReadOnly = true;
            this.RAM.Visible = true;
            this.RAM.VisibleIndex = 7;
            this.RAM.Width = 84;
            // 
            // Brand
            // 
            this.Brand.Caption = "Brand";
            this.Brand.FieldName = "Brand";
            this.Brand.MinWidth = 25;
            this.Brand.Name = "Brand";
            this.Brand.OptionsColumn.ReadOnly = true;
            this.Brand.Visible = true;
            this.Brand.VisibleIndex = 8;
            this.Brand.Width = 84;
            // 
            // WHName
            // 
            this.WHName.Caption = "Warehouse Name";
            this.WHName.FieldName = "WHName";
            this.WHName.MinWidth = 25;
            this.WHName.Name = "WHName";
            this.WHName.OptionsColumn.ReadOnly = true;
            this.WHName.Visible = true;
            this.WHName.VisibleIndex = 0;
            this.WHName.Width = 120;
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.Caption = "Updated By";
            this.UpdatedBy.FieldName = "UpdatedBy";
            this.UpdatedBy.MinWidth = 25;
            this.UpdatedBy.Name = "UpdatedBy";
            this.UpdatedBy.OptionsColumn.ReadOnly = true;
            this.UpdatedBy.Visible = true;
            this.UpdatedBy.VisibleIndex = 9;
            this.UpdatedBy.Width = 84;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.Caption = "Updated At";
            this.UpdatedAt.ColumnEdit = this.repositoryItemDateEdit1;
            this.UpdatedAt.FieldName = "UpdatedAt";
            this.UpdatedAt.MinWidth = 25;
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.OptionsColumn.ReadOnly = true;
            this.UpdatedAt.Visible = true;
            this.UpdatedAt.VisibleIndex = 10;
            this.UpdatedAt.Width = 116;
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
            // realTimeSource1
            // 
            this.realTimeSource1.DisplayableProperties = null;
            // 
            // HistoryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 738);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "HistoryStock";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "History Stock";
            this.Load += new System.EventHandler(this.HistoryStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupOptionSearch)).EndInit();
            this.groupOptionSearch.ResumeLayout(false);
            this.groupOptionSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateHis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateHis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateHis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateHis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage History;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHistory;
        private DevExpress.XtraBars.BarButtonItem btnSearch;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.BarButtonItem btnStatistics;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.GroupControl groupOptionSearch;
        private DevExpress.XtraEditors.DateEdit endDateHis;
        private DevExpress.XtraEditors.DateEdit startDateHis;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox ccbWarehouse;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox ccbCategory;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox ccbBrands;
        private DevExpress.XtraEditors.TextEdit txtInputPName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.Data.RealTimeSource realTimeSource1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox ccbStockInorOut;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox ccbRams;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraGrid.Columns.GridColumn HId;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn ItemInWH;
        private DevExpress.XtraGrid.Columns.GridColumn ItemOutWh;
        private DevExpress.XtraGrid.Columns.GridColumn InOrOut;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn RAM;
        private DevExpress.XtraGrid.Columns.GridColumn Brand;
        private DevExpress.XtraGrid.Columns.GridColumn WHName;
        private DevExpress.XtraGrid.Columns.GridColumn UpdatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn UpdatedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}