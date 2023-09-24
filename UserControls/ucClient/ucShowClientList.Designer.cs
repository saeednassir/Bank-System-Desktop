namespace Bank_System_Project
{
    partial class ucShowClientList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowClientList));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewShowClients = new Guna.UI.WinForms.GunaDataGridView();
            this.Acc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PinCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDeleteClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContClients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowClients)).BeginInit();
            this.cmDeleteClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "عرض قائمة العملاء";
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
            this.Acc,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone,
            this.PinCode,
            this.AccBalance});
            this.listViewShowClients.ContextMenuStrip = this.cmDeleteClient;
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
            this.listViewShowClients.Location = new System.Drawing.Point(-1, 151);
            this.listViewShowClients.Name = "listViewShowClients";
            this.listViewShowClients.RowHeadersVisible = false;
            this.listViewShowClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listViewShowClients.Size = new System.Drawing.Size(800, 404);
            this.listViewShowClients.TabIndex = 20;
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
            // Acc
            // 
            this.Acc.HeaderText = "رقم الحساب";
            this.Acc.Name = "Acc";
            this.Acc.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "الأسم الأول";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "الأسم الأخير";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "البريد الإلكتروني";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "رقم الهاتف";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // PinCode
            // 
            this.PinCode.HeaderText = "الرمز السري";
            this.PinCode.Name = "PinCode";
            this.PinCode.ReadOnly = true;
            // 
            // AccBalance
            // 
            this.AccBalance.HeaderText = "رصيد الحساب";
            this.AccBalance.Name = "AccBalance";
            this.AccBalance.ReadOnly = true;
            // 
            // cmDeleteClient
            // 
            this.cmDeleteClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmDelete});
            this.cmDeleteClient.Name = "cmEditClient";
            this.cmDeleteClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmDeleteClient.Size = new System.Drawing.Size(181, 48);
            // 
            // tcmDelete
            // 
            this.tcmDelete.Image = ((System.Drawing.Image)(resources.GetObject("tcmDelete.Image")));
            this.tcmDelete.Name = "tcmDelete";
            this.tcmDelete.Size = new System.Drawing.Size(180, 22);
            this.tcmDelete.Text = "حذف";
            this.tcmDelete.Click += new System.EventHandler(this.tcmDelete_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(42, 26);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(104, 100);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 21;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "عدد العملاء :";
            // 
            // lblContClients
            // 
            this.lblContClients.AutoSize = true;
            this.lblContClients.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblContClients.Location = new System.Drawing.Point(648, 102);
            this.lblContClients.Name = "lblContClients";
            this.lblContClients.Size = new System.Drawing.Size(20, 24);
            this.lblContClients.TabIndex = 23;
            this.lblContClients.Text = "0";
            // 
            // ucShowClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblContClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.listViewShowClients);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucShowClientList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(798, 558);
            this.Load += new System.EventHandler(this.ucShowClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowClients)).EndInit();
            this.cmDeleteClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView listViewShowClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PinCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccBalance;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmDeleteClient;
        private System.Windows.Forms.ToolStripMenuItem tcmDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContClients;
    }
}
