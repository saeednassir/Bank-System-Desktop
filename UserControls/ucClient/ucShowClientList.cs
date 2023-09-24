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
    public partial class ucShowClientList : UserControl
    {

        private int CountClients = 0;


        public ucShowClientList()
        {
            InitializeComponent();
        }

        private void ucShowClientList_Load(object sender, EventArgs e)
        {
            List<clsBankClient> list = new List<clsBankClient>();

            list = clsBankClient.GetClientsList();

            CountClients = list.Count;
            lblContClients.Text = CountClients.ToString();

            if(list.Count > 0)
            {
                listViewShowClients.Rows.Add(list.Count);



                for (int i = 0; i < list.Count; i++)
                {


                    listViewShowClients.Rows[i].Cells[0].Value = list[i].GetAccountNumber();
                    listViewShowClients.Rows[i].Cells[1].Value = list[i].GetFirstName();
                    listViewShowClients.Rows[i].Cells[2].Value = list[i].GetLastName();
                    listViewShowClients.Rows[i].Cells[3].Value = list[i].GetEmail();
                    listViewShowClients.Rows[i].Cells[4].Value = list[i].GetPhone();
                    listViewShowClients.Rows[i].Cells[5].Value = list[i].GetPinCode();
                    listViewShowClients.Rows[i].Cells[6].Value = list[i].GetAccountBalance();

                }
            }

            

            

        }       

        private void tcmDelete_Click(object sender, EventArgs e)
        {
            clsBankClient clsBankClient;

            int count = listViewShowClients.SelectedRows.Count;


            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = listViewShowClients.SelectedRows[0];

                clsBankClient = clsBankClient.Find(row.Cells[0].Value.ToString());

                clsBankClient.Delete();

                listViewShowClients.Rows.Remove(row);

                CountClients--;
                
            }

              lblContClients.Text = CountClients.ToString();
              MessageBox.Show("تم حذف العميل بنجاح", " تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        
    }
}
