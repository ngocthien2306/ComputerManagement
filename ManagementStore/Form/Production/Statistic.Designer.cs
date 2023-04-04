
namespace ManagementStore.Form.Production
{
    partial class Statistic
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
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle5 = new DevExpress.XtraCharts.ChartTitle();
            this.statisticProductTableAdapter = new ManagementStore.ComputerStoreDataSetTableAdapters.StatisticProductTableAdapter();
            this.statisticProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerStoreDataSet = new ManagementStore.ComputerStoreDataSet();
            this.chartControlStock = new DevExpress.XtraCharts.ChartControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnStaProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaStockIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaStockOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaWH = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStatistic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.chartControlWH = new DevExpress.XtraCharts.ChartControl();
            this.chartControlProduct = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.statisticProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlWH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticProductTableAdapter
            // 
            this.statisticProductTableAdapter.ClearBeforeFill = true;
            // 
            // statisticProductBindingSource
            // 
            this.statisticProductBindingSource.DataMember = "StatisticProduct";
            this.statisticProductBindingSource.DataSource = this.computerStoreDataSet;
            // 
            // computerStoreDataSet
            // 
            this.computerStoreDataSet.DataSetName = "ComputerStoreDataSet";
            this.computerStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartControlStock
            // 
            this.chartControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlStock.Legend.Name = "Default Legend";
            this.chartControlStock.Location = new System.Drawing.Point(0, 181);
            this.chartControlStock.Name = "chartControlStock";
            this.chartControlStock.PaletteName = "Civic";
            this.chartControlStock.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlStock.SeriesTemplate.SeriesColorizer = null;
            this.chartControlStock.Size = new System.Drawing.Size(1497, 647);
            this.chartControlStock.TabIndex = 0;
            chartTitle4.Text = "";
            this.chartControlStock.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle4});
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnStaProduct,
            this.btnStaStockIn,
            this.btnStaStockOut,
            this.btnStaWH,
            this.btnClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1497, 181);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnStaProduct
            // 
            this.btnStaProduct.Caption = "Product";
            this.btnStaProduct.Id = 1;
            this.btnStaProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStaProduct.ImageOptions.SvgImage")));
            this.btnStaProduct.Name = "btnStaProduct";
            this.btnStaProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaProduct_ItemClick);
            // 
            // btnStaStockIn
            // 
            this.btnStaStockIn.Caption = "Stock In";
            this.btnStaStockIn.Id = 2;
            this.btnStaStockIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStaStockIn.ImageOptions.SvgImage")));
            this.btnStaStockIn.Name = "btnStaStockIn";
            this.btnStaStockIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaStockIn_ItemClick);
            // 
            // btnStaStockOut
            // 
            this.btnStaStockOut.Caption = "Stock Out";
            this.btnStaStockOut.Id = 3;
            this.btnStaStockOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStaStockOut.ImageOptions.SvgImage")));
            this.btnStaStockOut.Name = "btnStaStockOut";
            this.btnStaStockOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaStockOut_ItemClick);
            // 
            // btnStaWH
            // 
            this.btnStaWH.Caption = "Item In Warehouse";
            this.btnStaWH.Id = 4;
            this.btnStaWH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStaWH.ImageOptions.SvgImage")));
            this.btnStaWH.Name = "btnStaWH";
            this.btnStaWH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaWH_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Id = 5;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStatistic,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Statistic";
            // 
            // ribbonPageGroupStatistic
            // 
            this.ribbonPageGroupStatistic.ItemLinks.Add(this.btnStaProduct);
            this.ribbonPageGroupStatistic.ItemLinks.Add(this.btnStaStockIn);
            this.ribbonPageGroupStatistic.ItemLinks.Add(this.btnStaStockOut);
            this.ribbonPageGroupStatistic.Name = "ribbonPageGroupStatistic";
            this.ribbonPageGroupStatistic.Text = "Production";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStaWH);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Warehouse";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "System";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 828);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1497, 29);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // chartControlWH
            // 
            this.chartControlWH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlWH.Legend.Name = "Default Legend";
            this.chartControlWH.Location = new System.Drawing.Point(0, 181);
            this.chartControlWH.Name = "chartControlWH";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControlWH.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlWH.SeriesTemplate.SeriesColorizer = null;
            this.chartControlWH.Size = new System.Drawing.Size(1497, 647);
            this.chartControlWH.TabIndex = 3;
            this.chartControlWH.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle5});
            // 
            // chartControlProduct
            // 
            this.chartControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlProduct.Legend.Name = "Default Legend";
            this.chartControlProduct.Location = new System.Drawing.Point(0, 181);
            this.chartControlProduct.Name = "chartControlProduct";
            this.chartControlProduct.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlProduct.SeriesTemplate.SeriesColorizer = null;
            this.chartControlProduct.Size = new System.Drawing.Size(1497, 647);
            this.chartControlProduct.TabIndex = 4;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 857);
            this.Controls.Add(this.chartControlProduct);
            this.Controls.Add(this.chartControlWH);
            this.Controls.Add(this.chartControlStock);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Statistic";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlWH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComputerStoreDataSetTableAdapters.StatisticProductTableAdapter statisticProductTableAdapter;
        private ComputerStoreDataSet computerStoreDataSet;
        private System.Windows.Forms.BindingSource statisticProductBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControlStock;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStatistic;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnStaProduct;
        private DevExpress.XtraBars.BarButtonItem btnStaStockIn;
        private DevExpress.XtraBars.BarButtonItem btnStaStockOut;
        private DevExpress.XtraCharts.ChartControl chartControlWH;
        private DevExpress.XtraCharts.ChartControl chartControlProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnStaWH;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}