namespace Bank_System_Project
{
    partial class ucUpdateClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUpdateClient));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.txtAccountNumber = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.txtAccountBalance = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.txtPinCode = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "تعديل عميل";
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
            this.btnFind.Location = new System.Drawing.Point(232, 106);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 20;
            this.btnFind.Size = new System.Drawing.Size(158, 36);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "بحث";
            this.btnFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountNumber.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAccountNumber.Location = new System.Drawing.Point(442, 116);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(167, 26);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(615, 116);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(103, 18);
            this.lblAccountNumber.TabIndex = 29;
            this.lblAccountNumber.Text = "رقم الحساب :";
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
            this.btnSave.Location = new System.Drawing.Point(449, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 20;
            this.btnSave.Size = new System.Drawing.Size(168, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.Color.White;
            this.txtAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountBalance.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAccountBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountBalance.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAccountBalance.Location = new System.Drawing.Point(449, 428);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.PasswordChar = '\0';
            this.txtAccountBalance.SelectedText = "";
            this.txtAccountBalance.Size = new System.Drawing.Size(160, 26);
            this.txtAccountBalance.TabIndex = 7;
            this.txtAccountBalance.Visible = false;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(625, 428);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(113, 18);
            this.lblAccountBalance.TabIndex = 44;
            this.lblAccountBalance.Text = "رصيد الحساب :";
            this.lblAccountBalance.Visible = false;
            // 
            // txtPinCode
            // 
            this.txtPinCode.BackColor = System.Drawing.Color.White;
            this.txtPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinCode.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtPinCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPinCode.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPinCode.Location = new System.Drawing.Point(449, 378);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '\0';
            this.txtPinCode.SelectedText = "";
            this.txtPinCode.Size = new System.Drawing.Size(160, 26);
            this.txtPinCode.TabIndex = 6;
            this.txtPinCode.Visible = false;
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.Location = new System.Drawing.Point(625, 378);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(104, 18);
            this.lblPinCode.TabIndex = 43;
            this.lblPinCode.Text = "الرمز السري :";
            this.lblPinCode.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Location = new System.Drawing.Point(449, 328);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(160, 26);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(625, 328);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 18);
            this.lblPhone.TabIndex = 42;
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
            this.txtEmail.Location = new System.Drawing.Point(449, 278);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(160, 26);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(625, 278);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 18);
            this.lblEmail.TabIndex = 41;
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
            this.txtLastName.Location = new System.Drawing.Point(449, 228);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(160, 26);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(625, 228);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 18);
            this.lblLastName.TabIndex = 39;
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
            this.txtFirstName.Location = new System.Drawing.Point(450, 178);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(159, 26);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(625, 178);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 18);
            this.lblFirstName.TabIndex = 36;
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
            this.btnClear.Location = new System.Drawing.Point(262, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 20;
            this.btnClear.Size = new System.Drawing.Size(168, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "إفراغ";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(92, 249);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 45;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // ucUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucUpdateClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(798, 558);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnFind;
        private Guna.UI.WinForms.GunaLineTextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaLineTextBox txtAccountBalance;
        private System.Windows.Forms.Label lblAccountBalance;
        private Guna.UI.WinForms.GunaLineTextBox txtPinCode;
        private System.Windows.Forms.Label lblPinCode;
        private Guna.UI.WinForms.GunaLineTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI.WinForms.GunaLineTextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI.WinForms.GunaLineTextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI.WinForms.GunaLineTextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}
