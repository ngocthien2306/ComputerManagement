
namespace ManagementStore.Form.Employee
{
    partial class AdminMgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMgt));
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.cardViewProduct = new DevExpress.XtraGrid.Views.Card.CardView();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Picture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPictureEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Permission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInputCreateAt = new DevExpress.XtraEditors.TextEdit();
            this.ccbFirstName = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtInputUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ccbLastName = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ccbPermission = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInputUsername2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProviderProductID = new System.Windows.Forms.ErrorProvider(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPermissionChange = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBlock = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ccbUseYN = new System.Windows.Forms.ComboBox();
            this.UseYN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputCreateAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername2.Properties)).BeginInit();
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
            this.Username,
            this.Password,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Picture,
            this.Address,
            this.Phone,
            this.Birthday,
            this.Permission,
            this.CreatedAt,
            this.UseYN});
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
            // Username
            // 
            this.Username.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.Username.AppearanceCell.Options.UseForeColor = true;
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.MinWidth = 21;
            this.Username.Name = "Username";
            this.Username.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            this.Username.Width = 60;
            // 
            // Password
            // 
            this.Password.Caption = "Password";
            this.Password.FieldName = "Password";
            this.Password.MinWidth = 21;
            this.Password.Name = "Password";
            this.Password.OptionsColumn.ReadOnly = true;
            this.Password.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.Password.Width = 91;
            // 
            // FirstName
            // 
            this.FirstName.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.FirstName.AppearanceCell.Options.UseForeColor = true;
            this.FirstName.Caption = "First Name";
            this.FirstName.DisplayFormat.FormatString = "{0:#,0# VND}";
            this.FirstName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 21;
            this.FirstName.Name = "FirstName";
            this.FirstName.OptionsColumn.ReadOnly = true;
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 1;
            this.FirstName.Width = 91;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 21;
            this.LastName.Name = "LastName";
            this.LastName.OptionsColumn.ReadOnly = true;
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            this.LastName.Width = 91;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 21;
            this.Email.Name = "Email";
            this.Email.OptionsColumn.ReadOnly = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 94;
            // 
            // Picture
            // 
            this.Picture.Caption = "Picture";
            this.Picture.ColumnEdit = this.itemPictureEditUser;
            this.Picture.FieldName = "Picture";
            this.Picture.MinWidth = 21;
            this.Picture.Name = "Picture";
            this.Picture.OptionsColumn.ReadOnly = true;
            this.Picture.Visible = true;
            this.Picture.VisibleIndex = 4;
            this.Picture.Width = 65;
            // 
            // itemPictureEditUser
            // 
            this.itemPictureEditUser.CustomHeight = 50;
            this.itemPictureEditUser.Name = "itemPictureEditUser";
            this.itemPictureEditUser.ReadOnly = true;
            this.itemPictureEditUser.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 21;
            this.Address.Name = "Address";
            this.Address.OptionsColumn.ReadOnly = true;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 9;
            this.Address.Width = 93;
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone Number";
            this.Phone.FieldName = "Phone";
            this.Phone.MinWidth = 21;
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 7;
            this.Phone.Width = 81;
            // 
            // Birthday
            // 
            this.Birthday.Caption = "Birthday";
            this.Birthday.FieldName = "Birthday";
            this.Birthday.MinWidth = 21;
            this.Birthday.Name = "Birthday";
            this.Birthday.Visible = true;
            this.Birthday.VisibleIndex = 8;
            this.Birthday.Width = 81;
            // 
            // Permission
            // 
            this.Permission.Caption = "Permission";
            this.Permission.FieldName = "TypeId";
            this.Permission.MinWidth = 21;
            this.Permission.Name = "Permission";
            this.Permission.OptionsColumn.ReadOnly = true;
            this.Permission.Visible = true;
            this.Permission.VisibleIndex = 5;
            this.Permission.Width = 99;
            // 
            // CreatedAt
            // 
            this.CreatedAt.Caption = "Created Date";
            this.CreatedAt.FieldName = "CreatedAt";
            this.CreatedAt.MinWidth = 21;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.OptionsColumn.ReadOnly = true;
            this.CreatedAt.Visible = true;
            this.CreatedAt.VisibleIndex = 6;
            this.CreatedAt.Width = 107;
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
            this.btnHistoryStock,
            this.barBtnDelete,
            this.barBtnPermissionChange,
            this.barBtnBlock});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 12;
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
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "User Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnReload);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCreate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnPermissionChange);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnBlock);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
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
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
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
            this.splitContainer1.Panel1.Controls.Add(this.ccbUseYN);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputCreateAt);
            this.splitContainer1.Panel1.Controls.Add(this.ccbFirstName);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputUsername);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.ccbLastName);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.ccbPermission);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputUsername2);
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
            // txtInputCreateAt
            // 
            this.txtInputCreateAt.Location = new System.Drawing.Point(126, 371);
            this.txtInputCreateAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputCreateAt.MenuManager = this.ribbonControl1;
            this.txtInputCreateAt.Name = "txtInputCreateAt";
            this.txtInputCreateAt.Size = new System.Drawing.Size(271, 20);
            this.txtInputCreateAt.TabIndex = 22;
            // 
            // ccbFirstName
            // 
            this.ccbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ccbFirstName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbFirstName.FormattingEnabled = true;
            this.ccbFirstName.Location = new System.Drawing.Point(126, 219);
            this.ccbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbFirstName.Name = "ccbFirstName";
            this.ccbFirstName.Size = new System.Drawing.Size(271, 21);
            this.ccbFirstName.TabIndex = 21;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(20, 226);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 13);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "First Name:";
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
            // txtInputUsername
            // 
            this.txtInputUsername.Location = new System.Drawing.Point(126, 72);
            this.txtInputUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputUsername.MenuManager = this.ribbonControl1;
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Size = new System.Drawing.Size(194, 20);
            this.txtInputUsername.TabIndex = 18;
            this.txtInputUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputProductId_KeyPress);
            this.txtInputUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtInputProductId_Validating);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(20, 76);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Username:";
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
            // ccbLastName
            // 
            this.ccbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ccbLastName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbLastName.FormattingEnabled = true;
            this.ccbLastName.Location = new System.Drawing.Point(126, 270);
            this.ccbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbLastName.Name = "ccbLastName";
            this.ccbLastName.Size = new System.Drawing.Size(271, 21);
            this.ccbLastName.TabIndex = 11;
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 374);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Created Date:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 327);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Permission";
            // 
            // ccbPermission
            // 
            this.ccbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbPermission.FormattingEnabled = true;
            this.ccbPermission.Location = new System.Drawing.Point(126, 321);
            this.ccbPermission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbPermission.Name = "ccbPermission";
            this.ccbPermission.Size = new System.Drawing.Size(271, 21);
            this.ccbPermission.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 276);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Last Name:";
            // 
            // txtInputUsername2
            // 
            this.txtInputUsername2.Location = new System.Drawing.Point(126, 171);
            this.txtInputUsername2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputUsername2.MenuManager = this.ribbonControl1;
            this.txtInputUsername2.Name = "txtInputUsername2";
            this.txtInputUsername2.Size = new System.Drawing.Size(271, 20);
            this.txtInputUsername2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 174);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UserName:";
            // 
            // errorProviderProductID
            // 
            this.errorProviderProductID.ContainerControl = this;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStockIn);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStockOut);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHistoryStock);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Warehouse ";
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "Delete";
            this.barBtnDelete.Id = 9;
            this.barBtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barBtnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barBtnDelete.Name = "barBtnDelete";
            // 
            // barBtnPermissionChange
            // 
            this.barBtnPermissionChange.Caption = "Permission";
            this.barBtnPermissionChange.Id = 10;
            this.barBtnPermissionChange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPermissionChange.ImageOptions.Image")));
            this.barBtnPermissionChange.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPermissionChange.ImageOptions.LargeImage")));
            this.barBtnPermissionChange.Name = "barBtnPermissionChange";
            // 
            // barBtnBlock
            // 
            this.barBtnBlock.Caption = "Block";
            this.barBtnBlock.Id = 11;
            this.barBtnBlock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.barBtnBlock.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.barBtnBlock.Name = "barBtnBlock";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 423);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Block:";
            // 
            // ccbUseYN
            // 
            this.ccbUseYN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbUseYN.FormattingEnabled = true;
            this.ccbUseYN.Location = new System.Drawing.Point(126, 420);
            this.ccbUseYN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbUseYN.Name = "ccbUseYN";
            this.ccbUseYN.Size = new System.Drawing.Size(271, 21);
            this.ccbUseYN.TabIndex = 24;
            // 
            // UseYN
            // 
            this.UseYN.Caption = "Block";
            this.UseYN.FieldName = "UseYN";
            this.UseYN.Name = "UseYN";
            this.UseYN.Visible = true;
            this.UseYN.VisibleIndex = 10;
            // 
            // AdminMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMgt";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.ProductionMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInputCreateAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername2.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barBtnCreate;
        private DevExpress.XtraBars.BarButtonItem barBtnExport;
        private System.Windows.Forms.ComboBox ccbLastName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox ccbPermission;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtInputUsername2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.TextEdit txtInputUsername;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ErrorProvider errorProviderProductID;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox ccbFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Picture;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn Permission;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedAt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraBars.BarButtonItem btnStockOut;
        private DevExpress.XtraBars.BarButtonItem btnStockIn;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Birthday;
        private DevExpress.XtraBars.BarButtonItem btnHistoryStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit itemPictureEditUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.TextEdit txtInputCreateAt;
        private DevExpress.XtraGrid.Columns.GridColumn UseYN;
        private DevExpress.XtraBars.BarButtonItem barBtnDelete;
        private DevExpress.XtraBars.BarButtonItem barBtnPermissionChange;
        private DevExpress.XtraBars.BarButtonItem barBtnBlock;
        private System.Windows.Forms.ComboBox ccbUseYN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}