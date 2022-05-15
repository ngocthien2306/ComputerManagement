
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStore.Form.Production
{
    public partial class Statistic : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Statistic()
        {
            InitializeComponent();
        }
        
        ProductServices productServices = new ProductServices();
        private void Statistic_Load(object sender, EventArgs e)
        {

            StockIn();
        }

        private void btnStaProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Product();
        }

        private void btnStaStockIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            StockIn();
        }

        private void btnStaStockOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StockOut();
        }



        public void StockIn()
        {
            chartControlStock.Visible = true;
            XYDiagram diagram = chartControlStock.Diagram as XYDiagram;
            if (diagram != null)
            {
                diagram.AxisX.Title.Text = "Amount";
                diagram.AxisY.Title.Text = "Product Name";

            }
            ChartTitle chartTitle = new ChartTitle();
            chartControlStock.Titles.Clear();
            chartTitle.Text = "Statistic Stock In Product Per Months";
            chartTitle.Alignment = StringAlignment.Center;
            chartControlStock.Titles.AddRange(new ChartTitle[] { chartTitle });
            DataTable table;
            string query = "select * from StatisticStockInAndOut";
            table = productServices.GetDataStatistic(query);
            chartControlStock.DataSource = table;
            chartControlStock.SeriesTemplate.SeriesDataMember = "ProductName";
            chartControlStock.SeriesTemplate.ArgumentDataMember = "ProductName";
            chartControlStock.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "ItemInWH" });

            chartControlProduct.Visible = false;
            chartControlWH.Visible = false;

        }
        public void StockOut()
        {
            chartControlStock.Visible = true;
            ChartTitle chartTitle = new ChartTitle();

            chartControlStock.Titles.Clear();
            chartTitle.Text = "Statistic Stock Out Product Per Months";
            chartTitle.Alignment = StringAlignment.Center;
            chartControlStock.Titles.AddRange(new ChartTitle[] { chartTitle });
   

            DataTable table;
            string query = "select * from StatisticStockInAndOut";
            table = productServices.GetDataStatistic(query);
            chartControlStock.DataSource = table;
            chartControlStock.SeriesTemplate.SeriesDataMember = "ProductName";
            chartControlStock.SeriesTemplate.ArgumentDataMember = "ProductName";
            chartControlStock.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "ItemOutWH" });

            chartControlProduct.Visible = false;
            chartControlWH.Visible = false;
        }
        public void Product()
        {
            chartControlProduct.Visible = true;

            ChartTitle chartTitle = new ChartTitle();
            chartControlProduct.Titles.Clear();
            chartTitle.Text = "Statistic Production Per Months";
            chartTitle.Alignment = StringAlignment.Center;
            chartControlProduct.Titles.AddRange(new ChartTitle[] { chartTitle });

            DataTable table;
            string query = "select * from StatisticProduct";
            table = productServices.GetDataStatistic(query);
            chartControlProduct.DataSource = table;
            chartControlProduct.SeriesTemplate.SeriesDataMember = "CreatedAt";
            chartControlProduct.SeriesTemplate.ArgumentDataMember = "CreatedAt";
            chartControlProduct.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Amount" });

            chartControlStock.Visible = false;
            chartControlWH.Visible = false;
            
        }
        public void Warehouse()
        {
            chartControlWH.Visible = true;

            ChartTitle chartTitle = new ChartTitle();
            chartControlWH.Titles.Clear();
            chartTitle.Text = "Statistic Number OF Product In Stock";
            chartTitle.Alignment = StringAlignment.Center;
            chartControlWH.Titles.AddRange(new ChartTitle[] { chartTitle });

            DataTable table;
            string query = "select * from StatisticWH()";
            table = productServices.GetDataStatistic(query);
            chartControlWH.DataSource = table;
            chartControlWH.SeriesTemplate.SeriesDataMember = "WHName";
            chartControlWH.SeriesTemplate.ArgumentDataMember = "WHName";
            chartControlWH.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Total", "TotalPrice" });

            chartControlProduct.Visible = false;
            chartControlStock.Visible = false;

        }

        private void btnStaWH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Warehouse();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
        }
    }
}