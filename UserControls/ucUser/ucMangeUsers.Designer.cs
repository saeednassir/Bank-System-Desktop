namespace Bank_System_Project
{
    partial class ucMangeUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMangeUsers));
            this.panelRight = new System.Windows.Forms.Panel();
            this.SidePanal = new System.Windows.Forms.Panel();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelRight.Controls.Add(this.btnResetPassword);
            this.panelRight.Controls.Add(this.SidePanal);
            this.panelRight.Controls.Add(this.btnFindUser);
            this.panelRight.Controls.Add(this.btnUpdateUser);
            this.panelRight.Controls.Add(this.btnDeleteUser);
            this.panelRight.Controls.Add(this.btnListUsers);
            this.panelRight.Controls.Add(this.btnAddNewUser);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(600, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRight.Size = new System.Drawing.Size(200, 560);
            this.panelRight.TabIndex = 2;
            // 
            // SidePanal
            // 
            this.SidePanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.SidePanal.Location = new System.Drawing.Point(190, 86);
            this.SidePanal.Name = "SidePanal";
            this.SidePanal.Size = new System.Drawing.Size(10, 54);
            this.SidePanal.TabIndex = 3;
            // 
            // btnFindUser
            // 
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.Location = new System.Drawing.Point(0, 325);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(188, 54);
            this.btnFindUser.TabIndex = 3;
            this.btnFindUser.Text = "ابحث عن مستخدم";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Image")));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 265);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(188, 54);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "تعديل مستخدم";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 205);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(188, 54);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "حذف مستخدم";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnListUsers
            // 
            this.btnListUsers.FlatAppearance.BorderSize = 0;
            this.btnListUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUsers.ForeColor = System.Drawing.Color.White;
            this.btnListUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnListUsers.Image")));
            this.btnListUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUsers.Location = new System.Drawing.Point(3, 85);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(188, 54);
            this.btnListUsers.TabIndex = 3;
            this.btnListUsers.Text = "    عرض قائمة المستخدمين";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Image")));
            this.btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewUser.Location = new System.Drawing.Point(0, 145);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(188, 54);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.Text = "إضافة مستخدم جديد";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(600, 560);
            this.panelContainer.TabIndex = 3;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.Image")));
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.Location = new System.Drawing.Point(2, 385);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(188, 54);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "إعادة تعيين كلمة المرور";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // ucMangeUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMangeUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 560);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel SidePanal;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnResetPassword;
    }
}
