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
    public partial class ucTransferLog : UserControl
    {

        private int Count = 0;


        public ucTransferLog()
        {
            InitializeComponent();
        }

        private void ucTransferLog_Load(object sender, EventArgs e)
        {
            List<clsBankClient.stTransferLog> list = new List<clsBankClient.stTransferLog>();

            list = clsBankClient.GetTransferLogList();

            Count = list.Count;
            lblCount.Text = Count.ToString();

            if (list.Count > 0)
            {
                listViewShowClients.Rows.Add(list.Count);

               


                for (int i = 0; i < list.Count; i++)
                {

                    listViewShowClients.Rows[i].Cells[0].Value = list[i].DateTime;
                    listViewShowClients.Rows[i].Cells[1].Value = list[i].AccountNumberSourceClient;
                    listViewShowClients.Rows[i].Cells[2].Value = list[i].AccountNumberDestinationClient;
                    listViewShowClients.Rows[i].Cells[3].Value = list[i].Amount;
                    listViewShowClients.Rows[i].Cells[4].Value = list[i].BalanceSourceClient;
                    listViewShowClients.Rows[i].Cells[5].Value = list[i].BalanceDestinationClient;
                    listViewShowClients.Rows[i].Cells[6].Value = list[i].UserName;

                }
            }

            

        }

    }
}
