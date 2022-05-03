using DevExpress.XtraBars;
using ManagementStore.Form.Production;
using ManagementStore.Form.User;
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
    }
}