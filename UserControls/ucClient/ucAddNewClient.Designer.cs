namespace Bank_System_Project
{
    partial class ucAddNewClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddNewClient));
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtFirstName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPinCode = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.txtAccountBalance = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(611, 117);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(103, 18);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "رقم الحساب :";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountNumber.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAccountNumber.Location = new System.Drawing.Point(435, 117);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(160, 26);
            this.txtAccountNumber.TabIndex = 0;
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.LineColor = System.Drawing.Color.Gainsboro;
            this.txtFirstName.Location = new System.Drawing.Point(436, 167);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(159, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(611, 167);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 18);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "الأسم الأول :";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.LineColor = System.Drawing.Color.Gainsboro;
            this.txtLastName.Location = new System.Drawing.Point(435, 217);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(160, 26);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(611, 217);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 18);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "الأسم الأخير :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(435, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(160, 26);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(611, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "البريد الإلكتروني :";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Location = new System.Drawing.Point(435, 317);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(160, 26);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(611, 317);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 18);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "رقم الهاتف :";
            // 
            // txtPinCode
            // 
            this.txtPinCode.BackColor = System.Drawing.Color.White;
            this.txtPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinCode.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtPinCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPinCode.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPinCode.Location = new System.Drawing.Point(435, 367);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '\0';
            this.txtPinCode.SelectedText = "";
            this.txtPinCode.Size = new System.Drawing.Size(160, 26);
            this.txtPinCode.TabIndex = 5;
            this.txtPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.Location = new System.Drawing.Point(611, 367);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(104, 18);
            this.lblPinCode.TabIndex = 12;
            this.lblPinCode.Text = "الرمز السري :";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.Color.White;
            this.txtAccountBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountBalance.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAccountBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountBalance.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAccountBalance.Location = new System.Drawing.Point(435, 417);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.PasswordChar = '\0';
            this.txtAccountBalance.SelectedText = "";
            this.txtAccountBalance.Size = new System.Drawing.Size(160, 26);
            this.txtAccountBalance.TabIndex = 6;
            this.txtAccountBalance.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(611, 417);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(113, 18);
            this.lblAccountBalance.TabIndex = 14;
            this.lblAccountBalance.Text = "رصيد الحساب :";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageOffsetX = 5;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(435, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(168, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "إضافة عميل جديد";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(112, 230);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 17;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // ucAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ucAddNewClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(799, 560);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumber;
        private Guna.UI.WinForms.GunaLineTextBox txtAccountNumber;
        private Guna.UI.WinForms.GunaLineTextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI.WinForms.GunaLineTextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI.WinForms.GunaLineTextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI.WinForms.GunaLineTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI.WinForms.GunaLineTextBox txtPinCode;
        private System.Windows.Forms.Label lblPinCode;
        private Guna.UI.WinForms.GunaLineTextBox txtAccountBalance;
        private System.Windows.Forms.Label lblAccountBalance;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}
