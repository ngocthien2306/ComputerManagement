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
using ManagementStore.Model;

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
            string role = radioBtnGuest.Checked == true ? "GUEST" : radioBtnStaff.Checked == true ? "EMPLOYEE" : "MANAGER";
            string roleId = SetConnectionStringByRole(role);
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var result = userServices.LoginUser(username, password, roleId);
                AppUser appUser = result.Data as AppUser;

                if(!result.Success)
                {
                    XtraMessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (result.Success && appUser.TypeId == 2)
                {
                    CurrentUser.SetCurrentUser(appUser);
                    Main main = new Main();
                    main.Show();
                    Hide();
                }
                else if (result.Success && appUser.TypeId == 3)
                {
                    CurrentUser.SetCurrentUser(appUser);                    
                    Main main = new Main();
                    main.ribbonPageGroupEmployee.Enabled = false;
                    main.Show();
                    Hide();
                }

                else if (result.Success && appUser.TypeId == 4)
                {
                    CurrentUser.SetCurrentUser(appUser);
                    Guest guest = new Guest();
                    guest.Show();
                    Hide();
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
                errorProviderUsername.SetError(txtInputUsername, "Please input username!");
            }
            else
            {
                e.Cancel = false;
                errorProviderUsername.SetError(txtInputUsername, null);
            }
        }

        private void txtInputPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputPassword.Text))
            {
                e.Cancel = true;

                txtInputPassword.Focus();
                dxErrorProviderPassword.SetError(txtInputPassword, "Please input password!");
            }
            else
            {
                e.Cancel = false;
                dxErrorProviderPassword.SetError(txtInputPassword, null);
            }
        }

        public string SetConnectionStringByRole(string role)
        {

            if (role.Equals("GUEST"))
            {
                ConnectionDB.SetConnectionString("guest", "guest01");
            }
            else if (role.Equals("EMPLOYEE"))
            {
                ConnectionDB.SetConnectionString("employee", "employee01");
            }
            else
            {
                ConnectionDB.SetConnectionString("manager", "manager01");
            }

            string roleId = role == "GUEST" ? "4" : role == "EMPLOYEE" ? "3" : "2";
            return roleId;
        }
    }
}