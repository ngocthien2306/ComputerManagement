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
            Profile profile = new Profile();
            var user = userServices.GetUserByUsername(CurrentUser.AppUser.Username, CurrentUser.AppUser.TypeId.ToString());
            profile.txtFirstName.Text = user.Firstname;
            profile.txtLastName.Text = user.Lastname;
            profile.txtEmail.Text = user.Email;
            profile.txtAddress.Text = user.Address;
            profile.txtPhone.Text = user.Phone;
            profile.txtUsername.Text = user.Username;
            profile.ShowDialog();
        }
    }
}