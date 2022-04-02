using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AppUser user = new AppUser();

            user.Firstname = txtInputFirstname.Text;
            user.Lastname = txtInputLastname.Text;
            user.Email = txtInputEmail.Text;
            user.Username = txtInputUsername.Text;
            user.Password = txtInputPassword.Text;
            string RePass = txtInputRePassword.Text;
            ValidateExtensions validate = new ValidateExtensions();
            if(validate.ValidatePassword(user.Password, RePass))
            {
                var result = userServices.RegisterUser(user, "Guest");

                if(result.Success)
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
                XtraMessageBox.Show("Error", "Password not match", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtInputFirstname.Text = "Nguyen";
            txtInputLastname.Text = "Thien";
            txtInputEmail.Text = "example@gmail.com";
            txtInputPassword.Text = "user123456";
            txtInputRePassword.Text = "user123456";

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
    }
}