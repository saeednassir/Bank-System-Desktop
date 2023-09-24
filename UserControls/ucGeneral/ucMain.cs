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
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }

        private void ucMain_Load(object sender, EventArgs e)
        {
            double TotalBalance = clsBankClient.GetTotalBalances();

            List<clsBankClient> Clients = clsBankClient.GetClientsList();
            List<clsUser> Users = clsUser.GetUsersList();
            List<clsUser.stLoginRegisterRecord> ListLoginRegister = clsUser.GetLoginRegisterList();
            List<clsBankClient.stTransferLog> ListTransfers = clsBankClient.GetTransferLogList();
            List<clsCurrency> currencies = clsCurrency.GetCurrenciesList();


            lblValueTotalBalences.Text = TotalBalance.ToString() + "$";
            lblValueCountClients.Text = Clients.Count.ToString();
            lblValueCountUsers.Text = Users.Count.ToString();
            lblValueCountLogin.Text = ListLoginRegister.Count.ToString();
            lblValueCountTransfer.Text = ListTransfers.Count.ToString();
            lblValueCurrencies.Text = currencies.Count.ToString();


            label3.Text = DateTime.Now.ToShortDateString();

            //VProgressBarTotalBalance.Value = (int)TotalBalance;
            //VProgressBarClients.Value = Clients.Count;
            //VProgressBarUser.Value = Users.Count;
            //VProgressBarLogin.Value = ListLoginRegister.Count;
            //VProgressBarTransfer.Value = ListTransfers.Count;
            //VProgressBarCurrency.Value = currencies.Count;


        }

       
    }
}
