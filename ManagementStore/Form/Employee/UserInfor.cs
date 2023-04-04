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

namespace ManagementStore.Form.Employee
{
    public partial class UserInfor : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        UserServices userServices = new UserServices();
        public UserInfor()
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
                PictureEditUser.Image = Image.FromFile(open.FileName);
            }
        }

        private void ProductionMgt_Load(object sender, EventArgs e)
        {
            string query = "";
            accordionControlStorage.Expanded = true;
            accordionControlClear.Expanded = true;
            accordionControlExitForm.Expanded = true;

            var role = userServices.GetListRole();
            ccbPermission.DataSource = role;
            ccbPermission.DisplayMember = "TypeName";
            ccbPermission.ValueMember = "TypeId";

        }

        private void accordionBtnSave_Click(object sender, EventArgs e)
        {
            SaveDataUser();
        }

        private void accordionBtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void accordionBtnSaveClose_Click(object sender, EventArgs e)
        {
            SaveDataUser();
            Hide();
        }

        private void accordionBtnDelete_Click(object sender, EventArgs e)
        {
            string username = txtInputUsername.Text;
            if (username != "")
            {
                DialogResult delete = MessageBox.Show("Are you sure delete user: " + username, "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    var result = userServices.DeleteUser(username);
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
                XtraMessageBox.Show("Please input username to textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void accordionBtnClear_Click(object sender, EventArgs e)
        {
            ClearInputData();
        }


        private void btnFindProduct_Click(object sender, EventArgs e)
        {
           /* string productId = txtInputProductId.Text;
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

            }*/
        }
        #endregion

        // Proccess data
        #region
        public void ClearInputData()
        {
          
        }

   
        private AppUser GetDataUser()
        {
            AppUser user = new AppUser();
            MemoryStream pic = new MemoryStream();

            PictureEditUser.Image.Save(pic, PictureEditUser.Image.RawFormat);


            user.Username = txtInputUsername.Text;
            user.Firstname = txtInputFirstname.Text;
            user.Lastname = txtInputLastname.Text;
            user.Email = txtInputEmail.Text;
            user.Phone = txtInputPhone.Text;
            user.Address = txtInputAddress.Text;
            user.Birthday = birthdayDate.DateTime;
            user.Picture = pic.ToArray();
            user.TypeId = Convert.ToInt32(ccbPermission.SelectedIndex.ToString());

            return user;
        }
        public void SaveDataUser()
        {
            var user = GetDataUser();
            var result = userServices.SaveUser(user, CurrentUser.AppUser.Id);
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureEditUser.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
