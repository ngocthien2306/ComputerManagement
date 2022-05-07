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
    public partial class StockIn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductServices productServices = new ProductServices();
        WarehouseServices warehouseServices = new WarehouseServices();
        public StockIn()
        {
            InitializeComponent();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            LoadOptionSearch();


            gridControlProduct.DataSource = GetListProduct();
            gridControlProduct.Select();

        }

        public void LoadOptionSearch()
        {
            string query = "";

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();
            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });
            var prices = productServices.GetListData(query, new object[1] { "PRIP00" }, new string[1] { "@GroupCode" });

            ccbCategory.DataSource = categorys;
            ccbCategory.DisplayMember = "Name";
            ccbCategory.ValueMember = "Id";
            ccbCategory.SelectedValue = 1002;

            ccbBrands.DataSource = brands;
            ccbBrands.DisplayMember = "Name";
            ccbBrands.ValueMember = "ID";
            ccbBrands.SelectedValue = "BRAS01";

            ccbPrice.DataSource = prices;
            ccbPrice.DisplayMember = "Name";
            ccbPrice.ValueMember = "ID";
            ccbPrice.SelectedValue = "PRIP01";

            ccbWarehouse.DataSource = warehouses;
            ccbWarehouse.DisplayMember = "WHName";
            ccbWarehouse.ValueMember = "WHCode";


        }

        public DataTable GetListProduct()
        {
            // using function to select product data
            string query = @"select * from[dbo].[GetListProduct](@ProductName, @Brands, @Category, @Rams, @StartPrice, @EndPrice, @UserId)";
            string price = ccbPrice.SelectedValue.ToString();
            OptionSearchExtensions.PriceOptionSearch(price);
            string[] arrParams = new string[7];
            arrParams[0] = "@ProductName";
            arrParams[1] = "@Brands";
            arrParams[2] = "@Category";
            arrParams[3] = "@Rams";
            arrParams[4] = "@StartPrice";
            arrParams[5] = "@EndPrice";
            arrParams[6] = "@UserId";

            object[] arrParamsValue = new object[7];
            arrParamsValue[0] = txtInputPName.Text;
            arrParamsValue[1] = ccbBrands.Text == "All" ? "" : ccbBrands.SelectedValue.ToString();
            arrParamsValue[2] = ccbCategory.Text == "All" ? 0 : Convert.ToInt32(ccbCategory.SelectedValue.ToString());
            arrParamsValue[3] = "";
            arrParamsValue[4] = OptionSearchExtensions.StartPrice;
            arrParamsValue[5] = OptionSearchExtensions.EndPrice;
            arrParamsValue[6] = CurrentUser.AppUser.Id;

            var products = productServices.GetListData(query, arrParamsValue, arrParams);
            return products;
        }

        private void gridViewProduct_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //int selectedRows = gridViewProduct.GetSelectedRows()[0];

            //if (selectedRows >= 0)
            //{
            //    var cellValue = gridViewProduct.GetRowCellValue(selectedRows, "PId");
            //    txtInputProductId.Text = cellValue.ToString();
            //}
            
        }

        private void gridViewProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int selectedRows = gridViewProduct.GetSelectedRows()[0];

            if (selectedRows >= 0)
            {
                var cellValue = gridViewProduct.GetRowCellValue(selectedRows, "PId");
                txtInputProductId.Text = cellValue.ToString();
            }
        }
    }
}