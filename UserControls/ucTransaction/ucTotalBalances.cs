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
    public partial class ucTotalBalances : UserControl
    {

        private double ContTotalBalances = 0;


        public ucTotalBalances()
        {
            InitializeComponent();
        }

        private void ucTotalBalances_Load(object sender, EventArgs e)
        {
            List<clsBankClient> list = new List<clsBankClient>();

            list = clsBankClient.GetClientsList();

            
            if (list.Count > 0)
            {
                listViewShowClients.Rows.Add(list.Count);



                for (int i = 0; i < list.Count; i++)
                {

                    listViewShowClients.Rows[i].Cells[0].Value = list[i].GetAccountNumber();
                    listViewShowClients.Rows[i].Cells[1].Value = list[i].GetFullName();
                    listViewShowClients.Rows[i].Cells[2].Value = list[i].GetAccountBalance();

                    ContTotalBalances += list[i].GetAccountBalance();
                }
            }
           
            lblContTotalBalances.Text = ContTotalBalances.ToString();


        }

        private void tcmDeleteClient_Click(object sender, EventArgs e)
        {
            clsBankClient clsBankClient;

            int count = listViewShowClients.SelectedRows.Count;


            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = listViewShowClients.SelectedRows[0];

                clsBankClient = clsBankClient.Find(row.Cells[0].Value.ToString());

                clsBankClient.Delete();

                listViewShowClients.Rows.Remove(row);             

            }
     
            MessageBox.Show("تم حذف العميل بنجاح", " تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
