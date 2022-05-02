using DevExpress.XtraBars;
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
    public partial class Guest : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Guest()
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


    }
}