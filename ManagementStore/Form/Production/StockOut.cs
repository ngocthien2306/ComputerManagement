using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class StockOut : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductServices productServices = new ProductServices();
        WarehouseServices warehouseServices = new WarehouseServices();
        public StockOut()
        {
            InitializeComponent();
        }
        public void LoadOptionSearch()
        {
            string query = "";

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();

            ccbWHSave.DataSource = warehouses;
            ccbWHSave.DisplayMember = "WHName";
            ccbWHSave.ValueMember = "WHCode";
            ccbWHSave.SelectedValue = 2;

            warehouses.Add(new WareHouse { WHId = 1, WHName = "All", Capacity = -1, WHCode = "All" });
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
            ccbWarehouse.SelectedValue = "All";

        }

        public DataTable GetListProduct()
        {
            // using function to select product data
            string query = @"select * from[dbo].[GetListProduct](@ProductName, @Brands, @Category, @Rams, @StartPrice, @EndPrice, @UserId, @WHCode)";
            string price = ccbPrice.SelectedValue.ToString();
            OptionSearchExtensions.PriceOptionSearch(price);
            string[] arrParams = new string[8];
            arrParams[0] = "@ProductName";
            arrParams[1] = "@Brands";
            arrParams[2] = "@Category";
            arrParams[3] = "@Rams";
            arrParams[4] = "@StartPrice";
            arrParams[5] = "@EndPrice";
            arrParams[6] = "@UserId";
            arrParams[7] = "@WHCode";

            object[] arrParamsValue = new object[8];
            arrParamsValue[0] = txtInputPName.Text;
            arrParamsValue[1] = ccbBrands.Text == "All" ? "" : ccbBrands.SelectedValue.ToString();
            arrParamsValue[2] = ccbCategory.Text == "All" ? 0 : Convert.ToInt32(ccbCategory.SelectedValue.ToString());
            arrParamsValue[3] = "";
            arrParamsValue[4] = OptionSearchExtensions.StartPrice;
            arrParamsValue[5] = OptionSearchExtensions.EndPrice;
            arrParamsValue[6] = CurrentUser.AppUser.Id;
            arrParamsValue[7] = ccbWarehouse.Text == "All" ? "" : ccbWarehouse.SelectedValue.ToString();
            var products = productServices.GetListData(query, arrParamsValue, arrParams);
            return products;
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            LoadOptionSearch();

            btnUpdateWH.Enabled = false;

            gridControlProduct.DataSource = GetListProduct();
        }

        private void gridViewProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int selectedRows = gridViewProduct.GetSelectedRows()[0];

            if (selectedRows >= 0)
            {
                var PId = gridViewProduct.GetRowCellValue(selectedRows, "PId");
                var WHCode = gridViewProduct.GetRowCellValue(selectedRows, "WHCode");
                txtInputProductId.Text = PId.ToString();
                ccbWHSave.SelectedValue = WHCode.ToString();
            }
            btnUpdateWH.Enabled = true;
        }

        private void btnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlProduct.DataSource = GetListProduct();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
        }

        private void btnUpdateWH_ItemClick(object sender, ItemClickEventArgs e)
        {
            string wh = ccbWHSave.Text;
            if (wh != "")
            {
                int PId = Convert.ToInt32(txtInputProductId.Text);
                string WHCode = ccbWHSave.SelectedValue.ToString();
                int quantity = (int)numericQuantity.Value;
                var result = warehouseServices.UpdateItemWareHouse(0, quantity, WHCode, PId, CurrentUser.AppUser.Id);
                if (result.Success)
                {
                    XtraMessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControlProduct.DataSource = GetListProduct();

                }
                else
                {
                    XtraMessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Please select warehouse stock in item!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}