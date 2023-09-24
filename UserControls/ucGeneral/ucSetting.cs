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
    public partial class ucSetting : UserControl
    {
        public ucSetting()
        {
            InitializeComponent();
        }

        void chkPerPermissions(clsUser user)
        {


            if (user.GetPermissions() == -1)
            {
                chkAll.Checked = true;
                return;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pListClients))
            {
                chkShowListClient.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pAddNewClient))
            {
                chkAddNewClient.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pDeleteClient))
            {
                chkDeleteClient.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pUpdateClients))
            {
                chkUpdateClient.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pFindClient))
            {
                chkFindClient.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pTranactions))
            {
                chkTransactions.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pCurrencyExchange))
            {
                chkCurrencyExchange.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pRegisterLogin))
            {
                chkLoginRegister.Checked = true;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                chkMangeUsers.Checked = true;
            }



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
            if (chkAll.Checked)
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

            if (chkDeleteClient.Checked)
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

        private void UpdateUserData(clsUser User)
        {

            User.SetFirstName(txtFirstName.Text);
            User.SetLastName(txtLastName.Text);
            User.SetEmail(txtEmail.Text);
            User.SetPhone(txtPhone.Text);
            User.SetPassword(txtPassword.Text);

            User.SetPermissions(CalcPermissions());


        }

        private void ucSetting_Load(object sender, EventArgs e)
        {
            fillUpdatedCurrentUser();

        }

        void fillUpdatedCurrentUser()
        {
            txtUserName.Text = frmLogin.CurrentUser.GetUserName();
            txtFirstName.Text = frmLogin.CurrentUser.GetFirstName();
            txtLastName.Text = frmLogin.CurrentUser.GetLastName();
            txtEmail.Text = frmLogin.CurrentUser.GetEmail();
            txtPhone.Text = frmLogin.CurrentUser.GetPhone();
            txtPassword.Text = frmLogin.CurrentUser.GetPassword();

            chkPerPermissions(frmLogin.CurrentUser);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text) || String.IsNullOrWhiteSpace(txtFirstName.Text) || String.IsNullOrWhiteSpace(txtLastName.Text) ||
               String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtPhone.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("الرجاء ادخال الحقول !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.No == MessageBox.Show("هل أنت متأكد أنك تريد تحديث هذا المستخدم ؟", "هل أنت متأكد", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            clsUser.enSaveResults SaveResult;

            UpdateUserData(frmLogin.CurrentUser);

            SaveResult = frmLogin.CurrentUser.Save();

            switch (SaveResult)
            {
                case clsUser.enSaveResults.svSucceeded:
                    {                       

                        MessageBox.Show("تم تحديث الحساب بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillUpdatedCurrentUser();
                        break;
                    }
                case clsUser.enSaveResults.svFaildEmptyObject:
                    {
                        MessageBox.Show("خطأ لم يتم حفظ حساب لأنه فارغ !", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    }
            }
        }


    }
}
