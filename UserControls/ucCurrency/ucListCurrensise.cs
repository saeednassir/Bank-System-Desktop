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
    public partial class ucListCurrensise : UserControl
    {

        private int CountCurrency = 0;

        public ucListCurrensise()
        {
            InitializeComponent();
        }

        private void ucListCurrensise_Load(object sender, EventArgs e)
        {
            List<clsCurrency> list = new List<clsCurrency>();

            list = clsCurrency.GetCurrenciesList();

            CountCurrency = list.Count;
            lblCountCurrency.Text = CountCurrency.ToString();

            if (list.Count > 0)
            {
                listViewShowClients.Rows.Add(list.Count);



                for (int i = 0; i < list.Count; i++)
                {


                    listViewShowClients.Rows[i].Cells[0].Value = list[i].GetCountry();
                    listViewShowClients.Rows[i].Cells[1].Value = list[i].GetCurrencyCode();
                    listViewShowClients.Rows[i].Cells[2].Value = list[i].GetCurrencyName();
                    listViewShowClients.Rows[i].Cells[3].Value = list[i].GetRate();
                }
            }
        }



    }
}
