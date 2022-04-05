
namespace ManagementStore.Form.User
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtInputFirstname = new DevExpress.XtraEditors.TextEdit();
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.PictureEditUser = new DevExpress.XtraEditors.PictureEdit();
            this.labelControlRePass = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelControlUsername = new DevExpress.XtraEditors.LabelControl();
            this.labelControlEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLname = new DevExpress.XtraEditors.LabelControl();
            this.labelControlFname = new DevExpress.XtraEditors.LabelControl();
            this.txtInputRePassword = new DevExpress.XtraEditors.TextEdit();
            this.txtInputPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtInputUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtInputEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtInputLastname = new DevExpress.XtraEditors.TextEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.hyperLinkLogin = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnUploadImage = new DevExpress.XtraEditors.SimpleButton();
            this.btnTakePicture = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputRePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputFirstname
            // 
            this.txtInputFirstname.Location = new System.Drawing.Point(173, 38);
            this.txtInputFirstname.Name = "txtInputFirstname";
            this.txtInputFirstname.Size = new System.Drawing.Size(392, 22);
            this.txtInputFirstname.TabIndex = 6;
            this.txtInputFirstname.ToolTip = "Enter firstname";
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.btnTakePicture);
            this.groupControlInfo.Controls.Add(this.btnUploadImage);
            this.groupControlInfo.Controls.Add(this.PictureEditUser);
            this.groupControlInfo.Controls.Add(this.labelControlRePass);
            this.groupControlInfo.Controls.Add(this.labelControlPassword);
            this.groupControlInfo.Controls.Add(this.labelControlUsername);
            this.groupControlInfo.Controls.Add(this.labelControlEmail);
            this.groupControlInfo.Controls.Add(this.labelControlLname);
            this.groupControlInfo.Controls.Add(this.labelControlFname);
            this.groupControlInfo.Controls.Add(this.txtInputRePassword);
            this.groupControlInfo.Controls.Add(this.txtInputPassword);
            this.groupControlInfo.Controls.Add(this.txtInputUsername);
            this.groupControlInfo.Controls.Add(this.txtInputEmail);
            this.groupControlInfo.Controls.Add(this.txtInputLastname);
            this.groupControlInfo.Controls.Add(this.txtInputFirstname);
            this.groupControlInfo.Location = new System.Drawing.Point(12, 28);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(937, 382);
            this.groupControlInfo.TabIndex = 0;
            this.groupControlInfo.Text = "User Information";
            // 
            // PictureEditUser
            // 
            this.PictureEditUser.Location = new System.Drawing.Point(606, 41);
            this.PictureEditUser.Name = "PictureEditUser";
            this.PictureEditUser.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.PictureEditUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.PictureEditUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PictureEditUser.Size = new System.Drawing.Size(315, 196);
            this.PictureEditUser.TabIndex = 18;
            this.PictureEditUser.DoubleClick += new System.EventHandler(this.PictureEditUser_DoubleClick);
            // 
            // labelControlRePass
            // 
            this.labelControlRePass.Location = new System.Drawing.Point(69, 342);
            this.labelControlRePass.Name = "labelControlRePass";
            this.labelControlRePass.Size = new System.Drawing.Size(50, 16);
            this.labelControlRePass.TabIndex = 17;
            this.labelControlRePass.Text = "Confirm:";
            // 
            // labelControlPassword
            // 
            this.labelControlPassword.Location = new System.Drawing.Point(69, 279);
            this.labelControlPassword.Name = "labelControlPassword";
            this.labelControlPassword.Size = new System.Drawing.Size(60, 16);
            this.labelControlPassword.TabIndex = 16;
            this.labelControlPassword.Text = "Password:";
            // 
            // labelControlUsername
            // 
            this.labelControlUsername.Location = new System.Drawing.Point(69, 218);
            this.labelControlUsername.Name = "labelControlUsername";
            this.labelControlUsername.Size = new System.Drawing.Size(63, 16);
            this.labelControlUsername.TabIndex = 15;
            this.labelControlUsername.Text = "Username:";
            // 
            // labelControlEmail
            // 
            this.labelControlEmail.Location = new System.Drawing.Point(69, 165);
            this.labelControlEmail.Name = "labelControlEmail";
            this.labelControlEmail.Size = new System.Drawing.Size(36, 16);
            this.labelControlEmail.TabIndex = 14;
            this.labelControlEmail.Text = "Email:";
            // 
            // labelControlLname
            // 
            this.labelControlLname.Location = new System.Drawing.Point(69, 103);
            this.labelControlLname.Name = "labelControlLname";
            this.labelControlLname.Size = new System.Drawing.Size(60, 16);
            this.labelControlLname.TabIndex = 13;
            this.labelControlLname.Text = "Lastname:";
            // 
            // labelControlFname
            // 
            this.labelControlFname.Location = new System.Drawing.Point(69, 41);
            this.labelControlFname.Name = "labelControlFname";
            this.labelControlFname.Size = new System.Drawing.Size(62, 16);
            this.labelControlFname.TabIndex = 12;
            this.labelControlFname.Text = "Firstname:";
            // 
            // txtInputRePassword
            // 
            this.txtInputRePassword.Location = new System.Drawing.Point(173, 339);
            this.txtInputRePassword.Name = "txtInputRePassword";
            this.txtInputRePassword.Size = new System.Drawing.Size(392, 22);
            this.txtInputRePassword.TabIndex = 11;
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Location = new System.Drawing.Point(173, 276);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.Size = new System.Drawing.Size(392, 22);
            this.txtInputPassword.TabIndex = 10;
            // 
            // txtInputUsername
            // 
            this.txtInputUsername.Location = new System.Drawing.Point(173, 215);
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Size = new System.Drawing.Size(392, 22);
            this.txtInputUsername.TabIndex = 9;
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.Location = new System.Drawing.Point(173, 162);
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.Size = new System.Drawing.Size(392, 22);
            this.txtInputEmail.TabIndex = 8;
            // 
            // txtInputLastname
            // 
            this.txtInputLastname.Location = new System.Drawing.Point(173, 100);
            this.txtInputLastname.Name = "txtInputLastname";
            this.txtInputLastname.Size = new System.Drawing.Size(392, 22);
            this.txtInputLastname.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRegister.ImageOptions.SvgImage")));
            this.btnRegister.Location = new System.Drawing.Point(811, 433);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 41);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // hyperLinkLogin
            // 
            this.hyperLinkLogin.Location = new System.Drawing.Point(12, 433);
            this.hyperLinkLogin.Name = "hyperLinkLogin";
            this.hyperLinkLogin.Size = new System.Drawing.Size(157, 16);
            this.hyperLinkLogin.TabIndex = 2;
            this.hyperLinkLogin.Text = "I have a account! login now";
            this.hyperLinkLogin.Click += new System.EventHandler(this.hyperLinkLogin_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(606, 279);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(108, 45);
            this.btnUploadImage.TabIndex = 19;
            this.btnUploadImage.Text = "Upload Image";
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.Location = new System.Drawing.Point(813, 279);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(108, 45);
            this.btnTakePicture.TabIndex = 20;
            this.btnTakePicture.Text = "Camera";
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 532);
            this.Controls.Add(this.hyperLinkLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupControlInfo);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtInputFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputRePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputLastname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.LabelControl labelControlRePass;
        private DevExpress.XtraEditors.LabelControl labelControlPassword;
        private DevExpress.XtraEditors.LabelControl labelControlUsername;
        private DevExpress.XtraEditors.LabelControl labelControlEmail;
        private DevExpress.XtraEditors.LabelControl labelControlLname;
        private DevExpress.XtraEditors.LabelControl labelControlFname;
        private DevExpress.XtraEditors.TextEdit txtInputRePassword;
        private DevExpress.XtraEditors.TextEdit txtInputPassword;
        private DevExpress.XtraEditors.TextEdit txtInputUsername;
        private DevExpress.XtraEditors.TextEdit txtInputEmail;
        private DevExpress.XtraEditors.TextEdit txtInputLastname;
        private DevExpress.XtraEditors.TextEdit txtInputFirstname;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperLinkLogin;
        private DevExpress.XtraEditors.PictureEdit PictureEditUser;
        private DevExpress.XtraEditors.SimpleButton btnTakePicture;
        private DevExpress.XtraEditors.SimpleButton btnUploadImage;
    }
}