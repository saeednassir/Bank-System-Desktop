namespace Bank_System_Project
{
    partial class ucUpdateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUpdateUser));
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.txtUserName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkAddNewClient = new Guna.UI.WinForms.GunaCheckBox();
            this.chkShowListClient = new Guna.UI.WinForms.GunaCheckBox();
            this.lblPermations = new System.Windows.Forms.Label();
            this.chkFindClient = new Guna.UI.WinForms.GunaCheckBox();
            this.chkUpdateClient = new Guna.UI.WinForms.GunaCheckBox();
            this.chkLoginRegister = new Guna.UI.WinForms.GunaCheckBox();
            this.chkMangeUsers = new Guna.UI.WinForms.GunaCheckBox();
            this.chkCurrencyExchange = new Guna.UI.WinForms.GunaCheckBox();
            this.chkTransactions = new Guna.UI.WinForms.GunaCheckBox();
            this.chkDeleteClient = new Guna.UI.WinForms.GunaCheckBox();
            this.chkAll = new Guna.UI.WinForms.GunaCheckBox();
            this.txtPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.AnimationHoverSpeed = 0.07F;
            this.btnFind.AnimationSpeed = 0.03F;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnFind.BorderColor = System.Drawing.Color.Black;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.FocusedColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFind.ImageOffsetX = 5;
            this.btnFind.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFind.Location = new System.Drawing.Point(53, 77);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 20;
            this.btnFind.Size = new System.Drawing.Size(158, 36);
            this.btnFind.TabIndex = 49;
            this.btnFind.Text = "بحث";
            this.btnFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.LineColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.Location = new System.Drawing.Point(263, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(167, 26);
            this.txtUserName.TabIndex = 48;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(449, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 18);
            this.lblUsername.TabIndex = 47;
            this.lblUsername.Text = "اسم المستخدم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 36);
            this.label2.TabIndex = 46;
            this.label2.Text = "تعديل مستخدم";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // chkAddNewClient
            // 
            this.chkAddNewClient.BaseColor = System.Drawing.Color.White;
            this.chkAddNewClient.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkAddNewClient.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkAddNewClient.FillColor = System.Drawing.Color.White;
            this.chkAddNewClient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddNewClient.Location = new System.Drawing.Point(443, 462);
            this.chkAddNewClient.Name = "chkAddNewClient";
            this.chkAddNewClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAddNewClient.Size = new System.Drawing.Size(131, 20);
            this.chkAddNewClient.TabIndex = 78;
            this.chkAddNewClient.Text = "إضافة عميل جديد";
            this.chkAddNewClient.Visible = false;
            // 
            // chkShowListClient
            // 
            this.chkShowListClient.BaseColor = System.Drawing.Color.White;
            this.chkShowListClient.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkShowListClient.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkShowListClient.FillColor = System.Drawing.Color.White;
            this.chkShowListClient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowListClient.Location = new System.Drawing.Point(443, 436);
            this.chkShowListClient.Name = "chkShowListClient";
            this.chkShowListClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowListClient.Size = new System.Drawing.Size(139, 20);
            this.chkShowListClient.TabIndex = 77;
            this.chkShowListClient.Text = "عرض قائمة العملاء";
            this.chkShowListClient.Visible = false;
            // 
            // lblPermations
            // 
            this.lblPermations.AutoSize = true;
            this.lblPermations.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermations.Location = new System.Drawing.Point(449, 378);
            this.lblPermations.Name = "lblPermations";
            this.lblPermations.Size = new System.Drawing.Size(88, 18);
            this.lblPermations.TabIndex = 76;
            this.lblPermations.Text = "الصلاحيات :";
            this.lblPermations.Visible = false;
            // 
            // chkFindClient
            // 
            this.chkFindClient.BaseColor = System.Drawing.Color.White;
            this.chkFindClient.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkFindClient.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkFindClient.FillColor = System.Drawing.Color.White;
            this.chkFindClient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFindClient.Location = new System.Drawing.Point(302, 462);
            this.chkFindClient.Name = "chkFindClient";
            this.chkFindClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFindClient.Size = new System.Drawing.Size(124, 20);
            this.chkFindClient.TabIndex = 74;
            this.chkFindClient.Text = "ابحث عن العميل";
            this.chkFindClient.Visible = false;
            // 
            // chkUpdateClient
            // 
            this.chkUpdateClient.BaseColor = System.Drawing.Color.White;
            this.chkUpdateClient.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkUpdateClient.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkUpdateClient.FillColor = System.Drawing.Color.White;
            this.chkUpdateClient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateClient.Location = new System.Drawing.Point(302, 436);
            this.chkUpdateClient.Name = "chkUpdateClient";
            this.chkUpdateClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUpdateClient.Size = new System.Drawing.Size(105, 20);
            this.chkUpdateClient.TabIndex = 73;
            this.chkUpdateClient.Text = "تعديل العميل";
            this.chkUpdateClient.Visible = false;
            // 
            // chkLoginRegister
            // 
            this.chkLoginRegister.BaseColor = System.Drawing.Color.White;
            this.chkLoginRegister.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkLoginRegister.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkLoginRegister.FillColor = System.Drawing.Color.White;
            this.chkLoginRegister.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoginRegister.Location = new System.Drawing.Point(177, 462);
            this.chkLoginRegister.Name = "chkLoginRegister";
            this.chkLoginRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLoginRegister.Size = new System.Drawing.Size(107, 20);
            this.chkLoginRegister.TabIndex = 72;
            this.chkLoginRegister.Text = "سجل الدخول";
            this.chkLoginRegister.Visible = false;
            // 
            // chkMangeUsers
            // 
            this.chkMangeUsers.BaseColor = System.Drawing.Color.White;
            this.chkMangeUsers.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkMangeUsers.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkMangeUsers.FillColor = System.Drawing.Color.White;
            this.chkMangeUsers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMangeUsers.Location = new System.Drawing.Point(18, 410);
            this.chkMangeUsers.Name = "chkMangeUsers";
            this.chkMangeUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMangeUsers.Size = new System.Drawing.Size(134, 20);
            this.chkMangeUsers.TabIndex = 71;
            this.chkMangeUsers.Text = "ادارة المستخدمين";
            this.chkMangeUsers.Visible = false;
            // 
            // chkCurrencyExchange
            // 
            this.chkCurrencyExchange.BaseColor = System.Drawing.Color.White;
            this.chkCurrencyExchange.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkCurrencyExchange.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkCurrencyExchange.FillColor = System.Drawing.Color.White;
            this.chkCurrencyExchange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurrencyExchange.Location = new System.Drawing.Point(177, 436);
            this.chkCurrencyExchange.Name = "chkCurrencyExchange";
            this.chkCurrencyExchange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCurrencyExchange.Size = new System.Drawing.Size(112, 20);
            this.chkCurrencyExchange.TabIndex = 70;
            this.chkCurrencyExchange.Text = "تحويل العملات";
            this.chkCurrencyExchange.Visible = false;
            // 
            // chkTransactions
            // 
            this.chkTransactions.BaseColor = System.Drawing.Color.White;
            this.chkTransactions.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkTransactions.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkTransactions.FillColor = System.Drawing.Color.White;
            this.chkTransactions.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransactions.Location = new System.Drawing.Point(177, 410);
            this.chkTransactions.Name = "chkTransactions";
            this.chkTransactions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTransactions.Size = new System.Drawing.Size(85, 20);
            this.chkTransactions.TabIndex = 69;
            this.chkTransactions.Text = "المعاملات";
            this.chkTransactions.Visible = false;
            // 
            // chkDeleteClient
            // 
            this.chkDeleteClient.BaseColor = System.Drawing.Color.White;
            this.chkDeleteClient.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkDeleteClient.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkDeleteClient.FillColor = System.Drawing.Color.White;
            this.chkDeleteClient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteClient.Location = new System.Drawing.Point(302, 410);
            this.chkDeleteClient.Name = "chkDeleteClient";
            this.chkDeleteClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDeleteClient.Size = new System.Drawing.Size(101, 20);
            this.chkDeleteClient.TabIndex = 75;
            this.chkDeleteClient.Text = "حذف العميل";
            this.chkDeleteClient.Visible = false;
            // 
            // chkAll
            // 
            this.chkAll.BaseColor = System.Drawing.Color.White;
            this.chkAll.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkAll.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.chkAll.FillColor = System.Drawing.Color.White;
            this.chkAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Location = new System.Drawing.Point(443, 410);
            this.chkAll.Name = "chkAll";
            this.chkAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAll.Size = new System.Drawing.Size(123, 20);
            this.chkAll.TabIndex = 68;
            this.chkAll.Text = "جميع الصلاحيات";
            this.chkAll.Visible = false;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(263, 338);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(167, 26);
            this.txtPassword.TabIndex = 63;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(446, 338);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 18);
            this.lblPassword.TabIndex = 67;
            this.lblPassword.Text = "كلمة المرور :";
            this.lblPassword.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Location = new System.Drawing.Point(263, 288);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(167, 26);
            this.txtPhone.TabIndex = 61;
            this.txtPhone.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(446, 288);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 18);
            this.lblPhone.TabIndex = 66;
            this.lblPhone.Text = "رقم الهاتف :";
            this.lblPhone.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(263, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(167, 26);
            this.txtEmail.TabIndex = 60;
            this.txtEmail.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(446, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 18);
            this.lblEmail.TabIndex = 65;
            this.lblEmail.Text = "البريد الإلكتروني :";
            this.lblEmail.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.LineColor = System.Drawing.Color.Gainsboro;
            this.txtLastName.Location = new System.Drawing.Point(263, 188);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(167, 26);
            this.txtLastName.TabIndex = 59;
            this.txtLastName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(446, 188);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 18);
            this.lblLastName.TabIndex = 64;
            this.lblLastName.Text = "الأسم الأخير :";
            this.lblLastName.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.LineColor = System.Drawing.Color.Gainsboro;
            this.txtFirstName.Location = new System.Drawing.Point(263, 138);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(167, 26);
            this.txtFirstName.TabIndex = 58;
            this.txtFirstName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(446, 138);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 18);
            this.lblFirstName.TabIndex = 62;
            this.lblFirstName.Text = "الأسم الأول :";
            this.lblFirstName.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClear.ImageOffsetX = 5;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(123, 507);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 20;
            this.btnClear.Size = new System.Drawing.Size(168, 42);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "إفراغ";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.ImageOffsetX = 5;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(310, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 20;
            this.btnSave.Size = new System.Drawing.Size(168, 42);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chkAddNewClient);
            this.Controls.Add(this.chkShowListClient);
            this.Controls.Add(this.lblPermations);
            this.Controls.Add(this.chkFindClient);
            this.Controls.Add(this.chkUpdateClient);
            this.Controls.Add(this.chkLoginRegister);
            this.Controls.Add(this.chkMangeUsers);
            this.Controls.Add(this.chkCurrencyExchange);
            this.Controls.Add(this.chkTransactions);
            this.Controls.Add(this.chkDeleteClient);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucUpdateUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(600, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnFind;
        private Guna.UI.WinForms.GunaLineTextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaCheckBox chkAddNewClient;
        private Guna.UI.WinForms.GunaCheckBox chkShowListClient;
        private System.Windows.Forms.Label lblPermations;
        private Guna.UI.WinForms.GunaCheckBox chkFindClient;
        private Guna.UI.WinForms.GunaCheckBox chkUpdateClient;
        private Guna.UI.WinForms.GunaCheckBox chkLoginRegister;
        private Guna.UI.WinForms.GunaCheckBox chkMangeUsers;
        private Guna.UI.WinForms.GunaCheckBox chkCurrencyExchange;
        private Guna.UI.WinForms.GunaCheckBox chkTransactions;
        private Guna.UI.WinForms.GunaCheckBox chkDeleteClient;
        private Guna.UI.WinForms.GunaCheckBox chkAll;
        private Guna.UI.WinForms.GunaLineTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI.WinForms.GunaLineTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI.WinForms.GunaLineTextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI.WinForms.GunaLineTextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI.WinForms.GunaLineTextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaButton btnSave;
    }
}
