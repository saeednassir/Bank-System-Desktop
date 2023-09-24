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
    public partial class ucListUsers : UserControl
    {

        int CountUsers = 0;


        public ucListUsers()
        {
            InitializeComponent();
        }

        private void ucListUsers_Load(object sender, EventArgs e)
        {
            List<clsUser> list = new List<clsUser>();

            list = clsUser.GetUsersList();

            CountUsers = list.Count;
            lblContUsers.Text = CountUsers.ToString();

            if (list.Count > 0)
            {
                listViewShowClients.Rows.Add(list.Count);



                for (int i = 0; i < list.Count; i++)
                {


                    listViewShowClients.Rows[i].Cells[0].Value = list[i].GetUserName();
                    listViewShowClients.Rows[i].Cells[1].Value = list[i].GetFirstName();
                    listViewShowClients.Rows[i].Cells[2].Value = list[i].GetLastName();
                    listViewShowClients.Rows[i].Cells[3].Value = list[i].GetEmail();
                    listViewShowClients.Rows[i].Cells[4].Value = list[i].GetPhone();
                    listViewShowClients.Rows[i].Cells[5].Value = list[i].GetPassword();
                    listViewShowClients.Rows[i].Cells[6].Value = list[i].GetPermissions();
                    
                }
            }


        }

        private void tcmDelete_Click(object sender, EventArgs e)
        {
            clsUser User;

            int count = listViewShowClients.SelectedRows.Count;


            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = listViewShowClients.SelectedRows[0];

                User = clsUser.Find(row.Cells[0].Value.ToString());

                if (User.GetUserName() == frmLogin.CurrentUser.GetUserName())
                {
                    MessageBox.Show("! لا يمكنك حذف حسابك المسجل به الدخول حالياً", "لا يمكن حذف حسابك", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User.Delete();

                listViewShowClients.Rows.Remove(row);

                CountUsers--;

            }

            lblContUsers.Text = CountUsers.ToString();
            MessageBox.Show("تم حذف المستخدم بنجاح", " تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
