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
using ManagementStore.Form.Production;
using ManagementStore.Extensions;
using ManagementStore.Model.UserModel;

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
            txtInputPassword.Text = "thien123";
            txtInputUsername.Text = "ngocthien";
            radioBtnStaff.Checked = true;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtInputUsername.Text;
            string password = txtInputPassword.Text;
 
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                var result = userServices.LoginUser(username, password);
                var appUser = (AppUser) result.Data;
                
                if (result.Success)
                {
                    var GroupAccessRole = userServices.GetListGroupAccessMenus(appUser.GroupRoleId);
                    var UserAccessRole = userServices.GetListUserAccessMenus(appUser.Id);

                    Main main = new Main();
                    main.gridGroupRole.DataSource = GroupAccessRole;
                    main.gridUserRole.DataSource = UserAccessRole;

                    main.Show();
                    Hide();
                }
                else
                {
                    XtraMessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void hyperLinkRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();

        }

        private void txtInputUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInputUsername.Text)) 
            {
                e.Cancel = true;

                txtInputUsername.Focus();
                dxErrorUsername.SetError(txtInputUsername, "Please input username!");
            }
            else
            {
                e.Cancel = false;
                dxErrorUsername.SetError(txtInputUsername, null);
            }
        }

        private void txtInputPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputPassword.Text))
            {
                e.Cancel = true;

                txtInputPassword.Focus();
                dxErrorPass.SetError(txtInputPassword, "Please input password!");
            }
            else
            {
                e.Cancel = false;
                dxErrorPass.SetError(txtInputPassword, null);
            }
        }
    }
}