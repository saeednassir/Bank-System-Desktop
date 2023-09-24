namespace Bank_System_Project
{
    partial class ucWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWithdraw));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWithdraw = new Guna.UI.WinForms.GunaButton();
            this.txtAmount = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblValueAccountBalance = new System.Windows.Forms.Label();
            this.lblValuePinCode = new System.Windows.Forms.Label();
            this.lblValuePhone = new System.Windows.Forms.Label();
            this.lblValueEmail = new System.Windows.Forms.Label();
            this.lblValueLastName = new System.Windows.Forms.Label();
            this.lblValueFirstName = new System.Windows.Forms.Label();
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.txtAccountNumber = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.AnimationHoverSpeed = 0.07F;
            this.btnWithdraw.AnimationSpeed = 0.03F;
            this.btnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnWithdraw.BorderColor = System.Drawing.Color.Black;
            this.btnWithdraw.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnWithdraw.FocusedColor = System.Drawing.Color.Empty;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Image")));
            this.btnWithdraw.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnWithdraw.ImageOffsetX = 5;
            this.btnWithdraw.ImageSize = new System.Drawing.Size(20, 20);
            this.btnWithdraw.Location = new System.Drawing.Point(51, 490);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnWithdraw.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnWithdraw.OnHoverForeColor = System.Drawing.Color.White;
            this.btnWithdraw.OnHoverImage = null;
            this.btnWithdraw.OnPressedColor = System.Drawing.Color.Black;
            this.btnWithdraw.Radius = 20;
            this.btnWithdraw.Size = new System.Drawing.Size(158, 36);
            this.btnWithdraw.TabIndex = 72;
            this.btnWithdraw.Text = "سحب";
            this.btnWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAmount.Location = new System.Drawing.Point(261, 500);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(167, 26);
            this.txtAmount.TabIndex = 71;
            this.txtAmount.Visible = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(441, 500);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 18);
            this.lblAmount.TabIndex = 70;
            this.lblAmount.Text = "المبلغ";
            this.lblAmount.Visible = false;
            // 
            // lblValueAccountBalance
            // 
            this.lblValueAccountBalance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueAccountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValueAccountBalance.Location = new System.Drawing.Point(289, 438);
            this.lblValueAccountBalance.Name = "lblValueAccountBalance";
            this.lblValueAccountBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueAccountBalance.Size = new System.Drawing.Size(142, 18);
            this.lblValueAccountBalance.TabIndex = 69;
            this.lblValueAccountBalance.Visible = false;
            // 
            // lblValuePinCode
            // 
            this.lblValuePinCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuePinCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValuePinCode.Location = new System.Drawing.Point(289, 388);
            this.lblValuePinCode.Name = "lblValuePinCode";
            this.lblValuePinCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValuePinCode.Size = new System.Drawing.Size(139, 18);
            this.lblValuePinCode.TabIndex = 68;
            this.lblValuePinCode.Visible = false;
            // 
            // lblValuePhone
            // 
            this.lblValuePhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValuePhone.Location = new System.Drawing.Point(289, 338);
            this.lblValuePhone.Name = "lblValuePhone";
            this.lblValuePhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValuePhone.Size = new System.Drawing.Size(139, 18);
            this.lblValuePhone.TabIndex = 67;
            this.lblValuePhone.Visible = false;
            // 
            // lblValueEmail
            // 
            this.lblValueEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValueEmail.Location = new System.Drawing.Point(182, 288);
            this.lblValueEmail.Name = "lblValueEmail";
            this.lblValueEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueEmail.Size = new System.Drawing.Size(246, 18);
            this.lblValueEmail.TabIndex = 66;
            this.lblValueEmail.Visible = false;
            // 
            // lblValueLastName
            // 
            this.lblValueLastName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValueLastName.Location = new System.Drawing.Point(289, 238);
            this.lblValueLastName.Name = "lblValueLastName";
            this.lblValueLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueLastName.Size = new System.Drawing.Size(139, 18);
            this.lblValueLastName.TabIndex = 65;
            this.lblValueLastName.Visible = false;
            // 
            // lblValueFirstName
            // 
            this.lblValueFirstName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValueFirstName.Location = new System.Drawing.Point(289, 188);
            this.lblValueFirstName.Name = "lblValueFirstName";
            this.lblValueFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueFirstName.Size = new System.Drawing.Size(142, 18);
            this.lblValueFirstName.TabIndex = 64;
            this.lblValueFirstName.Visible = false;
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
            this.btnFind.Location = new System.Drawing.Point(51, 94);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 20;
            this.btnFind.Size = new System.Drawing.Size(158, 36);
            this.btnFind.TabIndex = 63;
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
            this.txtAccountNumber.Location = new System.Drawing.Point(261, 104);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(167, 26);
            this.txtAccountNumber.TabIndex = 62;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(441, 438);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(113, 18);
            this.lblAccountBalance.TabIndex = 61;
            this.lblAccountBalance.Text = "رصيد الحساب :";
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.Location = new System.Drawing.Point(441, 388);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(104, 18);
            this.lblPinCode.TabIndex = 60;
            this.lblPinCode.Text = "الرمز السري :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(441, 338);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 18);
            this.lblPhone.TabIndex = 59;
            this.lblPhone.Text = "رقم الهاتف :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(441, 288);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 18);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "البريد الإلكتروني :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(441, 238);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 18);
            this.lblLastName.TabIndex = 57;
            this.lblLastName.Text = "الأسم الأخير :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(441, 188);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 18);
            this.lblFirstName.TabIndex = 56;
            this.lblFirstName.Text = "الأسم الأول :";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(434, 104);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(103, 18);
            this.lblAccountNumber.TabIndex = 55;
            this.lblAccountNumber.Text = "رقم الحساب :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 36);
            this.label1.TabIndex = 74;
            this.label1.Text = "سحب";
            // 
            // ucWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblValueAccountBalance);
            this.Controls.Add(this.lblValuePinCode);
            this.Controls.Add(this.lblValuePhone);
            this.Controls.Add(this.lblValueEmail);
            this.Controls.Add(this.lblValueLastName);
            this.Controls.Add(this.lblValueFirstName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAccountNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucWithdraw";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(598, 558);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton btnWithdraw;
        private Guna.UI.WinForms.GunaLineTextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblValueAccountBalance;
        private System.Windows.Forms.Label lblValuePinCode;
        private System.Windows.Forms.Label lblValuePhone;
        private System.Windows.Forms.Label lblValueEmail;
        private System.Windows.Forms.Label lblValueLastName;
        private System.Windows.Forms.Label lblValueFirstName;
        private Guna.UI.WinForms.GunaButton btnFind;
        private Guna.UI.WinForms.GunaLineTextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label1;
    }
}
