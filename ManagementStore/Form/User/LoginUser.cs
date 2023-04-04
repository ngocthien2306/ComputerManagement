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
            txtInputPassword.Text = "";

            radioBtnStaff.Checked = true;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtInputUsername.Text;
            string password = txtInputPassword.Text;
            var role = radioBtnAdmin.Checked == true ? 1 : radioBtnStaff.Checked ? 2 : 3;
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                var result = userServices.LoginUser(username, password, role);
                if (result.Success && result.Data.ToString() == "2")
                {
                    Main main = new Main();
                    main.gridGroupRole.DataSource = groupAccessRole;
                    main.gridUserRole.DataSource = userAccessRole;

                    main.barBtnCreateProduct.Enabled = groupAccessRole[0].CreateYN;
                    main.barBtnEditProduct.Enabled = groupAccessRole[0].EditYN;
                    main.barBtnDeleteProduct.Enabled = groupAccessRole[0].DeleteYN;
                    main.barBtnSearchProduct.Enabled = groupAccessRole[0].SearchYN;
                    main.barBtnSaveProduct.Enabled = groupAccessRole[0].SaveYN;
                    main.barBtnPrintProduct.Enabled = groupAccessRole[0].PrintYN;

                    main.barBtnDeleteSale.Enabled = userAccessRole[0].DeleteYN;
                    main.barBtnSaveSale.Enabled = userAccessRole[0].SaveYN;
                    main.barBtnPrintSale.Enabled = userAccessRole[0].PrintYN;

                    main.labelUsername.Text = "Wellcome " + appUser.Firstname + " " + appUser.Lastname;
      

                    main.Show();
                    Hide();
                }
                else if (result.Success && result.Data.ToString() == "3")
                {
                    Productions productions = new Productions();
                    productions.Show();
                    Hide();
                }
                else
                {
                    userServices.SaveBehaviorUser(appUser.Id, "LOGIN", "");
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
                errorProvider1.SetError(txtInputUsername, "Please input username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtInputUsername, null);
            }

            string roleId = role == "GUEST" ? "4" : role == "EMPLOYEE" ? "3" : "2";
            return roleId;
        }
    }
}