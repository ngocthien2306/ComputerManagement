using DevExpress.XtraEditors;
using InfrastructureCore.DatabaseEngines.DAL;
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


namespace ManagementStore.Form.User
{
    public partial class LoginUser : DevExpress.XtraEditors.XtraForm
    {
        public LoginUser()
        {
            InitializeComponent();
        }
        UserServices userServices = new UserServices();

        private void LoginUser_Load(object sender, EventArgs e)
        {
            txtInputPassword.Text = "user123456";
            txtInputUsername.Text = "ngocthien";
            radioBtnStaff.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtInputUsername.Text;
            string password = txtInputPassword.Text;
            var role = radioBtnAdmin.Checked == true ? 1 : radioBtnStaff.Checked ? 2 : 3;
            var result = userServices.LoginUser(username, password, role);
            if(result.Success && result.Data.ToString() == "2")
            {
                Main main = new Main();
                main.Show();
                Hide();
            }
            else if(result.Success && result.Data.ToString() == "3")
            {
                Main main = new Main();
                main.Show();
                Hide();
            }
            else
            {
                XtraMessageBox.Show(result.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void hyperLinkRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();

        }
    }
}