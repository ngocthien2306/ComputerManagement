using DevExpress.XtraEditors;
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
    public partial class ProductionMgt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductServices productServices = new ProductServices();
        decimal startPrice = 0;
        decimal endPrice = 0;
        decimal max = 999999999;
        public ProductionMgt()
        {
            InitializeComponent();
        }

        private void ProductionMgt_Load(object sender, EventArgs e)
        {
            string query = "";
            var categorys = productServices.GetListCategory();

            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] {"BRAS00"}, new string[1] { "@GroupCode" });
            var rams = productServices.GetListData(query, new object[1] { "RAMS00" }, new string[1] { "@GroupCode" });
            var prices = productServices.GetListData(query, new object[1] { "PRIP00" }, new string[1] { "@GroupCode" });

            ccbCategory.DataSource = categorys;
            ccbCategory.DisplayMember = "Name";
            ccbCategory.ValueMember = "Id";

            ccbBrands.DataSource = brands;
            ccbBrands.DisplayMember = "Name";
            ccbBrands.ValueMember = "ID";

            ccbRams.DataSource = rams;
            ccbRams.DisplayMember = "Name";
            ccbRams.ValueMember = "ID";

            ccbPrice.DataSource = prices;
            ccbPrice.DisplayMember = "Name";
            ccbPrice.ValueMember = "ID";

            ccbCategory.Text = "";
            ccbBrands.Text = "";
            ccbRams.Text = "";
            ccbPrice.Text = "";


            GetListProduct();
        }

        public void PriceOptionSearch()
        {
            string price = ccbPrice.Text;
            if(price != "")
            {
                price = ccbPrice.SelectedValue.ToString();
            }
            
            if (ccbPrice.Text == "")
            {
                startPrice = 0;
                endPrice = max;
            }
            else if (price == "PRIP01")
            {
                startPrice = 0;
                endPrice = 5000000;
            }
            else if (price == "PRIP02")
            {
                startPrice = 5000000;
                endPrice = 1000000;
            }
            else if (price == "PRIP03")
            {
                startPrice = 10000000;
                endPrice = 15000000;
            }
            else if (price == "PRIP04")
            {
                startPrice = 15000000;
                endPrice = 20000000;
            }
            else if (price == "PRIP05")
            {
                startPrice = 20000000;
                endPrice = 30000000;
            }
            else if (price == "PRIP06")
            {
                startPrice = 30000000;
                endPrice = max;
            }

        }
        public void GetListProduct()
        {
            
            string query = @"select * from[dbo].[GetListProduct](@ProductName, @Brands, @Category, @Rams, @StartPrice, @EndPrice, @UserId)";
            PriceOptionSearch();
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
            arrParamsValue[1] = ccbBrands.Text == "" ? "" : ccbBrands.SelectedValue.ToString();
            arrParamsValue[2] = ccbCategory.Text == "" ? 0 : Convert.ToInt32(ccbCategory.SelectedValue.ToString());
            arrParamsValue[3] = ccbRams.Text == "" ? "" : ccbRams.SelectedValue.ToString();
            arrParamsValue[4] = startPrice;
            arrParamsValue[5] = endPrice;
            arrParamsValue[6] = CurrentUser.AppUser.Id;

            var products = productServices.GetListData(query, arrParamsValue, arrParams);

            gridControlProduct.DataSource = products;
            gridViewProduct.EditingValue = false;
       
        }
        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetListProduct();
        }

        private void barBtnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ShowDialog();
        }

        private void gridViewProduct_DoubleClick(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ShowDialog();
        }
    }
}