using DevExpress.XtraEditors;
using ManagementStore.Extensions;
using ManagementStore.Model;
using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStore.Form.User
{
    public partial class Profile : DevExpress.XtraEditors.XtraForm
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-2EUHBHG\SQLEXPRESS;Initial Catalog=ComputerStore;Persist Security Info=True;User ID=sa;Password=Password@123"); //open connection to SQL Server
        UserServices user = new UserServices();

        public Profile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.Firstname = txtFirstName.Text;
            appUser.Lastname = txtLastName.Text;
            appUser.Email = txtEmail.Text;
            appUser.Address = txtAddress.Text;
            appUser.Phone = txtPhone.Text;
            appUser.Username = txtUsername.Text;
            appUser.Password = PasswordExtensions.HashPassword(txtPassword.Text);
            var result = user.RegisterUser(appUser,CurrentUser.AppUser.Id);
            if(result.Success == true)
            {
                XtraMessageBox.Show(result.Message, "Changed Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(result.Message, "Changed Not Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picProfile.Image = new Bitmap(open.FileName);
            }
        }
    }
}