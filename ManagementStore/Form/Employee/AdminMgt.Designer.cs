
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
            this.gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlUser = new DevExpress.XtraGrid.GridControl();
            this.cardViewUser = new DevExpress.XtraGrid.Views.Card.CardView();
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
            this.TypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UseYN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCreate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExport = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnStockOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnStockIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnHistoryStock = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPermissionChange = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBlock = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCreateUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnBehavior = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInputPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtInputEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtInputLastname = new DevExpress.XtraEditors.TextEdit();
            this.txtInputFirstname = new DevExpress.XtraEditors.TextEdit();
            this.ccbUseYN = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ccbPermission = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInputUsername2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewUser
            // 
            this.gridViewUser.GridControl = this.gridControlUser;
            this.gridViewUser.Name = "gridViewUser";
            // 
            // gridControlUser
            // 
            this.gridControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUser.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.LevelTemplate = this.gridViewUser;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlUser.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlUser.Location = new System.Drawing.Point(0, 0);
            this.gridControlUser.MainView = this.cardViewUser;
            this.gridControlUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlUser.MenuManager = this.ribbonControl1;
            this.gridControlUser.Name = "gridControlUser";
            this.gridControlUser.Size = new System.Drawing.Size(1169, 620);
            this.gridControlUser.TabIndex = 0;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardViewUser,
            this.gridViewUser});
            // 
            // cardViewUser
            // 
            this.cardViewUser.Appearance.FieldCaption.BackColor = System.Drawing.Color.White;
            this.cardViewUser.Appearance.FieldCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.cardViewUser.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardViewUser.Appearance.FieldCaption.Options.UseForeColor = true;
            this.cardViewUser.CardWidth = 269;
            this.cardViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Username,
            this.Password,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Picture,
            this.Address,
            this.Phone,
            this.Birthday,
            this.TypeName,
            this.CreatedAt,
            this.UseYN});
            this.cardViewUser.GridControl = this.gridControlUser;
            this.cardViewUser.MaximumCardColumns = 4;
            this.cardViewUser.MaximumCardRows = 10;
            this.cardViewUser.Name = "cardViewUser";
            this.cardViewUser.OptionsPrint.AutoHorzWidth = true;
            this.cardViewUser.OptionsPrint.PrintCardCaption = false;
            this.cardViewUser.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.cardViewUser_FocusedRowChanged);
            this.cardViewUser.Click += new System.EventHandler(this.cardViewUser_Click);
            // 
            // Username
            // 
            this.Username.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.Username.AppearanceCell.Options.UseForeColor = true;
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.MinWidth = 24;
            this.Username.Name = "Username";
            this.Username.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            this.Username.Width = 70;
            // 
            // Password
            // 
            this.Password.Caption = "Password";
            this.Password.FieldName = "Password";
            this.Password.MinWidth = 24;
            this.Password.Name = "Password";
            this.Password.OptionsColumn.ReadOnly = true;
            this.Password.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.Password.Width = 106;
            // 
            // FirstName
            // 
            this.FirstName.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.FirstName.AppearanceCell.Options.UseForeColor = true;
            this.FirstName.Caption = "First Name";
            this.FirstName.DisplayFormat.FormatString = "{0:#,0# VND}";
            this.FirstName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FirstName.FieldName = "Firstname";
            this.FirstName.MinWidth = 24;
            this.FirstName.Name = "FirstName";
            this.FirstName.OptionsColumn.ReadOnly = true;
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 1;
            this.FirstName.Width = 106;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "Lastname";
            this.LastName.MinWidth = 24;
            this.LastName.Name = "LastName";
            this.LastName.OptionsColumn.ReadOnly = true;
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            this.LastName.Width = 106;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 24;
            this.Email.Name = "Email";
            this.Email.OptionsColumn.ReadOnly = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 110;
            // 
            // Picture
            // 
            this.Picture.Caption = "Picture";
            this.Picture.ColumnEdit = this.itemPictureEditUser;
            this.Picture.FieldName = "Picture";
            this.Picture.MinWidth = 24;
            this.Picture.Name = "Picture";
            this.Picture.OptionsColumn.ReadOnly = true;
            this.Picture.Visible = true;
            this.Picture.VisibleIndex = 4;
            this.Picture.Width = 76;
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
            this.Address.MinWidth = 24;
            this.Address.Name = "Address";
            this.Address.OptionsColumn.ReadOnly = true;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 9;
            this.Address.Width = 108;
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone Number";
            this.Phone.FieldName = "Phone";
            this.Phone.MinWidth = 24;
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 7;
            this.Phone.Width = 94;
            // 
            // Birthday
            // 
            this.Birthday.Caption = "Birthday";
            this.Birthday.FieldName = "Birthday";
            this.Birthday.MinWidth = 24;
            this.Birthday.Name = "Birthday";
            this.Birthday.Visible = true;
            this.Birthday.VisibleIndex = 8;
            this.Birthday.Width = 94;
            // 
            // TypeName
            // 
            this.TypeName.Caption = "Permission";
            this.TypeName.FieldName = "TypeName";
            this.TypeName.MinWidth = 24;
            this.TypeName.Name = "TypeName";
            this.TypeName.OptionsColumn.ReadOnly = true;
            this.TypeName.Visible = true;
            this.TypeName.VisibleIndex = 5;
            this.TypeName.Width = 115;
            // 
            // CreatedAt
            // 
            this.CreatedAt.Caption = "Created Date";
            this.CreatedAt.FieldName = "CreatedAt";
            this.CreatedAt.MinWidth = 24;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.OptionsColumn.ReadOnly = true;
            this.CreatedAt.Visible = true;
            this.CreatedAt.VisibleIndex = 6;
            this.CreatedAt.Width = 125;
            // 
            // UseYN
            // 
            this.UseYN.Caption = "Block";
            this.UseYN.FieldName = "UseYN";
            this.UseYN.MinWidth = 23;
            this.UseYN.Name = "UseYN";
            this.UseYN.Visible = true;
            this.UseYN.VisibleIndex = 10;
            this.UseYN.Width = 87;
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
            this.barBtnPermissionChange,
            this.barBtnBlock,
            this.barbtnCreateUser,
            this.btnBehavior});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1658, 181);
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
            this.barBtnCreate.Id = 17;
            this.barBtnCreate.Name = "barBtnCreate";
            // 
            // barBtnExport
            // 
            this.barBtnExport.Id = 18;
            this.barBtnExport.Name = "barBtnExport";
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
            this.btnStockOut.Id = 19;
            this.btnStockOut.Name = "btnStockOut";
            // 
            // btnStockIn
            // 
            this.btnStockIn.Id = 20;
            this.btnStockIn.Name = "btnStockIn";
            // 
            // btnHistoryStock
            // 
            this.btnHistoryStock.Id = 21;
            this.btnHistoryStock.Name = "btnHistoryStock";
            // 
            // barBtnPermissionChange
            // 
            this.barBtnPermissionChange.Caption = "Permission";
            this.barBtnPermissionChange.Id = 10;
            this.barBtnPermissionChange.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnPermissionChange.ImageOptions.SvgImage")));
            this.barBtnPermissionChange.Name = "barBtnPermissionChange";
            this.barBtnPermissionChange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPermissionChange_ItemClick);
            // 
            // barBtnBlock
            // 
            this.barBtnBlock.Caption = "Block";
            this.barBtnBlock.Id = 11;
            this.barBtnBlock.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnBlock.ImageOptions.SvgImage")));
            this.barBtnBlock.Name = "barBtnBlock";
            this.barBtnBlock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBlock_ItemClick);
            // 
            // barbtnCreateUser
            // 
            this.barbtnCreateUser.Caption = "CreateUser";
            this.barbtnCreateUser.Id = 16;
            this.barbtnCreateUser.ImageOptions.SvgImage = global::ManagementStore.Properties.Resources.newemployee;
            this.barbtnCreateUser.Name = "barbtnCreateUser";
            this.barbtnCreateUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCreateUser_ItemClick);
            // 
            // btnBehavior
            // 
            this.btnBehavior.Caption = "Audit";
            this.btnBehavior.Id = 22;
            this.btnBehavior.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBehavior.ImageOptions.SvgImage")));
            this.btnBehavior.Name = "btnBehavior";
            this.btnBehavior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBehavior_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "User Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnReload);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnCreateUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnPermissionChange);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnBlock);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBehavior);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Behavior";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "System";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 801);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1658, 29);
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 181);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtInputPhone);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputEmail);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputLastname);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputFirstname);
            this.splitContainer1.Panel1.Controls.Add(this.ccbUseYN);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.ccbPermission);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputUsername2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlUser);
            this.splitContainer1.Size = new System.Drawing.Size(1658, 620);
            this.splitContainer1.SplitterDistance = 486;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // txtInputPhone
            // 
            this.txtInputPhone.Location = new System.Drawing.Point(145, 314);
            this.txtInputPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputPhone.MenuManager = this.ribbonControl1;
            this.txtInputPhone.Name = "txtInputPhone";
            this.txtInputPhone.Size = new System.Drawing.Size(248, 22);
            this.txtInputPhone.TabIndex = 30;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(21, 318);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(89, 16);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Phone Number:";
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.Location = new System.Drawing.Point(145, 262);
            this.txtInputEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputEmail.MenuManager = this.ribbonControl1;
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.Size = new System.Drawing.Size(248, 22);
            this.txtInputEmail.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 266);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 16);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Email:";
            // 
            // txtInputLastname
            // 
            this.txtInputLastname.Location = new System.Drawing.Point(145, 210);
            this.txtInputLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputLastname.MenuManager = this.ribbonControl1;
            this.txtInputLastname.Name = "txtInputLastname";
            this.txtInputLastname.Size = new System.Drawing.Size(248, 22);
            this.txtInputLastname.TabIndex = 26;
            // 
            // txtInputFirstname
            // 
            this.txtInputFirstname.Location = new System.Drawing.Point(145, 160);
            this.txtInputFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputFirstname.MenuManager = this.ribbonControl1;
            this.txtInputFirstname.Name = "txtInputFirstname";
            this.txtInputFirstname.Size = new System.Drawing.Size(248, 22);
            this.txtInputFirstname.TabIndex = 25;
            // 
            // ccbUseYN
            // 
            this.ccbUseYN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbUseYN.FormattingEnabled = true;
            this.ccbUseYN.Location = new System.Drawing.Point(145, 425);
            this.ccbUseYN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbUseYN.Name = "ccbUseYN";
            this.ccbUseYN.Size = new System.Drawing.Size(248, 24);
            this.ccbUseYN.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 428);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 16);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Block:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(21, 164);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 16);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "First Name:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(21, 57);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(140, 28);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Option search";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 375);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Permission";
            // 
            // ccbPermission
            // 
            this.ccbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbPermission.FormattingEnabled = true;
            this.ccbPermission.Location = new System.Drawing.Point(145, 368);
            this.ccbPermission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbPermission.Name = "ccbPermission";
            this.ccbPermission.Size = new System.Drawing.Size(248, 24);
            this.ccbPermission.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 214);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Last Name:";
            // 
            // txtInputUsername2
            // 
            this.txtInputUsername2.Location = new System.Drawing.Point(145, 110);
            this.txtInputUsername2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputUsername2.MenuManager = this.ribbonControl1;
            this.txtInputUsername2.Name = "txtInputUsername2";
            this.txtInputUsername2.Size = new System.Drawing.Size(248, 22);
            this.txtInputUsername2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 113);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UserName:";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStockIn);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStockOut);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHistoryStock);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Warehouse ";
            // 
            // AdminMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 830);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMgt";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername2.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox ccbPermission;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtInputUsername2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlUser;
        private DevExpress.XtraBars.BarButtonItem barBtnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewUser;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Picture;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn TypeName;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedAt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUser;
        private DevExpress.XtraBars.BarButtonItem btnStockOut;
        private DevExpress.XtraBars.BarButtonItem btnStockIn;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Birthday;
        private DevExpress.XtraBars.BarButtonItem btnHistoryStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit itemPictureEditUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn UseYN;
        private DevExpress.XtraBars.BarButtonItem barBtnPermissionChange;
        private DevExpress.XtraBars.BarButtonItem barBtnBlock;
        private System.Windows.Forms.ComboBox ccbUseYN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtInputLastname;
        private DevExpress.XtraEditors.TextEdit txtInputFirstname;
        private DevExpress.XtraEditors.TextEdit txtInputPhone;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtInputEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraBars.BarButtonItem barbtnCreateUser;
        private DevExpress.XtraBars.BarButtonItem btnBehavior;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}