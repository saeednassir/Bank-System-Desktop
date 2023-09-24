using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_Project
{
    public partial class ucTransactions : UserControl
    {

        ucDeposit ucDeposit = new ucDeposit();

        ucWithdraw ucWithdraw = new ucWithdraw();

        ucTransfer ucTransfer = new ucTransfer();


        public ucTransactions()
        {
            InitializeComponent();

            changeSidePanal(btnDeposit);
            addUserControl(ucDeposit);
        }

        private void changeSidePanal(Button btn)
        {
            SidePanal.Height = btn.Height;
            SidePanal.Top = btn.Top;
        }

        private void addUserControl(UserControl userControl)
        {
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(userControl);
                userControl.BringToFront();
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucDeposit);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucWithdraw);
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            ucTotalBalances ucTotalBalances = new ucTotalBalances();

            changeSidePanal((Button)sender);
            addUserControl(ucTotalBalances);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucTransfer);
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            ucTransferLog ucTransferLog = new ucTransferLog();


            changeSidePanal((Button)sender);
            addUserControl(ucTransferLog);
        }


    }
}
