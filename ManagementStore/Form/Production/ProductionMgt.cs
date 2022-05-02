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
    public partial class ProductionMgt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductServices productServices = new ProductServices();

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
        public void GetListProduct()
        {

            string query = @"select * from[dbo].[GetListProduct](@ProductName, @Price, @Brands, @Category, @Rams)";
            string[] arrParams = new string[5];
            arrParams[0] = "@ProductName";
            arrParams[1] = "@Price";
            arrParams[2] = "@Brands";
            arrParams[3] = "@Category";
            arrParams[4] = "@Rams";
            object[] arrParamsValue = new object[5];
            arrParamsValue[0] = txtInputPName.Text;
            arrParamsValue[1] = ccbPrice.Text;
            arrParamsValue[2] = ccbBrands.Text;
            arrParamsValue[3] = ccbBrands.Text == "" ? 0 : Convert.ToInt32(ccbCategory.SelectedValue.ToString());
            arrParamsValue[4] = ccbRams.Text;
            var products = productServices.GetListData(query, arrParamsValue, arrParams);

            gridControlProduct.DataSource = products;
        }
        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetListProduct();
        }
    }
}