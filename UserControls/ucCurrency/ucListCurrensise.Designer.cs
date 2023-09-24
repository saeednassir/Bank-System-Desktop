namespace Bank_System_Project
{
    partial class ucListCurrensise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListCurrensise));
            this.lblCountCurrency = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewShowClients = new Guna.UI.WinForms.GunaDataGridView();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountCurrency
            // 
            this.lblCountCurrency.AutoSize = true;
            this.lblCountCurrency.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblCountCurrency.Location = new System.Drawing.Point(451, 94);
            this.lblCountCurrency.Name = "lblCountCurrency";
            this.lblCountCurrency.Size = new System.Drawing.Size(20, 24);
            this.lblCountCurrency.TabIndex = 33;
            this.lblCountCurrency.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "عدد العملات :";
            // 
            // listViewShowClients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.listViewShowClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listViewShowClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listViewShowClients.BackgroundColor = System.Drawing.Color.White;
            this.listViewShowClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewShowClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listViewShowClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listViewShowClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listViewShowClients.ColumnHeadersHeight = 25;
            this.listViewShowClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Country,
            this.CurrencyCode,
            this.CurrencyName,
            this.Rate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(105)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listViewShowClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.listViewShowClients.EnableHeadersVisualStyles = false;
            this.listViewShowClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.listViewShowClients.Location = new System.Drawing.Point(-1, 146);
            this.listViewShowClients.Name = "listViewShowClients";
            this.listViewShowClients.RowHeadersVisible = false;
            this.listViewShowClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listViewShowClients.Size = new System.Drawing.Size(600, 405);
            this.listViewShowClients.TabIndex = 30;
            this.listViewShowClients.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Pink;
            this.listViewShowClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.listViewShowClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listViewShowClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listViewShowClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listViewShowClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listViewShowClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listViewShowClients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.listViewShowClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.listViewShowClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listViewShowClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewShowClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listViewShowClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listViewShowClients.ThemeStyle.HeaderStyle.Height = 25;
            this.listViewShowClients.ThemeStyle.ReadOnly = false;
            this.listViewShowClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(223)))));
            this.listViewShowClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listViewShowClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewShowClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listViewShowClients.ThemeStyle.RowsStyle.Height = 22;
            this.listViewShowClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(105)))), ((int)(((byte)(151)))));
            this.listViewShowClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Country
            // 
            this.Country.HeaderText = "الدولة";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // CurrencyCode
            // 
            this.CurrencyCode.HeaderText = "رمز العملة";
            this.CurrencyCode.Name = "CurrencyCode";
            this.CurrencyCode.ReadOnly = true;
            // 
            // CurrencyName
            // 
            this.CurrencyName.HeaderText = "اسم العملة";
            this.CurrencyName.Name = "CurrencyName";
            this.CurrencyName.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "سعر العملة";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "عرض قائمة العملات";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // ucListCurrensise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCountCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewShowClients);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucListCurrensise";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(598, 558);
            this.Load += new System.EventHandler(this.ucListCurrensise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountCurrency;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView listViewShowClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
