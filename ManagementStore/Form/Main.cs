using DevExpress.XtraBars;
using ManagementStore.Form.Production;
using ManagementStore.Form.User;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStore.Form
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        UserServices userServices = new UserServices();
        private void Main_Load(object sender, EventArgs e)
        {
         
        }

        private void barBtn_Logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginUser loginUser = new LoginUser();
            loginUser.Show();
            Hide();
        }

        private void barBtnCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ShowDialog();
        }

        private void barBtnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductionMgt productionMgt = new ProductionMgt();
            productionMgt.ShowDialog();
        }

        private void barBtnSearchProduct_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnStatisticProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.ShowDialog();
        }

        private void barBtn_Profile_ItemClick(object sender, ItemClickEventArgs e)
        {
            var user = userServices.GetUserByUsername(CurrentUser.AppUser.Username, CurrentUser.AppUser.TypeId.ToString());
            Profile profile = new Profile();
            if(user != null)
            {
                MemoryStream pic = new MemoryStream(user.Picture);
                profile.txtInputFirstname.Text = user.Firstname;
                profile.txtInputLastname.Text = user.Lastname;
                profile.txtInputEmail.Text = user.Email;
                profile.txtInputAddress.Text = user.Address;
                profile.txtInputPhone.Text = user.Phone;
                profile.birthdayDate.Text = user.Birthday.ToString();
                profile.txtInputUsername.Text = user.Username;
                profile.PictureEditUser.Image = Image.FromStream(pic);

                profile.ShowDialog();

            }
        }
    }
}