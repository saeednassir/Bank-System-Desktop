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
    public partial class ucAddNewUser : UserControl
    {
        public ucAddNewUser()
        {
            InitializeComponent();
        }

        void Enable_chkPermissions()
        {
            chkShowListClient.Enabled = true;
            chkAddNewClient.Enabled = true;
            chkDeleteClient.Enabled = true;
            chkUpdateClient.Enabled = true;
            chkFindClient.Enabled = true;
            chkTransactions.Enabled = true;
            chkCurrencyExchange.Enabled = true;
            chkLoginRegister.Enabled = true;
            chkMangeUsers.Enabled = true;

        }

        void Disable_chkPermissions()
        {
            chkShowListClient.Enabled = false;
            chkAddNewClient.Enabled = false;
            chkDeleteClient.Enabled = false;
            chkUpdateClient.Enabled = false;
            chkFindClient.Enabled = false;
            chkTransactions.Enabled = false;
            chkCurrencyExchange.Enabled = false;
            chkLoginRegister.Enabled = false;
            chkMangeUsers.Enabled = false;

            chkShowListClient.Checked = false;
            chkAddNewClient.Checked = false;
            chkDeleteClient.Checked = false;
            chkUpdateClient.Checked = false;
            chkFindClient.Checked = false;
            chkTransactions.Checked = false;
            chkCurrencyExchange.Checked = false;
            chkLoginRegister.Checked = false;
            chkMangeUsers.Checked = false;

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAll.Checked)
            {
                Disable_chkPermissions();
            }
            else
            {
                Enable_chkPermissions();
            }
        }

        int CalcPermissions()
        {

            if (chkAll.Checked) 
            {
                return -1;
            }

            int Permissions = 0;

            if (chkShowListClient.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pListClients;
            }

            if (chkAddNewClient.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pAddNewClient;
            }

            if(chkDeleteClient.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pDeleteClient;
            }

            if (chkUpdateClient.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pUpdateClients;
            }


            if (chkFindClient.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pFindClient;
            }

            if (chkTransactions.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pTranactions;
            }

            if (chkCurrencyExchange.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pCurrencyExchange;
            }

            if (chkLoginRegister.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pRegisterLogin;
            }

            if (chkMangeUsers.Checked)
            {
                Permissions += (int)clsUser.enPermissions.pManageUsers;
            }


            return Permissions;


        }

        void CleatText()
        {
            txtUsername.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();

            Disable_chkPermissions();
            chkAll.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtFirstName.Text) || String.IsNullOrWhiteSpace(txtLastName.Text) ||
                String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtPhone.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("الرجاء ادخال الحقول !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsUser.IsUserExist(txtUsername.Text.Trim()))
            {
                MessageBox.Show("اسم المستخدم مستخدم بالفعل، اختر اسم مستخدم آخر", "المستخدم موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Permissions = CalcPermissions();

           if (Permissions == 0)
            {
                MessageBox.Show("الرجاء ادخال الصلاحيات !", "الصلاحيات فارغة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUser NewUser = clsUser.GetAddNewUserObject(txtUsername.Text.Trim());

            NewUser.SetFirstName(txtFirstName.Text);
            NewUser.SetLastName(txtLastName.Text);
            NewUser.SetEmail(txtEmail.Text);
            NewUser.SetPhone(txtPhone.Text);
            NewUser.SetPassword(txtPassword.Text);
            NewUser.SetPermissions(Permissions);

            clsUser.enSaveResults SaveResult;

            SaveResult = NewUser.Save();

            switch (SaveResult)
            {
                case clsUser.enSaveResults.svSucceeded:
                    {

                        MessageBox.Show("تمت إضافة المستخدم بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleatText();
                        break;
                    }
                    
                case clsUser.enSaveResults.svFaildEmptyObject:
                    {
                    MessageBox.Show("خطأ لم يتم حفظ حساب المستخدم لأنه فارغ", "العنصر فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                    }
                case clsUser.enSaveResults.svFaildUserExists:
                    {
                    MessageBox.Show("خطأ لم يتم حفظ حساب المستخدم لأنه موجود بالفعل", "العنصر فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                    }
            }

        }

        
    }
}
