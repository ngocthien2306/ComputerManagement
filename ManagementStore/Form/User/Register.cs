using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using InfrastructureCore;
using ManagementStore.Extensions;
using ManagementStore.Model;
using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStore.Form.User
{
    public partial class Register : DevExpress.XtraEditors.XtraForm
    {

        UserServices userServices = new UserServices();
        public Register()
        {
            InitializeComponent();
        }

        private void hyperLinkLogin_Click(object sender, EventArgs e)
        {
            LoginUser loginUser = new LoginUser();
            loginUser.Show();
            Hide();
          
        }

        public AppUser GetAppUser()
        {
            AppUser user = new AppUser();

            MemoryStream pic = new MemoryStream();

            PictureEditUser.Image.Save(pic, PictureEditUser.Image.RawFormat);
            user.Id = Guid.NewGuid().ToString();
            user.Firstname = txtInputFirstname.Text;
            user.Lastname = txtInputLastname.Text;
            user.Email = txtInputEmail.Text;
            user.Phone = txtInputPhone.Text;
            user.Address = txtInputAddress.Text;
            user.Birthday = birthdayDate.DateTime;
            user.Picture = pic.ToArray();
            user.Username = txtInputUsername.Text;
            user.Password = txtInputPassword.Text;
            user.TypeId = 4;
            return user;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(CheckDataUser())
            {
                var user = GetAppUser();
                string RePass = txtInputRePassword.Text;
                ValidateExtensions validate = new ValidateExtensions();
                Result r = validate.Validate("", user.Email, user.Password, RePass);
                if (r.Success)
                {
                    var result = userServices.RegisterUser(user, "");

                    if (result.Success)
                    {
                        XtraMessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginUser loginUser = new LoginUser();
                        loginUser.Show();
                        Hide();
                    }
                    else
                    {
                        XtraMessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    XtraMessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtInputFirstname.Text = "Nguyen";
            txtInputLastname.Text = "Thien";
            txtInputEmail.Text = "example@gmail.com";
            txtInputPassword.Text = "thien123";
            txtInputRePassword.Text = "thien123";
            birthdayDate.EditValue = "1/1/2000";
            

            // set connection string for guest role
            ConnectionDB.SetConnectionString("group9", "123");
        }


        private void InvokeDefaultCameraDialog()
        {
            TakePictureDialog dialog = new TakePictureDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = dialog.Image;
                using(var stream = new MemoryStream())
                {
                    image.Save(stream, ImageFormat.Jpeg);
                    PictureEditUser.EditValue = stream.ToArray();
                    
                }
            }
        }
        private void PictureEditUser_DoubleClick(object sender, EventArgs e)
        {
            InvokeDefaultCameraDialog();
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            InvokeDefaultCameraDialog();
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

        public bool CheckDataUser()
        {
            if(txtInputFirstname.Text == "")
            {
                XtraMessageBox.Show("Please input firstname!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInputFirstname.Focus();
                return false;
            }
            else if(txtInputLastname.Text == "")
            {

                XtraMessageBox.Show("Please input lastname!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInputLastname.Focus();
                return false;
            }
            else if(txtInputEmail.Text == "")
            {

                XtraMessageBox.Show("Please input email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInputEmail.Focus();
                return false;
            }
            else if(birthdayDate.Text == "")
            {

                XtraMessageBox.Show("Please input birthday!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                birthdayDate.Focus();
                return false;
            }
            else if(txtInputUsername.Text == "")
            {

                XtraMessageBox.Show("Please input username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInputUsername.Focus();
                return false;
            }
            else if(txtInputPassword.Text == "")
            {
                XtraMessageBox.Show("Please input password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInputPassword.Focus();
                return false;
            }
            else if(txtInputRePassword.Text == "")
            {
                XtraMessageBox.Show("Please input re-password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInputRePassword.Focus();
                return false;
            }
            else if(PictureEditUser.Image == null)
            {
                XtraMessageBox.Show("Please select your picture!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PictureEditUser.Focus();
                return false;
            }
            return true;
        }
    }
}