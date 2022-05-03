using DevExpress.XtraEditors;
using ManagementStore.Model;
using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        decimal max = 200000000;
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




            ClearOptionSearch();

            gridControlProduct.DataSource =  GetListProduct();
        }

        public void ClearOptionSearch()
        {
            ccbCategory.Text = "";
            ccbBrands.Text = "";
            ccbRams.Text = "";
            ccbPrice.Text = "";
            txtInputPName.Text = "";
        }

        public DataTable GetListProduct()
        {
            // using function to select product data
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
            return products;
            //gridControlProduct.DataSource = products;
            //gridViewProduct.EditingValue = false;
       
        }
        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

             gridControlProduct.DataSource = GetListProduct();


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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string productId = txtInputProductId.Text;
            if(productId.Equals(""))
            {
                XtraMessageBox.Show("Please input Product ID to open edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                
                Product product = productServices.GetOneProduct(Convert.ToInt32(productId));
                if(product == null)
                {
                    XtraMessageBox.Show("The product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    CreateProduct createProduct = new CreateProduct();
                    createProduct.Show();
                    MemoryStream pic = new MemoryStream(product.Picture);
                    createProduct.txtPName.Text = product.ProductName;
                    createProduct.txtPPrice.Text = product.Price.ToString();
                    createProduct.txtMainboard.Text = product.Mainboard;
                    createProduct.txtCPU.Text = product.CPU;
                    createProduct.txtHDD.Text = product.HDD;
                    createProduct.txtSSD.Text = product.SSD;
                    createProduct.txtVGA.Text = product.VGA;
                    createProduct.ccbPBrand.SelectedValue = product.Brand;
                    createProduct.ccbPCategory.SelectedValue = product.CategoryId;
                    createProduct.ccbRam.SelectedValue = product.RAM;
                    createProduct.picturePImage.Image = Image.FromStream(pic);
                    createProduct.txtInputProductId.Text = product.PId.ToString();
                    //this.Hide();
                }

            }
        }
        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetListProduct();
        }

        private void txtInputProductId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputProductId.Text))
            {      
                errorProviderProductID.SetError(txtInputProductId, "Please input product id!");
            }
            else
            {             
                errorProviderProductID.SetError(txtInputProductId, null);
            }
        }
        public void PriceOptionSearch()
        {
            try
            {
                string price = ccbPrice.Text;
                if (price != "")
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
                    endPrice = 10000000;
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
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = "production.xlsx";
            //gridViewProduct.Focused = false;
            gridViewProduct.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}