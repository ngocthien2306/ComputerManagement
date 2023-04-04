using DevExpress.XtraBars;
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

namespace ManagementStore.Form.Employee
{
    public partial class EmployeeMgt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EmployeeMgt()
        {
            InitializeComponent();
        }
        UserServices userServices = new UserServices();

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeMgt_Load(object sender, EventArgs e)
        {
            var dataUser = userServices.GetDataUser();
            gridControlUser.DataSource = dataUser;
        }

        private void btnSearchUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fname = txtInputPName.Text;
            var dataUser = userServices.GetDataUserBySearch(fname, "");
            gridControlUser.DataSource = dataUser;
        }

        private void gridViewUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
    }
}