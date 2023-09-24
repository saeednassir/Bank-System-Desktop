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
    public partial class frmMain : Form
    {

        ucAddNewClient ucAddNewClient = new ucAddNewClient();

        ucDeleteClient ucDeleteClient = new ucDeleteClient();

        ucUpdateClient ucUpdateClient = new ucUpdateClient();

        ucFindClient ucFindClient = new ucFindClient();

        ucLoginRegister ucLoginRegister = new ucLoginRegister();

        ucCurrencyExchange ucCurrencyExchange = new ucCurrencyExchange();

        ucAccessDenied ucAccessDenied = new ucAccessDenied();

        ucSetting ucSetting = new ucSetting();



        public frmMain()
        {
            InitializeComponent();


            changeSidePanal(btnHome);         
            ucMain ucMain = new ucMain();
            addUserControl(ucMain);

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeSidePanal(Button btn)
        {
            SidePanal.Visible = true;

            SidePanal.Height = btn.Height;
            SidePanal.Top = btn.Top;
        }

        private void addUserControl(UserControl userControl)
        {
            if(userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(userControl);
                userControl.BringToFront();
            }
        }

        private void CheckAccessPermission(clsUser.enPermissions Permission, UserControl userControl)
        {
            if (frmLogin.CurrentUser.CheckAccessPermission(Permission))
            {

                addUserControl(userControl);

            }
            else
            {
                addUserControl(ucAccessDenied);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucMain ucMain = new ucMain();

            changeSidePanal((Button)sender);
            
            addUserControl(ucMain);
        }

        private void btnShowClientList_Click(object sender, EventArgs e)
        {

            changeSidePanal((Button)sender);

            ucShowClientList ucShowClientList = new ucShowClientList();

            CheckAccessPermission(clsUser.enPermissions.pListClients, ucShowClientList);

        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);

            CheckAccessPermission(clsUser.enPermissions.pAddNewClient, ucAddNewClient);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);

            CheckAccessPermission(clsUser.enPermissions.pDeleteClient, ucDeleteClient);

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);

            CheckAccessPermission(clsUser.enPermissions.pUpdateClients, ucUpdateClient);
           
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);

            CheckAccessPermission(clsUser.enPermissions.pFindClient, ucFindClient);
            
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            
            changeSidePanal((Button)sender);

            ucTransactions ucTransactions = new ucTransactions();

            CheckAccessPermission(clsUser.enPermissions.pTranactions, ucTransactions);
           
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);

            ucMangeUsers ucMangeUsers = new ucMangeUsers();

            CheckAccessPermission(clsUser.enPermissions.pManageUsers, ucMangeUsers);

        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);

            CheckAccessPermission(clsUser.enPermissions.pRegisterLogin, ucLoginRegister);

        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);

            CheckAccessPermission(clsUser.enPermissions.pCurrencyExchange, ucCurrencyExchange);

        }

        private void btnUcSeting_Click(object sender, EventArgs e)
        {
            SidePanal.Visible = false;
            addUserControl(ucSetting);

        }

        private void btnFacebokIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/BankofPalestine");
        }

        private void btnInstgramIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/BankofPalestine");
        }

        private void btnTwitterIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/BankofPalestine");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFullName.Text = frmLogin.CurrentUser.GetFullName();
            lblDate.Text = DateTime.Now.ToLongDateString().ToString();
        }

        
    }
}
