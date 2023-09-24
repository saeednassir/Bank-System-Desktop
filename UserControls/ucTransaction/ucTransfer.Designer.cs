namespace Bank_System_Project
{
    partial class ucTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTransfer));
            this.btnTransfer = new Guna.UI.WinForms.GunaButton();
            this.txtAccountNumberSourceClient = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNumberDestinationClient = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.AnimationHoverSpeed = 0.07F;
            this.btnTransfer.AnimationSpeed = 0.03F;
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnTransfer.BorderColor = System.Drawing.Color.Black;
            this.btnTransfer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTransfer.FocusedColor = System.Drawing.Color.Empty;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTransfer.ImageOffsetX = 5;
            this.btnTransfer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTransfer.Location = new System.Drawing.Point(218, 429);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnTransfer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTransfer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTransfer.OnHoverImage = null;
            this.btnTransfer.OnPressedColor = System.Drawing.Color.Black;
            this.btnTransfer.Radius = 20;
            this.btnTransfer.Size = new System.Drawing.Size(158, 36);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "تحويل";
            this.btnTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtAccountNumberSourceClient
            // 
            this.txtAccountNumberSourceClient.BackColor = System.Drawing.Color.White;
            this.txtAccountNumberSourceClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumberSourceClient.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAccountNumberSourceClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountNumberSourceClient.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAccountNumberSourceClient.Location = new System.Drawing.Point(119, 268);
            this.txtAccountNumberSourceClient.Name = "txtAccountNumberSourceClient";
            this.txtAccountNumberSourceClient.PasswordChar = '\0';
            this.txtAccountNumberSourceClient.SelectedText = "";
            this.txtAccountNumberSourceClient.Size = new System.Drawing.Size(167, 26);
            this.txtAccountNumberSourceClient.TabIndex = 0;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(292, 268);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(187, 18);
            this.lblAccountNumber.TabIndex = 29;
            this.lblAccountNumber.Text = "رقم الحساب المرسل منه:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 36);
            this.label2.TabIndex = 32;
            this.label2.Text = "التحويل بين الحسابات";
            // 
            // txtAccountNumberDestinationClient
            // 
            this.txtAccountNumberDestinationClient.BackColor = System.Drawing.Color.White;
            this.txtAccountNumberDestinationClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumberDestinationClient.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAccountNumberDestinationClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountNumberDestinationClient.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAccountNumberDestinationClient.Location = new System.Drawing.Point(119, 320);
            this.txtAccountNumberDestinationClient.Name = "txtAccountNumberDestinationClient";
            this.txtAccountNumberDestinationClient.PasswordChar = '\0';
            this.txtAccountNumberDestinationClient.SelectedText = "";
            this.txtAccountNumberDestinationClient.Size = new System.Drawing.Size(167, 26);
            this.txtAccountNumberDestinationClient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "رقم الحساب المرسل إليه:";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAmount.Location = new System.Drawing.Point(119, 364);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(167, 26);
            this.txtAmount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "المبلغ :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // ucTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountNumberDestinationClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAccountNumberSourceClient);
            this.Controls.Add(this.lblAccountNumber);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTransfer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(598, 558);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnTransfer;
        private Guna.UI.WinForms.GunaLineTextBox txtAccountNumberSourceClient;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox txtAccountNumberDestinationClient;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
