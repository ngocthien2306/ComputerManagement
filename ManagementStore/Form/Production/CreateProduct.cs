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
        public CreateProduct()
        {
            InitializeComponent();
        }

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

            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });
            var rams = productServices.GetListData(query, new object[1] { "RAMS00" }, new string[1] { "@GroupCode" });

            ccbPCategory.DataSource = categorys;
            ccbPCategory.DisplayMember = "Name";
            ccbPCategory.ValueMember = "Id";

            ccbPBrand.DataSource = brands;
            ccbPBrand.DisplayMember = "Name";
            ccbPBrand.ValueMember = "ID";

            ccbRam.DataSource = rams;
            ccbRam.DisplayMember = "Name";
            ccbRam.ValueMember = "ID";
         
        }
        private Product GetDataProduct()
        {
            Product product = new Product();
            MemoryStream pic = new MemoryStream();
            picturePImage.Image.Save(pic, picturePImage.Image.RawFormat);
            product.ProductName = txtPName.Text;
            product.Price = Convert.ToDecimal(txtPPrice.Text);
            product.Brand = ccbPBrand.SelectedValue.ToString();
            product.CategoryId = Convert.ToInt32(ccbPCategory.SelectedValue.ToString());
            product.Mainboard = txtMainboard.Text;
            product.CPU = txtCPU.Text;
            product.RAM = ccbPBrand.SelectedValue.ToString();
            product.VGA = txtVGA.Text;
            product.SSD = txtSSD.Text;
            product.HDD = txtHDD.Text;
            product.Picture = pic.ToArray();
            return product;
        }

        private void accordionBtnSave_Click(object sender, EventArgs e)
        {
            var product = GetDataProduct();
            var result = productServices.CreateProduct(product, CurrentUser.AppUser.Id);
            if(result.Success)
            {
                XtraMessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XtraMessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void accordionBtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
