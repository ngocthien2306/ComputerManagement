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
            txtInputUsername.Text = "thien123";
            radioBtnStaff.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtInputUsername.Text;
            string password = txtInputPassword.Text;
      
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                var result = userServices.LoginUser(username, password);
                if (result.Success)
                {
                    Main main = new Main();
                    main.Show();
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
                errorProvider1.SetError(txtInputUsername, "Please input username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtInputUsername, null);
            }
        }
    }
}