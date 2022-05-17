
namespace ManagementStore.Form.User
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.btnUpdateUser = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.birthdayDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControlAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtInputAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControlPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtInputPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControlEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLname = new DevExpress.XtraEditors.LabelControl();
            this.labelControlFname = new DevExpress.XtraEditors.LabelControl();
            this.txtInputEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtInputLastname = new DevExpress.XtraEditors.TextEdit();
            this.txtInputFirstname = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlRePass = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelControlUsername = new DevExpress.XtraEditors.LabelControl();
            this.txtInputRePassword = new DevExpress.XtraEditors.TextEdit();
            this.txtInputPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtInputUsername = new DevExpress.XtraEditors.TextEdit();
            this.btnTakePicture = new DevExpress.XtraEditors.SimpleButton();
            this.btnUploadImage = new DevExpress.XtraEditors.SimpleButton();
            this.PictureEditUser = new DevExpress.XtraEditors.PictureEdit();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.txtInputOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputRePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputOldPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Appearance.Options.UseForeColor = true;
            this.btnUpdateUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateUser.ImageOptions.SvgImage")));
            this.btnUpdateUser.Location = new System.Drawing.Point(811, 452);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(138, 41);
            this.btnUpdateUser.TabIndex = 4;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.xtraTabControl1);
            this.groupControlInfo.Controls.Add(this.btnTakePicture);
            this.groupControlInfo.Controls.Add(this.btnUploadImage);
            this.groupControlInfo.Controls.Add(this.PictureEditUser);
            this.groupControlInfo.Location = new System.Drawing.Point(12, 32);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(937, 399);
            this.groupControlInfo.TabIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(15, 29);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(561, 347);
            this.xtraTabControl1.TabIndex = 21;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.birthdayDate);
            this.xtraTabPage1.Controls.Add(this.labelControlAddress);
            this.xtraTabPage1.Controls.Add(this.txtInputAddress);
            this.xtraTabPage1.Controls.Add(this.labelControlPhone);
            this.xtraTabPage1.Controls.Add(this.txtInputPhone);
            this.xtraTabPage1.Controls.Add(this.labelControlEmail);
            this.xtraTabPage1.Controls.Add(this.labelControlLname);
            this.xtraTabPage1.Controls.Add(this.labelControlFname);
            this.xtraTabPage1.Controls.Add(this.txtInputEmail);
            this.xtraTabPage1.Controls.Add(this.txtInputLastname);
            this.xtraTabPage1.Controls.Add(this.txtInputFirstname);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(559, 317);
            this.xtraTabPage1.Text = "User Info";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl8.Location = new System.Drawing.Point(330, 275);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(8, 16);
            this.labelControl8.TabIndex = 36;
            this.labelControl8.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(507, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(8, 16);
            this.labelControl7.TabIndex = 35;
            this.labelControl7.Text = "*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(507, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(8, 16);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(507, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(8, 16);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "*";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 275);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Birthday:";
            // 
            // birthdayDate
            // 
            this.birthdayDate.EditValue = null;
            this.birthdayDate.Location = new System.Drawing.Point(137, 272);
            this.birthdayDate.Name = "birthdayDate";
            this.birthdayDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDate.Size = new System.Drawing.Size(187, 22);
            this.birthdayDate.TabIndex = 31;
            // 
            // labelControlAddress
            // 
            this.labelControlAddress.Location = new System.Drawing.Point(33, 227);
            this.labelControlAddress.Name = "labelControlAddress";
            this.labelControlAddress.Size = new System.Drawing.Size(51, 16);
            this.labelControlAddress.TabIndex = 30;
            this.labelControlAddress.Text = "Address:";
            // 
            // txtInputAddress
            // 
            this.txtInputAddress.Location = new System.Drawing.Point(137, 224);
            this.txtInputAddress.Name = "txtInputAddress";
            this.txtInputAddress.Size = new System.Drawing.Size(363, 22);
            this.txtInputAddress.TabIndex = 29;
            // 
            // labelControlPhone
            // 
            this.labelControlPhone.Location = new System.Drawing.Point(33, 176);
            this.labelControlPhone.Name = "labelControlPhone";
            this.labelControlPhone.Size = new System.Drawing.Size(40, 16);
            this.labelControlPhone.TabIndex = 28;
            this.labelControlPhone.Text = "Phone:";
            // 
            // txtInputPhone
            // 
            this.txtInputPhone.Location = new System.Drawing.Point(137, 173);
            this.txtInputPhone.Name = "txtInputPhone";
            this.txtInputPhone.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtInputPhone.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtInputPhone.Properties.MaxLength = 10;
            this.txtInputPhone.Size = new System.Drawing.Size(363, 22);
            this.txtInputPhone.TabIndex = 27;
            // 
            // labelControlEmail
            // 
            this.labelControlEmail.Location = new System.Drawing.Point(33, 124);
            this.labelControlEmail.Name = "labelControlEmail";
            this.labelControlEmail.Size = new System.Drawing.Size(36, 16);
            this.labelControlEmail.TabIndex = 26;
            this.labelControlEmail.Text = "Email:";
            // 
            // labelControlLname
            // 
            this.labelControlLname.Location = new System.Drawing.Point(33, 75);
            this.labelControlLname.Name = "labelControlLname";
            this.labelControlLname.Size = new System.Drawing.Size(60, 16);
            this.labelControlLname.TabIndex = 25;
            this.labelControlLname.Text = "Lastname:";
            // 
            // labelControlFname
            // 
            this.labelControlFname.Location = new System.Drawing.Point(33, 28);
            this.labelControlFname.Name = "labelControlFname";
            this.labelControlFname.Size = new System.Drawing.Size(62, 16);
            this.labelControlFname.TabIndex = 24;
            this.labelControlFname.Text = "Firstname:";
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.Location = new System.Drawing.Point(137, 121);
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.Size = new System.Drawing.Size(363, 22);
            this.txtInputEmail.TabIndex = 20;
            // 
            // txtInputLastname
            // 
            this.txtInputLastname.Location = new System.Drawing.Point(137, 72);
            this.txtInputLastname.Name = "txtInputLastname";
            this.txtInputLastname.Size = new System.Drawing.Size(363, 22);
            this.txtInputLastname.TabIndex = 19;
            // 
            // txtInputFirstname
            // 
            this.txtInputFirstname.Location = new System.Drawing.Point(137, 25);
            this.txtInputFirstname.Name = "txtInputFirstname";
            this.txtInputFirstname.Size = new System.Drawing.Size(363, 22);
            this.txtInputFirstname.TabIndex = 18;
            this.txtInputFirstname.ToolTip = "Enter firstname";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl10);
            this.xtraTabPage2.Controls.Add(this.txtInputOldPassword);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.btnChangePassword);
            this.xtraTabPage2.Controls.Add(this.labelControl6);
            this.xtraTabPage2.Controls.Add(this.labelControl5);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.labelControlRePass);
            this.xtraTabPage2.Controls.Add(this.labelControlPassword);
            this.xtraTabPage2.Controls.Add(this.labelControlUsername);
            this.xtraTabPage2.Controls.Add(this.txtInputRePassword);
            this.xtraTabPage2.Controls.Add(this.txtInputPassword);
            this.xtraTabPage2.Controls.Add(this.txtInputUsername);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(559, 317);
            this.xtraTabPage2.Text = "Change Account Info";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(522, 153);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(8, 16);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(522, 105);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(8, 16);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(522, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(8, 16);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "*";
            // 
            // labelControlRePass
            // 
            this.labelControlRePass.Location = new System.Drawing.Point(32, 198);
            this.labelControlRePass.Name = "labelControlRePass";
            this.labelControlRePass.Size = new System.Drawing.Size(50, 16);
            this.labelControlRePass.TabIndex = 35;
            this.labelControlRePass.Text = "Confirm:";
            // 
            // labelControlPassword
            // 
            this.labelControlPassword.Location = new System.Drawing.Point(32, 150);
            this.labelControlPassword.Name = "labelControlPassword";
            this.labelControlPassword.Size = new System.Drawing.Size(89, 16);
            this.labelControlPassword.TabIndex = 34;
            this.labelControlPassword.Text = "New Password:";
            // 
            // labelControlUsername
            // 
            this.labelControlUsername.Location = new System.Drawing.Point(32, 55);
            this.labelControlUsername.Name = "labelControlUsername";
            this.labelControlUsername.Size = new System.Drawing.Size(63, 16);
            this.labelControlUsername.TabIndex = 33;
            this.labelControlUsername.Text = "Username:";
            // 
            // txtInputRePassword
            // 
            this.txtInputRePassword.Enabled = false;
            this.txtInputRePassword.Location = new System.Drawing.Point(136, 195);
            this.txtInputRePassword.Name = "txtInputRePassword";
            this.txtInputRePassword.Size = new System.Drawing.Size(380, 22);
            this.txtInputRePassword.TabIndex = 32;
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Enabled = false;
            this.txtInputPassword.Location = new System.Drawing.Point(136, 147);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.Size = new System.Drawing.Size(380, 22);
            this.txtInputPassword.TabIndex = 31;
            // 
            // txtInputUsername
            // 
            this.txtInputUsername.Enabled = false;
            this.txtInputUsername.Location = new System.Drawing.Point(136, 52);
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Size = new System.Drawing.Size(380, 22);
            this.txtInputUsername.TabIndex = 30;
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTakePicture.ImageOptions.SvgImage")));
            this.btnTakePicture.Location = new System.Drawing.Point(813, 330);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(108, 45);
            this.btnTakePicture.TabIndex = 20;
            this.btnTakePicture.Text = "Camera";
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUploadImage.ImageOptions.SvgImage")));
            this.btnUploadImage.Location = new System.Drawing.Point(606, 330);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(108, 45);
            this.btnUploadImage.TabIndex = 19;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // PictureEditUser
            // 
            this.PictureEditUser.Location = new System.Drawing.Point(606, 58);
            this.PictureEditUser.Name = "PictureEditUser";
            this.PictureEditUser.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.PictureEditUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.PictureEditUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PictureEditUser.Size = new System.Drawing.Size(315, 243);
            this.PictureEditUser.TabIndex = 18;
            this.PictureEditUser.DoubleClick += new System.EventHandler(this.PictureEditUser_DoubleClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Appearance.Options.UseForeColor = true;
            this.btnChangePassword.Location = new System.Drawing.Point(378, 243);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(138, 27);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtInputOldPassword
            // 
            this.txtInputOldPassword.Location = new System.Drawing.Point(136, 102);
            this.txtInputOldPassword.Name = "txtInputOldPassword";
            this.txtInputOldPassword.Size = new System.Drawing.Size(380, 22);
            this.txtInputOldPassword.TabIndex = 42;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(32, 105);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 16);
            this.labelControl9.TabIndex = 41;
            this.labelControl9.Text = "Old Password:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl10.Location = new System.Drawing.Point(522, 201);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(8, 16);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "*";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 514);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.groupControlInfo);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputRePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputOldPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnUpdateUser;
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlAddress;
        private DevExpress.XtraEditors.LabelControl labelControlPhone;
        private DevExpress.XtraEditors.LabelControl labelControlEmail;
        private DevExpress.XtraEditors.LabelControl labelControlLname;
        private DevExpress.XtraEditors.LabelControl labelControlFname;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControlRePass;
        private DevExpress.XtraEditors.LabelControl labelControlPassword;
        private DevExpress.XtraEditors.LabelControl labelControlUsername;
        private DevExpress.XtraEditors.SimpleButton btnTakePicture;
        private DevExpress.XtraEditors.SimpleButton btnUploadImage;
        public DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.DateEdit birthdayDate;
        public DevExpress.XtraEditors.TextEdit txtInputAddress;
        public DevExpress.XtraEditors.TextEdit txtInputPhone;
        public DevExpress.XtraEditors.TextEdit txtInputEmail;
        public DevExpress.XtraEditors.TextEdit txtInputLastname;
        public DevExpress.XtraEditors.TextEdit txtInputFirstname;
        public DevExpress.XtraEditors.TextEdit txtInputRePassword;
        public DevExpress.XtraEditors.TextEdit txtInputPassword;
        public DevExpress.XtraEditors.TextEdit txtInputUsername;
        public DevExpress.XtraEditors.PictureEdit PictureEditUser;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtInputOldPassword;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}