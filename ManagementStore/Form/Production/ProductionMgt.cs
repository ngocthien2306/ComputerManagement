using DevExpress.XtraBars;
using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagementStore.Form.Production
{
    public partial class ProductionMgt : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ProductServices productServices = new ProductServices();
        public ProductionMgt()
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
            accordionControlStorage.Expanded = true;
            accordionControlClear.Expanded = true;
            accordionControlExitForm.Expanded = true;

            var categorys = productServices.GetListCategory();
            var brands = productServices.GetListBrand();

            ccbPCategory.DataSource = categorys;
            ccbPCategory.DisplayMember = "Name";
            ccbPCategory.ValueMember = "Id";

            ccbPBrand.DataSource = brands;
            ccbPBrand.DisplayMember = "Name";
            ccbPBrand.ValueMember = "Name";
         
        }

        
    }
}
