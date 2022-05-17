using DevExpress.XtraEditors;
using ManagementStore.Extensions;
using ManagementStore.Model;
using ManagementStore.Services;
using ManagementStore.Form.Production;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace ManagementStore.Form.Employee
{
    public partial class AdminMgt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductServices productServices = new ProductServices();
        WarehouseServices warehouseServices = new WarehouseServices();
        public AdminMgt()
        {
            InitializeComponent();
        }

        private void ProductionMgt_Load(object sender, EventArgs e)
        {


           // LoadOptionSearch();



            //ClearOptionSearch();

           // gridControlProduct.DataSource = GetListProduct();

        }
        public void ClearOptionSearch()
        {
            ccbFirstName.Text = "";
            ccbPermission.Text = "";
            ccbLastName.Text = "";
            txtInputCreateAt.Text = "";
            txtInputUsername2.Text = "";
        }
        public void LoadOptionSearch()
        {
           /* string query = "";

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();
            warehouses.Add(new WareHouse { WHId = 1, WHName = "All", Capacity = -1, WHCode = "All" });
            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });
            var rams = productServices.GetListData(query, new object[1] { "RAMS00" }, new string[1] { "@GroupCode" });
            var prices = productServices.GetListData(query, new object[1] { "PRIP00" }, new string[1] { "@GroupCode" });
            /*
            ccbCategory.DataSource = categorys;
            ccbCategory.DisplayMember = "Name";
            ccbCategory.ValueMember = "Id";
            ccbCategory.SelectedValue = 1002;

            ccbPermission.DataSource = brands;
            ccbPermission.DisplayMember = "Name";
            ccbPermission.ValueMember = "ID";
            ccbPermission.SelectedValue = "BRAS01";

            ccbRams.DataSource = rams;
            ccbRams.DisplayMember = "Name";
            ccbRams.ValueMember = "ID";
            ccbRams.SelectedValue = "RAMS01";

            ccbLastName.DataSource = prices;
            ccbLastName.DisplayMember = "Name";
            ccbLastName.ValueMember = "ID";
            ccbLastName.SelectedValue = "PRIP01";

            ccbFirstName.DataSource = warehouses;
            ccbFirstName.DisplayMember = "WHName";
            ccbFirstName.ValueMember = "WHCode";
            ccbFirstName.SelectedValue = "All";
            */
        }

        
        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


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
           /* string productId = txtInputUsername.Text;
            if (productId.Equals(""))
            {
                XtraMessageBox.Show("Please input Product ID to open edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                Product product = productServices.GetOneProduct(Convert.ToInt32(productId));
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
                    //this.Hide();
                }

            }*/
        }
        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void txtInputProductId_Validating(object sender, CancelEventArgs e)
        {
           /* if (string.IsNullOrEmpty(txtInputUsername.Text))
            {
                errorProviderProductID.SetError(txtInputUsername, "Please input product id!");
            }
            else
            {
                errorProviderProductID.SetError(txtInputUsername, null);
            }*/
        }


        private void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* string path = "production.xlsx";
            //gridViewProduct.Focused = false;
            gridViewProduct.ExportToXlsx(path);
            Process.Start(path);*/
        }

        private void txtInputProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextEdit).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
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
           /* int selectedRows = cardViewProduct.GetSelectedRows()[0];

            if (selectedRows >= 0)
            {
                var cellValue = cardViewProduct.GetRowCellValue(selectedRows, "PId");
                txtInputUsername.Text = cellValue.ToString();
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
            }*/
        }

        private void btnStockOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* StockOut stockOut = new StockOut();
            stockOut.ShowDialog();*/
        }

        private void btnHistoryStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*HistoryStock historyStock = new HistoryStock();
            historyStock.ShowDialog();*/
        }
    }
}
