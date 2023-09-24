namespace Bank_System_Project
{
    partial class ucTotalBalances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTotalBalances));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewShowClients = new Guna.UI.WinForms.GunaDataGridView();
            this.Acc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContTotalBalances = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcmDeleteClient = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "الرصيد الإجمالي";
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
            this.FullName,
            this.AccBalance});
            this.listViewShowClients.ContextMenuStrip = this.contextMenuStrip1;
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
            this.listViewShowClients.Location = new System.Drawing.Point(0, 159);
            this.listViewShowClients.Name = "listViewShowClients";
            this.listViewShowClients.RowHeadersVisible = false;
            this.listViewShowClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listViewShowClients.Size = new System.Drawing.Size(598, 399);
            this.listViewShowClients.TabIndex = 21;
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
            // FullName
            // 
            this.FullName.HeaderText = "الأسم كامل";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // AccBalance
            // 
            this.AccBalance.HeaderText = "رصيد الحساب";
            this.AccBalance.Name = "AccBalance";
            this.AccBalance.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "الرصيد الإجمالي :";
            // 
            // lblContTotalBalances
            // 
            this.lblContTotalBalances.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContTotalBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.lblContTotalBalances.Location = new System.Drawing.Point(292, 111);
            this.lblContTotalBalances.Name = "lblContTotalBalances";
            this.lblContTotalBalances.Size = new System.Drawing.Size(156, 24);
            this.lblContTotalBalances.TabIndex = 24;
            this.lblContTotalBalances.Text = "0";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(17, 35);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 25;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmDeleteClient});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // tcmDeleteClient
            // 
            this.tcmDeleteClient.Name = "tcmDeleteClient";
            this.tcmDeleteClient.Size = new System.Drawing.Size(99, 22);
            this.tcmDeleteClient.Text = "حذف";
            this.tcmDeleteClient.Click += new System.EventHandler(this.tcmDeleteClient_Click);
            // 
            // ucTotalBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.lblContTotalBalances);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewShowClients);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTotalBalances";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(598, 558);
            this.Load += new System.EventHandler(this.ucTotalBalances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView listViewShowClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContTotalBalances;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tcmDeleteClient;
    }
}
