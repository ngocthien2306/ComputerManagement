using DevExpress.XtraBars;
using ManagementStore.Extensions;
using ManagementStore.Model;
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
    public partial class HistoryStock : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductServices productServices = new ProductServices();
        WarehouseServices warehouseServices = new WarehouseServices();
        public HistoryStock()
        {
            InitializeComponent();
        }

        private void HistoryStock_Load(object sender, EventArgs e)
        {
            LoadOptionSearch();
            startDateHis.Text = DateTime.Now.ToString();
            endDateHis.Text = DateTime.Now.ToString();
            gridControlHistory.DataSource = GetListProduct();
        }
        public void LoadOptionSearch()
        {
            string query = "";

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();


            warehouses.Add(new WareHouse { WHId = 1, WHName = "All", Capacity = -1, WHCode = "All" });
            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });
            var typeStocks = productServices.GetListData(query, new object[1] { "STOC00" }, new string[1] { "@GroupCode" });
            var rams = productServices.GetListData(query, new object[1] { "RAMS00" }, new string[1] { "@GroupCode" });

            ccbCategory.DataSource = categorys;
            ccbCategory.DisplayMember = "Name";
            ccbCategory.ValueMember = "Id";
            ccbCategory.SelectedValue = 1002;

            ccbBrands.DataSource = brands;
            ccbBrands.DisplayMember = "Name";
            ccbBrands.ValueMember = "ID";
            ccbBrands.SelectedValue = "BRAS01";

            ccbWarehouse.DataSource = warehouses;
            ccbWarehouse.DisplayMember = "WHName";
            ccbWarehouse.ValueMember = "WHCode";
            ccbWarehouse.SelectedValue = "All";

            ccbStockInorOut.DataSource = typeStocks;
            ccbStockInorOut.DisplayMember = "Name";
            ccbStockInorOut.ValueMember = "ID";
            ccbStockInorOut.SelectedValue = "STOC01";

            ccbRams.DataSource = rams;
            ccbRams.DisplayMember = "Name";
            ccbRams.ValueMember = "ID";
            ccbRams.SelectedValue = "RAMS01";


         
        }
        public DataTable GetListProduct()
        {
            // using function to select product data
            string query = @"select * from[dbo].[HistoryStockItem](@ProductName, @Brands, @Category, @Rams, @UserId, @WHCode, @StartDate, @EndDate, @TypeStock)";
            string[] arrParams = new string[9];
            arrParams[0] = "@ProductName";
            arrParams[1] = "@Brands";
            arrParams[2] = "@Category";
            arrParams[3] = "@Rams";
            arrParams[4] = "@UserId";
            arrParams[5] = "@WHCode";
            arrParams[6] = "@StartDate";
            arrParams[7] = "@EndDate";
            arrParams[8] = "@TypeStock";
           

            object[] arrParamsValue = new object[9];
            arrParamsValue[0] = txtInputPName.Text;
            arrParamsValue[1] = ccbBrands.Text == "All" ? "" : ccbBrands.SelectedValue.ToString();
            arrParamsValue[2] = ccbCategory.Text == "All" ? 0 : Convert.ToInt32(ccbCategory.SelectedValue.ToString());
            arrParamsValue[3] = ccbRams.Text == "All" ? "" : ccbRams.SelectedValue.ToString();
            arrParamsValue[4] = CurrentUser.AppUser.Id;
            arrParamsValue[5] = ccbWarehouse.Text == "All" ? "" : ccbWarehouse.SelectedValue.ToString();
            arrParamsValue[6] = startDateHis.Text;
            arrParamsValue[7] = endDateHis.Text;
            arrParamsValue[8] = ccbStockInorOut.Text == "All" ? "" : ccbStockInorOut.SelectedValue.ToString();
            var historyStocks = productServices.GetListData(query, arrParamsValue, arrParams);
            return historyStocks;
        }
    }
}