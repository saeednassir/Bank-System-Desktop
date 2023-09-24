namespace Bank_System_Project
{
    partial class ucUpdateRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUpdateRate));
            this.label1 = new System.Windows.Forms.Label();
            this.rbCurrencyCode = new System.Windows.Forms.RadioButton();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblValueCurrencyName = new System.Windows.Forms.Label();
            this.lblValueCurrencyCode = new System.Windows.Forms.Label();
            this.lblValueCountry = new System.Windows.Forms.Label();
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.txtFindBy = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblCurrencyName = new System.Windows.Forms.Label();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValueRate = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = " البحث باستخدام :";
            // 
            // rbCurrencyCode
            // 
            this.rbCurrencyCode.AutoSize = true;
            this.rbCurrencyCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCurrencyCode.Location = new System.Drawing.Point(267, 146);
            this.rbCurrencyCode.Name = "rbCurrencyCode";
            this.rbCurrencyCode.Size = new System.Drawing.Size(88, 22);
            this.rbCurrencyCode.TabIndex = 88;
            this.rbCurrencyCode.Text = "رمز العملة";
            this.rbCurrencyCode.UseVisualStyleBackColor = true;
            // 
            // rbCountry
            // 
            this.rbCountry.AutoSize = true;
            this.rbCountry.Checked = true;
            this.rbCountry.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCountry.Location = new System.Drawing.Point(369, 146);
            this.rbCountry.Name = "rbCountry";
            this.rbCountry.Size = new System.Drawing.Size(59, 22);
            this.rbCountry.TabIndex = 87;
            this.rbCountry.TabStop = true;
            this.rbCountry.Text = "الدولة";
            this.rbCountry.UseVisualStyleBackColor = true;
            this.rbCountry.CheckedChanged += new System.EventHandler(this.rbCountry_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // lblValueCurrencyName
            // 
            this.lblValueCurrencyName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCurrencyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValueCurrencyName.Location = new System.Drawing.Point(181, 406);
            this.lblValueCurrencyName.Name = "lblValueCurrencyName";
            this.lblValueCurrencyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueCurrencyName.Size = new System.Drawing.Size(246, 18);
            this.lblValueCurrencyName.TabIndex = 84;
            this.lblValueCurrencyName.Visible = false;
            // 
            // lblValueCurrencyCode
            // 
            this.lblValueCurrencyCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValueCurrencyCode.Location = new System.Drawing.Point(181, 356);
            this.lblValueCurrencyCode.Name = "lblValueCurrencyCode";
            this.lblValueCurrencyCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueCurrencyCode.Size = new System.Drawing.Size(246, 18);
            this.lblValueCurrencyCode.TabIndex = 83;
            this.lblValueCurrencyCode.Visible = false;
            // 
            // lblValueCountry
            // 
            this.lblValueCountry.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblValueCountry.Location = new System.Drawing.Point(181, 306);
            this.lblValueCountry.Name = "lblValueCountry";
            this.lblValueCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueCountry.Size = new System.Drawing.Size(249, 18);
            this.lblValueCountry.TabIndex = 82;
            this.lblValueCountry.Visible = false;
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
            this.btnFind.Location = new System.Drawing.Point(50, 191);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 20;
            this.btnFind.Size = new System.Drawing.Size(158, 36);
            this.btnFind.TabIndex = 81;
            this.btnFind.Text = "بحث";
            this.btnFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFindBy
            // 
            this.txtFindBy.BackColor = System.Drawing.Color.White;
            this.txtFindBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindBy.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindBy.LineColor = System.Drawing.Color.Gainsboro;
            this.txtFindBy.Location = new System.Drawing.Point(260, 201);
            this.txtFindBy.Name = "txtFindBy";
            this.txtFindBy.PasswordChar = '\0';
            this.txtFindBy.SelectedText = "";
            this.txtFindBy.Size = new System.Drawing.Size(167, 26);
            this.txtFindBy.TabIndex = 80;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(440, 456);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(98, 18);
            this.lblRate.TabIndex = 79;
            this.lblRate.Text = "سعر العملة :";
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName.Location = new System.Drawing.Point(440, 406);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(96, 18);
            this.lblCurrencyName.TabIndex = 78;
            this.lblCurrencyName.Text = "اسم العملة :";
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.AutoSize = true;
            this.lblCurrencyCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyCode.Location = new System.Drawing.Point(440, 356);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(89, 18);
            this.lblCurrencyCode.TabIndex = 77;
            this.lblCurrencyCode.Text = "رمز العملة :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(440, 306);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 18);
            this.lblCountry.TabIndex = 76;
            this.lblCountry.Text = "الدولة :";
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.Location = new System.Drawing.Point(433, 201);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(58, 18);
            this.lblFindBy.TabIndex = 75;
            this.lblFindBy.Text = "الدولة :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 36);
            this.label2.TabIndex = 74;
            this.label2.Text = "تعديل سعر العملة";
            // 
            // txtValueRate
            // 
            this.txtValueRate.BackColor = System.Drawing.Color.White;
            this.txtValueRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValueRate.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtValueRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValueRate.LineColor = System.Drawing.Color.Gainsboro;
            this.txtValueRate.Location = new System.Drawing.Point(321, 456);
            this.txtValueRate.Name = "txtValueRate";
            this.txtValueRate.PasswordChar = '\0';
            this.txtValueRate.SelectedText = "";
            this.txtValueRate.Size = new System.Drawing.Size(103, 26);
            this.txtValueRate.TabIndex = 90;
            this.txtValueRate.Visible = false;
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
            this.btnSave.Location = new System.Drawing.Point(163, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 20;
            this.btnSave.Size = new System.Drawing.Size(138, 39);
            this.btnSave.TabIndex = 92;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucUpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtValueRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCurrencyCode);
            this.Controls.Add(this.rbCountry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblValueCurrencyName);
            this.Controls.Add(this.lblValueCurrencyCode);
            this.Controls.Add(this.lblValueCountry);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFindBy);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblCurrencyName);
            this.Controls.Add(this.lblCurrencyCode);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblFindBy);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucUpdateRate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(598, 558);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCurrencyCode;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblValueCurrencyName;
        private System.Windows.Forms.Label lblValueCurrencyCode;
        private System.Windows.Forms.Label lblValueCountry;
        private Guna.UI.WinForms.GunaButton btnFind;
        private Guna.UI.WinForms.GunaLineTextBox txtFindBy;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblCurrencyName;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox txtValueRate;
        private Guna.UI.WinForms.GunaButton btnSave;
    }
}
