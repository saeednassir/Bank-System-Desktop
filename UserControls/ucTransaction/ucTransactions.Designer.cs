namespace Bank_System_Project
{
    partial class ucTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTransactions));
            this.panelRight = new System.Windows.Forms.Panel();
            this.SidePanal = new System.Windows.Forms.Panel();
            this.btnTransferLog = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTotalBalances = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelRight.Controls.Add(this.SidePanal);
            this.panelRight.Controls.Add(this.btnTransferLog);
            this.panelRight.Controls.Add(this.btnTransfer);
            this.panelRight.Controls.Add(this.btnTotalBalances);
            this.panelRight.Controls.Add(this.btnDeposit);
            this.panelRight.Controls.Add(this.btnWithdraw);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(598, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRight.Size = new System.Drawing.Size(200, 558);
            this.panelRight.TabIndex = 1;
            // 
            // SidePanal
            // 
            this.SidePanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.SidePanal.Location = new System.Drawing.Point(190, 86);
            this.SidePanal.Name = "SidePanal";
            this.SidePanal.Size = new System.Drawing.Size(10, 54);
            this.SidePanal.TabIndex = 3;
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.FlatAppearance.BorderSize = 0;
            this.btnTransferLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnTransferLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferLog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferLog.ForeColor = System.Drawing.Color.White;
            this.btnTransferLog.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferLog.Image")));
            this.btnTransferLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransferLog.Location = new System.Drawing.Point(0, 325);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.Size = new System.Drawing.Size(188, 54);
            this.btnTransferLog.TabIndex = 3;
            this.btnTransferLog.Text = "سجل التحويل";
            this.btnTransferLog.UseVisualStyleBackColor = true;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransferLog_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 265);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(188, 54);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "تحويل";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.FlatAppearance.BorderSize = 0;
            this.btnTotalBalances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnTotalBalances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalBalances.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalBalances.ForeColor = System.Drawing.Color.White;
            this.btnTotalBalances.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalBalances.Image")));
            this.btnTotalBalances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalBalances.Location = new System.Drawing.Point(0, 205);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.Size = new System.Drawing.Size(188, 54);
            this.btnTotalBalances.TabIndex = 3;
            this.btnTotalBalances.Text = "إجمالي الأرصدة";
            this.btnTotalBalances.UseVisualStyleBackColor = true;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(3, 85);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(188, 54);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "إيداع";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Image")));
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(0, 145);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(188, 54);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "سحب";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(598, 558);
            this.panelContainer.TabIndex = 2;
            // 
            // ucTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(798, 558);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel SidePanal;
        private System.Windows.Forms.Button btnTransferLog;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnTotalBalances;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel panelContainer;
    }
}
