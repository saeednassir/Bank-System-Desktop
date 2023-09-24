namespace Bank_System_Project
{
    partial class ucCurrencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCurrencyExchange));
            this.panelRight = new System.Windows.Forms.Panel();
            this.SidePanal = new System.Windows.Forms.Panel();
            this.btnCurrencyCalculator = new System.Windows.Forms.Button();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.btnListCurrensise = new System.Windows.Forms.Button();
            this.btnFindCurrency = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelRight.Controls.Add(this.SidePanal);
            this.panelRight.Controls.Add(this.btnCurrencyCalculator);
            this.panelRight.Controls.Add(this.btnUpdateRate);
            this.panelRight.Controls.Add(this.btnListCurrensise);
            this.panelRight.Controls.Add(this.btnFindCurrency);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(598, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRight.Size = new System.Drawing.Size(200, 558);
            this.panelRight.TabIndex = 3;
            // 
            // SidePanal
            // 
            this.SidePanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.SidePanal.Location = new System.Drawing.Point(190, 164);
            this.SidePanal.Name = "SidePanal";
            this.SidePanal.Size = new System.Drawing.Size(10, 54);
            this.SidePanal.TabIndex = 3;
            // 
            // btnCurrencyCalculator
            // 
            this.btnCurrencyCalculator.FlatAppearance.BorderSize = 0;
            this.btnCurrencyCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnCurrencyCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyCalculator.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencyCalculator.ForeColor = System.Drawing.Color.White;
            this.btnCurrencyCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrencyCalculator.Image")));
            this.btnCurrencyCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrencyCalculator.Location = new System.Drawing.Point(0, 343);
            this.btnCurrencyCalculator.Name = "btnCurrencyCalculator";
            this.btnCurrencyCalculator.Size = new System.Drawing.Size(188, 54);
            this.btnCurrencyCalculator.TabIndex = 3;
            this.btnCurrencyCalculator.Text = "التحويل بين العملات";
            this.btnCurrencyCalculator.UseVisualStyleBackColor = true;
            this.btnCurrencyCalculator.Click += new System.EventHandler(this.btnCurrencyCalculator_Click);
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.FlatAppearance.BorderSize = 0;
            this.btnUpdateRate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRate.Image")));
            this.btnUpdateRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRate.Location = new System.Drawing.Point(0, 283);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(188, 54);
            this.btnUpdateRate.TabIndex = 3;
            this.btnUpdateRate.Text = "تعديل سعر العملة";
            this.btnUpdateRate.UseVisualStyleBackColor = true;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // btnListCurrensise
            // 
            this.btnListCurrensise.FlatAppearance.BorderSize = 0;
            this.btnListCurrensise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnListCurrensise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCurrensise.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCurrensise.ForeColor = System.Drawing.Color.White;
            this.btnListCurrensise.Image = ((System.Drawing.Image)(resources.GetObject("btnListCurrensise.Image")));
            this.btnListCurrensise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCurrensise.Location = new System.Drawing.Point(3, 163);
            this.btnListCurrensise.Name = "btnListCurrensise";
            this.btnListCurrensise.Size = new System.Drawing.Size(188, 54);
            this.btnListCurrensise.TabIndex = 3;
            this.btnListCurrensise.Text = "    عرض قائمة العملات";
            this.btnListCurrensise.UseVisualStyleBackColor = true;
            this.btnListCurrensise.Click += new System.EventHandler(this.btnListCurrensise_Click);
            // 
            // btnFindCurrency
            // 
            this.btnFindCurrency.FlatAppearance.BorderSize = 0;
            this.btnFindCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.btnFindCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCurrency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCurrency.ForeColor = System.Drawing.Color.White;
            this.btnFindCurrency.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCurrency.Image")));
            this.btnFindCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCurrency.Location = new System.Drawing.Point(0, 223);
            this.btnFindCurrency.Name = "btnFindCurrency";
            this.btnFindCurrency.Size = new System.Drawing.Size(188, 54);
            this.btnFindCurrency.TabIndex = 3;
            this.btnFindCurrency.Text = "البحث عن العملة";
            this.btnFindCurrency.UseVisualStyleBackColor = true;
            this.btnFindCurrency.Click += new System.EventHandler(this.btnFindCurrency_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(598, 558);
            this.panelContainer.TabIndex = 4;
            // 
            // ucCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucCurrencyExchange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(798, 558);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel SidePanal;
        private System.Windows.Forms.Button btnCurrencyCalculator;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.Button btnListCurrensise;
        private System.Windows.Forms.Button btnFindCurrency;
        private System.Windows.Forms.Panel panelContainer;
    }
}
