using DevExpress.XtraEditors;
using ManagementStore.Extensions;
using ManagementStore.Model;
using ManagementStore.Services;
using ManagementStore.Form.User;
using ManagementStore.Form.Production;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ManagementStore.Form.Behavior;

namespace ManagementStore.Form.Employee
{
    public partial class AdminMgt : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserServices userServices = new UserServices();
        public AdminMgt()
        {
            InitializeComponent();
        }

        private void AdminMgt_Load(object sender, EventArgs e)
        {
           LoadOptionSearch();
           ClearOptionSearch();

           gridControlUser.DataSource = GetListUser();

        }
        public void ClearOptionSearch()
        {
            txtInputUsername2.Text = "";
            txtInputFirstname.Text = "";
            txtInputLastname.Text = "";
            txtInputEmail.Text = "";
            txtInputPhone.Text = "";
        }
        public void LoadOptionSearch()
        {
            
            string query = "";

            var role = userServices.GetListRole();
            role.Add(new Userrole { TypeId = 0, TypeName = "All"});

            ccbPermission.DataSource = role;
            ccbPermission.DisplayMember = "TypeName";
            ccbPermission.ValueMember = "TypeId";
            ccbPermission.SelectedValue = 0;

            ccbUseYN.Text = "All";
        }

        public DataTable GetListUser()
        {
            // using function to select product data
            string query = @"select * from[dbo].[GetListUser](@Username, @Firstname, @Lastname, @Email, @Phone, @TypeId, @UseYN)";
            string[] arrParams = new string[7];
            arrParams[0] = "@Username";
            arrParams[1] = "@Firstname";
            arrParams[2] = "@Lastname";
            arrParams[3] = "@Email";
            arrParams[4] = "@Phone";
            arrParams[5] = "@TypeId";
            arrParams[6] = "@UseYN";

            object[] arrParamsValue = new object[7];
            arrParamsValue[0] = txtInputUsername2.Text;
            arrParamsValue[1] = txtInputFirstname.Text;
            arrParamsValue[2] = txtInputLastname.Text;
            arrParamsValue[3] = txtInputEmail.Text;
            arrParamsValue[4] = txtInputPhone.Text;
            arrParamsValue[5] = ccbPermission.Text == "All" ? 0 : Convert.ToInt32(ccbPermission.SelectedValue.ToString());
            //arrParamsValue[6] = ccbUseYN.Text == "All" ? 5 : Convert.ToInt32(ccbUseYN.SelectedValue.ToString());
            arrParamsValue[6] = 5;

            var users = userServices.GetListData(query, arrParamsValue, arrParams);
            return users;   
        }


        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barBtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlUser.DataSource = GetListUser();
        }

        private void barBtnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserInfor createProduct = new UserInfor();
            createProduct.ShowDialog();
        }
        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetListUser();
        }


        private void cardViewUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void cardViewUser_Click(object sender, EventArgs e)
        {
            int selectedRows = cardViewUser.GetSelectedRows()[0];

            if (selectedRows >= 0)
            {
                var cellValueuname = cardViewUser.GetRowCellValue(selectedRows, "Username");
                txtInputUsername2.Text = cellValueuname.ToString();
                AppUser user = userServices.GetOneUser(cellValueuname.ToString());
                if (user == null)
                {
                    XtraMessageBox.Show("The User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    UserInfor userInfor = new UserInfor();
                    userInfor.Show();
                    MemoryStream pic = new MemoryStream(user.Picture);
                    userInfor.txtInputFirstname.Text = user.Firstname.ToString();
                    userInfor.txtInputLastname.Text = user.Lastname.ToString();
                    userInfor.txtInputEmail.Text = user.Email.ToString();
                    userInfor.txtInputPhone.Text = user.Phone.ToString();
                    userInfor.txtInputAddress.Text = user.Address.ToString();
                    userInfor.birthdayDate.DateTime = user.Birthday;
                    userInfor.txtInputUsername.Text = user.Username.ToString();
                    userInfor.txtInputPassword.Text = user.Password.ToString();
                    userInfor.ccbPermission.SelectedValue = user.TypeId;
                    userInfor.PictureEditUser.Image = Image.FromStream(pic);
                    userInfor.txtInputUsername.Enabled = false;
                }
            }
        }

        private void barbtnCreateUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Register createuser = new Register();
            createuser.hyperLinkLogin.Visible = false;
            createuser.ShowDialog();
        }

        private void barBtnPermissionChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmployeeMgt employeeMgt = new EmployeeMgt();
            employeeMgt.ShowDialog();
        }

        private void barBtnBlock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnBehavior_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BehaviorUser behaviorUser = new BehaviorUser();
            behaviorUser.ShowDialog();
        }
    }
}
