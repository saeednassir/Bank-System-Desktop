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
    public partial class ucLoginRegister : UserControl
    {

        int Count = 0;


        public ucLoginRegister()
        {
            InitializeComponent();
        }

        private void ucLoginRegister_Load(object sender, EventArgs e)
        {
            List<clsUser.stLoginRegisterRecord> list = new List<clsUser.stLoginRegisterRecord>();

            list = clsUser.GetLoginRegisterList();

            Count = list.Count;
            lblCount.Text = Count.ToString();

            if (list.Count > 0)
            {
                listViewShowClients.Rows.Add(list.Count);




                for (int i = 0; i < list.Count; i++)
                {

                    listViewShowClients.Rows[i].Cells[0].Value = list[i].DateTime;
                    listViewShowClients.Rows[i].Cells[1].Value = list[i].UserName;
                    listViewShowClients.Rows[i].Cells[2].Value = list[i].Password;
                    listViewShowClients.Rows[i].Cells[3].Value = list[i].Permissions;
                    

                }
            }
        }


    }
}
