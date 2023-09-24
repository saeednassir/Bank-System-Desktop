namespace Bank_System_Project
{
    partial class ucResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucResetPassword));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new Guna.UI.WinForms.GunaButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.chk_imgOldPass = new Guna.UI.WinForms.GunaImageCheckBox();
            this.txtOldPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.chk_imgNewPass = new Guna.UI.WinForms.GunaImageCheckBox();
            this.chk_imgRestNewPass = new Guna.UI.WinForms.GunaImageCheckBox();
            this.txtNewPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtRestNewPassword = new Guna.UI.WinForms.GunaLineTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(250, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "إعادة كلمة المرور الجديدة :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "كلمة المرور الجديدة :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 36);
            this.label2.TabIndex = 57;
            this.label2.Text = "إعادة تعيين كلمة المرور";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AnimationHoverSpeed = 0.07F;
            this.btnChangePassword.AnimationSpeed = 0.03F;
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnChangePassword.BorderColor = System.Drawing.Color.Black;
            this.btnChangePassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChangePassword.FocusedColor = System.Drawing.Color.Empty;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnChangePassword.ImageOffsetX = 5;
            this.btnChangePassword.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChangePassword.Location = new System.Drawing.Point(186, 459);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnChangePassword.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChangePassword.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChangePassword.OnHoverImage = null;
            this.btnChangePassword.OnPressedColor = System.Drawing.Color.Black;
            this.btnChangePassword.Radius = 20;
            this.btnChangePassword.Size = new System.Drawing.Size(182, 36);
            this.btnChangePassword.TabIndex = 56;
            this.btnChangePassword.Text = "تغيير كلمة المرور";
            this.btnChangePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(293, 298);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(153, 18);
            this.lbl1.TabIndex = 54;
            this.lbl1.Text = "كلمة المرور القديمة :";
            // 
            // chk_imgOldPass
            // 
            this.chk_imgOldPass.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("chk_imgOldPass.ImageCheckedOff")));
            this.chk_imgOldPass.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("chk_imgOldPass.ImageCheckedOn")));
            this.chk_imgOldPass.ImageSize = new System.Drawing.Size(20, 20);
            this.chk_imgOldPass.Location = new System.Drawing.Point(84, 298);
            this.chk_imgOldPass.Name = "chk_imgOldPass";
            this.chk_imgOldPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_imgOldPass.Size = new System.Drawing.Size(30, 30);
            this.chk_imgOldPass.TabIndex = 63;
            this.chk_imgOldPass.CheckedChanged += new System.EventHandler(this.chk_imgOldPass_CheckedChanged);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.White;
            this.txtOldPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtOldPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.txtOldPassword.Location = new System.Drawing.Point(120, 302);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '\0';
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.Size = new System.Drawing.Size(167, 26);
            this.txtOldPassword.TabIndex = 55;
            this.txtOldPassword.UseWaitCursor = true;
            // 
            // chk_imgNewPass
            // 
            this.chk_imgNewPass.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("chk_imgNewPass.ImageCheckedOff")));
            this.chk_imgNewPass.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("chk_imgNewPass.ImageCheckedOn")));
            this.chk_imgNewPass.ImageSize = new System.Drawing.Size(20, 20);
            this.chk_imgNewPass.Location = new System.Drawing.Point(84, 346);
            this.chk_imgNewPass.Name = "chk_imgNewPass";
            this.chk_imgNewPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_imgNewPass.Size = new System.Drawing.Size(30, 30);
            this.chk_imgNewPass.TabIndex = 65;
            this.chk_imgNewPass.CheckedChanged += new System.EventHandler(this.chk_imgNewPass_CheckedChanged);
            // 
            // chk_imgRestNewPass
            // 
            this.chk_imgRestNewPass.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("chk_imgRestNewPass.ImageCheckedOff")));
            this.chk_imgRestNewPass.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("chk_imgRestNewPass.ImageCheckedOn")));
            this.chk_imgRestNewPass.ImageSize = new System.Drawing.Size(20, 20);
            this.chk_imgRestNewPass.Location = new System.Drawing.Point(84, 390);
            this.chk_imgRestNewPass.Name = "chk_imgRestNewPass";
            this.chk_imgRestNewPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_imgRestNewPass.Size = new System.Drawing.Size(30, 30);
            this.chk_imgRestNewPass.TabIndex = 67;
            this.chk_imgRestNewPass.CheckedChanged += new System.EventHandler(this.chk_imgRestNewPass_CheckedChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNewPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.txtNewPassword.Location = new System.Drawing.Point(120, 350);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(167, 26);
            this.txtNewPassword.TabIndex = 68;
            this.txtNewPassword.UseWaitCursor = true;
            // 
            // txtRestNewPassword
            // 
            this.txtRestNewPassword.BackColor = System.Drawing.Color.White;
            this.txtRestNewPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtRestNewPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtRestNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRestNewPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.txtRestNewPassword.Location = new System.Drawing.Point(120, 394);
            this.txtRestNewPassword.Name = "txtRestNewPassword";
            this.txtRestNewPassword.PasswordChar = '\0';
            this.txtRestNewPassword.SelectedText = "";
            this.txtRestNewPassword.Size = new System.Drawing.Size(167, 26);
            this.txtRestNewPassword.TabIndex = 69;
            this.txtRestNewPassword.UseWaitCursor = true;
            // 
            // ucResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRestNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.chk_imgRestNewPass);
            this.Controls.Add(this.chk_imgNewPass);
            this.Controls.Add(this.chk_imgOldPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucResetPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(600, 560);
            this.Load += new System.EventHandler(this.ucResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnChangePassword;
        private System.Windows.Forms.Label lbl1;
        private Guna.UI.WinForms.GunaImageCheckBox chk_imgOldPass;
        private Guna.UI.WinForms.GunaLineTextBox txtOldPassword;
        private Guna.UI.WinForms.GunaImageCheckBox chk_imgNewPass;
        private Guna.UI.WinForms.GunaImageCheckBox chk_imgRestNewPass;
        private Guna.UI.WinForms.GunaLineTextBox txtNewPassword;
        private Guna.UI.WinForms.GunaLineTextBox txtRestNewPassword;
    }
}
