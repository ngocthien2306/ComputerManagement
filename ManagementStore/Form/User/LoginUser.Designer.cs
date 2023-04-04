
namespace ManagementStore.Form.User
{
    partial class LoginUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.txtInputUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtInputPassword = new DevExpress.XtraEditors.TextEdit();
            this.groupControlRole = new DevExpress.XtraEditors.GroupControl();
            this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.radioBtnStaff = new System.Windows.Forms.RadioButton();
            this.radioBtnGuest = new System.Windows.Forms.RadioButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.hyperLinkRegister = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.dxErrorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxRememberMe = new DevExpress.XtraEditors.CheckEdit();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlRole)).BeginInit();
            this.groupControlRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputUsername
            // 
            this.txtInputUsername.Location = new System.Drawing.Point(93, 57);
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtInputUsername.Properties.ContextImageOptions.SvgImage")));
            this.txtInputUsername.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtInputUsername.Properties.MaxLength = 100;
            this.txtInputUsername.Size = new System.Drawing.Size(358, 44);
            this.txtInputUsername.TabIndex = 0;
            this.txtInputUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtInputUsername_Validating);
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Location = new System.Drawing.Point(93, 123);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtInputPassword.Properties.ContextImageOptions.SvgImage")));
            this.txtInputPassword.Properties.PasswordChar = '*';
            this.txtInputPassword.Size = new System.Drawing.Size(358, 44);
            this.txtInputPassword.TabIndex = 1;
            this.txtInputPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtInputPassword_Validating);
            // 
            // groupControlRole
            // 
            this.groupControlRole.Controls.Add(this.radioBtnAdmin);
            this.groupControlRole.Controls.Add(this.radioBtnStaff);
            this.groupControlRole.Controls.Add(this.radioBtnGuest);
            this.groupControlRole.Location = new System.Drawing.Point(93, 190);
            this.groupControlRole.Name = "groupControlRole";
            this.groupControlRole.Size = new System.Drawing.Size(358, 68);
            this.groupControlRole.TabIndex = 2;
            this.groupControlRole.Text = "Role access";
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Location = new System.Drawing.Point(272, 29);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(81, 21);
            this.radioBtnAdmin.TabIndex = 2;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "Manager";
            this.radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radioBtnStaff
            // 
            this.radioBtnStaff.AutoSize = true;
            this.radioBtnStaff.Location = new System.Drawing.Point(151, 29);
            this.radioBtnStaff.Name = "radioBtnStaff";
            this.radioBtnStaff.Size = new System.Drawing.Size(57, 21);
            this.radioBtnStaff.TabIndex = 1;
            this.radioBtnStaff.TabStop = true;
            this.radioBtnStaff.Text = "Staff";
            this.radioBtnStaff.UseVisualStyleBackColor = true;
            // 
            // radioBtnGuest
            // 
            this.radioBtnGuest.AutoSize = true;
            this.radioBtnGuest.Location = new System.Drawing.Point(17, 29);
            this.radioBtnGuest.Name = "radioBtnGuest";
            this.radioBtnGuest.Size = new System.Drawing.Size(64, 21);
            this.radioBtnGuest.TabIndex = 0;
            this.radioBtnGuest.TabStop = true;
            this.radioBtnGuest.Text = "Guest";
            this.radioBtnGuest.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(164, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(208, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // hyperLinkRegister
            // 
            this.hyperLinkRegister.Location = new System.Drawing.Point(184, 264);
            this.hyperLinkRegister.Name = "hyperLinkRegister";
            this.hyperLinkRegister.Size = new System.Drawing.Size(174, 16);
            this.hyperLinkRegister.TabIndex = 4;
            this.hyperLinkRegister.Text = "Click here to create a account!";
            this.hyperLinkRegister.Click += new System.EventHandler(this.hyperLinkRegister_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            this.checkEdit1.Location = new System.Drawing.Point(341, 183);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Remembe me";
            this.checkEdit1.Size = new System.Drawing.Size(110, 20);
            this.checkEdit1.TabIndex = 5;
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 389);
            this.Controls.Add(this.hyperLinkRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupControlRole);
            this.Controls.Add(this.txtInputPassword);
            this.Controls.Add(this.txtInputUsername);
            this.Name = "LoginUser";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.LoginUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtInputUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlRole)).EndInit();
            this.groupControlRole.ResumeLayout(false);
            this.groupControlRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtInputPassword;
        public DevExpress.XtraEditors.TextEdit txtInputUsername;
        private DevExpress.XtraEditors.GroupControl groupControlRole;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.RadioButton radioBtnStaff;
        private System.Windows.Forms.RadioButton radioBtnGuest;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperLinkRegister;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}