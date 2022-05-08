using DevExpress.XtraEditors;
using ManagementStore.Extensions;
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
        WarehouseServices warehouseServices = new WarehouseServices();

        public ProductionMgt()
        {
            InitializeComponent();
        }

        private void ProductionMgt_Load(object sender, EventArgs e)
        {


            LoadOptionSearch();



            //ClearOptionSearch();

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
        public void LoadOptionSearch()
        {
            string query = "";

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();
            warehouses.Add(new WareHouse {WHId = 1, WHName = "All", Capacity = -1, WHCode = "All" });
            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });
            var rams = productServices.GetListData(query, new object[1] { "RAMS00" }, new string[1] { "@GroupCode" });
            var prices = productServices.GetListData(query, new object[1] { "PRIP00" }, new string[1] { "@GroupCode" });

            ccbCategory.DataSource = categorys;
            ccbCategory.DisplayMember = "Name";
            ccbCategory.ValueMember = "Id";
            ccbCategory.SelectedValue = 1002;

            ccbBrands.DataSource = brands;
            ccbBrands.DisplayMember = "Name";
            ccbBrands.ValueMember = "ID";
            ccbBrands.SelectedValue = "BRAS01";

            ccbRams.DataSource = rams;
            ccbRams.DisplayMember = "Name";
            ccbRams.ValueMember = "ID";
            ccbRams.SelectedValue = "RAMS01";

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
            SearchExtensions.PriceOptionSearch(price);
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
            arrParamsValue[3] = ccbRams.Text == "All" ? "" : ccbRams.SelectedValue.ToString();
            arrParamsValue[4] = SearchExtensions.StartPrice;
            arrParamsValue[5] = SearchExtensions.EndPrice;
            arrParamsValue[6] = CurrentUser.AppUser.Id;
            arrParamsValue[7] = ccbWarehouse.Text == "All" ? "" : ccbWarehouse.SelectedValue.ToString();

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
                    createProduct.groupWH.Enabled = false;
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


        private void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = "production.xlsx";
            //gridViewProduct.Focused = false;
            gridViewProduct.ExportToXlsx(path);
            Process.Start(path);
        }

        private void txtInputProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextEdit).Text.IndexOf('.') > -1))
            {   
                e.Handled = true;
            }
        }

        private void btnStockIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StockIn stockIn = new StockIn();
            stockIn.ShowDialog();
        }

        private void cardViewProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //int selectedRows = cardViewProduct.GetSelectedRows()[0];

            //if (selectedRows >= 0)
            //{
            //    var cellValue = cardViewProduct.GetRowCellValue(selectedRows, "PId");
            //    txtInputProductId.Text = cellValue.ToString();
            //}
        }

        private void cardViewProduct_Click(object sender, EventArgs e)
        {
            int selectedRows = cardViewProduct.GetSelectedRows()[0];

            if (selectedRows >= 0)
            {
                var cellValue = cardViewProduct.GetRowCellValue(selectedRows, "PId");
                txtInputProductId.Text = cellValue.ToString();
                Product product = productServices.GetOneProduct(Convert.ToInt32(cellValue));
                if (product == null)
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
                    createProduct.groupWH.Enabled = false;
                    createProduct.txtInputProductId.Enabled = false;
                    createProduct.btnFindProduct.Enabled = false;
                    
                    //this.Hide();
                }
            }
        }

        private void btnStockOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StockOut stockOut = new StockOut();
            stockOut.ShowDialog();
        }
    }
}