using DevExpress.XtraBars;
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

            string query = "";

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();
            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });

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

            dataGridViewProduct.DataSource = GetListProduct();
        }

        public DataTable GetListProduct()
        {
            // using function to select product data
            string query = @"select * from[dbo].[GetListProduct](@ProductName, @Brands, @Category, @Rams, @StartPrice, @EndPrice, @UserId)";

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
            arrParamsValue[4] = 0;
            arrParamsValue[5] = 20000000;
            arrParamsValue[6] = CurrentUser.AppUser.Id;

            var products = productServices.GetListData(query, arrParamsValue, arrParams);
            return products;
            //gridControlProduct.DataSource = products;
            //gridViewProduct.EditingValue = false;      
        }

    }
}