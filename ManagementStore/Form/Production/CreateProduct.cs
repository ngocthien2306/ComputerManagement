using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ManagementStore.Model;
using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagementStore.Form.Production
{
    public partial class CreateProduct : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ProductServices productServices = new ProductServices();
        WarehouseServices warehouseServices = new WarehouseServices();
        public CreateProduct()
        {
            InitializeComponent();
        }
        // Event btn click
        #region
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picturePImage.Image = Image.FromFile(open.FileName);
            }
        }

        private void ProductionMgt_Load(object sender, EventArgs e)
        {
            string query = "";
            accordionControlStorage.Expanded = true;
            accordionControlClear.Expanded = true;
            accordionControlExitForm.Expanded = true;

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();

            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });
            var rams = productServices.GetListData(query, new object[1] { "RAMS00" }, new string[1] { "@GroupCode" });

            ccbPCategory.DataSource = categorys;
            ccbPCategory.DisplayMember = "Name";
            ccbPCategory.ValueMember = "Id";

            ccbPBrand.DataSource = brands;
            ccbPBrand.DisplayMember = "Name";
            ccbPBrand.ValueMember = "ID";
            ccbPBrand.SelectedValue = "BRAS02";

            ccbRam.DataSource = rams;
            ccbRam.DisplayMember = "Name";
            ccbRam.ValueMember = "ID";
            ccbRam.SelectedValue = "RAMS04";

            ccbWarehouse.DataSource = warehouses;
            ccbWarehouse.DisplayMember = "WHName";
            ccbWarehouse.ValueMember = "WHCode";


        }

        private void accordionBtnSave_Click(object sender, EventArgs e)
        {
            SaveDataProduct();
        }

        private void accordionBtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void accordionBtnSaveClose_Click(object sender, EventArgs e)
        {
            SaveDataProduct();
            Hide();
        }

        private void accordionBtnDelete_Click(object sender, EventArgs e)
        {
            string PId = txtInputProductId.Text;
            if (PId != "")
            {
                DialogResult delete = MessageBox.Show("Are you sure delete product with id: " + PId, "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    var result = productServices.DeleteProduct(Convert.ToInt32(PId));
                    if(result.Success)
                    {
                        XtraMessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputData();
                    }
                    else
                    {
                        XtraMessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Please input Product ID to open edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void accordionBtnClear_Click(object sender, EventArgs e)
        {
            ClearInputData();
        }


        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            string productId = txtInputProductId.Text;
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
                    ClearInputData();
                }
                else
                {       
                    MemoryStream pic = new MemoryStream(product.Picture);
                    txtPName.Text = product.ProductName;
                    txtPPrice.Text = product.Price.ToString();
                    txtMainboard.Text = product.Mainboard;
                    txtCPU.Text = product.CPU;
                    txtHDD.Text = product.HDD;
                    txtSSD.Text = product.SSD;
                    txtVGA.Text = product.VGA;
                    ccbPBrand.SelectedValue = product.Brand;
                    ccbPCategory.SelectedValue = product.CategoryId;
                    ccbRam.SelectedValue = product.RAM;
                    picturePImage.Image = Image.FromStream(pic);
                    txtInputProductId.Text = product.PId.ToString();
                    groupWH.Enabled = false;
                    //this.Hide();
                }

            }
        }
        #endregion

        // Proccess data
        #region
        public void ClearInputData()
        {
            txtPName.Text = "";
            txtPPrice.Text = "";
            //ccbPBrand.Text = "";
            //ccbPCategory.Text = "";
            //ccbRam.Text = "";
            txtCPU.Text = "";
            txtHDD.Text = "";
            txtMainboard.Text = "";
            txtVGA.Text = "";
            txtSSD.Text = "";
        }

   
        private Product GetDataProduct()
        {
            Product product = new Product();

            string productId = txtInputProductId.Text;
            product.PId = productId == "" ? 0 : Convert.ToInt32(productId);

            MemoryStream pic = new MemoryStream();
            picturePImage.Image.Save(pic, picturePImage.Image.RawFormat);
            product.ProductName = txtPName.Text;
            product.Price = Convert.ToDecimal(txtPPrice.Text);
            product.Brand = ccbPBrand.SelectedValue.ToString();
            product.CategoryId = Convert.ToInt32(ccbPCategory.SelectedValue.ToString());
            product.Mainboard = txtMainboard.Text;
            product.CPU = txtCPU.Text;
            product.RAM = ccbRam.SelectedValue.ToString();
            product.VGA = txtVGA.Text;
            product.SSD = txtSSD.Text;
            product.HDD = txtHDD.Text;
            product.Picture = pic.ToArray();
            return product;
        }
        public void SaveDataProduct()
        {
            var product = GetDataProduct();
            int quantity = Convert.ToInt32(numericQuantity.Value);
            string whCode = ccbWarehouse.SelectedValue.ToString();
            var result = productServices.CreateProduct(product, quantity, whCode, CurrentUser.AppUser.Id);
            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XtraMessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        #endregion

        private void numericQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as NumericUpDown).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
