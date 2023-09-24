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
    public partial class ucUpdateUser : UserControl
    {

        private clsUser CurrentUSer;


        public ucUpdateUser()
        {
            InitializeComponent();
        
        }

        private void VisibleAllTrue()
        {
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblEmail.Visible = true;
            lblPhone.Visible = true;
            lblPassword.Visible = true;
            lblPermations.Visible = true;

            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtEmail.Visible = true;
            txtPhone.Visible = true;
            txtPassword.Visible = true;
            
            //chk
            chkAll.Visible = true;
            chkShowListClient.Visible = true;
            chkAddNewClient.Visible = true;
            chkDeleteClient.Visible = true;
            chkUpdateClient.Visible = true;
            chkFindClient.Visible = true;
            chkTransactions.Visible = true;
            chkCurrencyExchange.Visible = true;
            chkLoginRegister.Visible = true;
            chkMangeUsers.Visible = true;

            btnSave.Visible = true;
            btnClear.Visible = true;

            txtUserName.Enabled = false;
            btnFind.Enabled = false;
        }

        private void VisibleAllFalse()
        {
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblEmail.Visible = false;
            lblPhone.Visible = false;
            lblPassword.Visible = false;
            lblPermations.Visible = false;

            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            txtEmail.Visible = false;
            txtPhone.Visible = false;
            txtPassword.Visible = false;

            //chk
            chkAll.Visible = false;
            chkShowListClient.Visible = false;
            chkAddNewClient.Visible = false;
            chkDeleteClient.Visible = false;
            chkUpdateClient.Visible = false;
            chkFindClient.Visible = false;
            chkTransactions.Visible = false;
            chkCurrencyExchange.Visible = false;
            chkLoginRegister.Visible = false;
            chkMangeUsers.Visible = false;

            btnSave.Visible = false;
            btnClear.Visible = false;


        }

        private void chkPerPermissions(clsUser user)
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

        private void FilltxtUser(clsUser User)
        {

            txtFirstName.Text = User.GetFirstName();
            txtLastName.Text = User.GetLastName();
            txtEmail.Text = User.GetEmail();
            txtPhone.Text = User.GetPhone();
            txtPassword.Text = User.GetPassword();

            //chk
            chkPerPermissions(User);

            VisibleAllTrue();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                MessageBox.Show("الرجاء ادخال اسم المستخدم", " اسم المستخدم فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsUser.IsUserExist(txtUserName.Text.Trim()))
            {
                MessageBox.Show("لم يتم العثور على رقم الحساب، قم باختيار رقم آخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                VisibleAllFalse();
                return;
            }

            clsUser user = clsUser.Find(txtUserName.Text.Trim());

            CurrentUSer = user;

            if (!user.IsEmpty())
            {
                MessageBox.Show("تم العثور على رقم الحساب", " موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FilltxtUser(user);
            }
            else
            {
                MessageBox.Show("لم يتم العثور على رقم الحساب، قم باختيار رقم آخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Clear()
        {
            txtUserName.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();

            //chk
            chkMangeUsers.Checked =false;
            chkLoginRegister.Checked =false;
            chkCurrencyExchange.Checked =false;
            chkTransactions.Checked =false;
            chkFindClient.Checked =false;
            chkUpdateClient.Checked =false;
            chkDeleteClient.Checked =false;
            chkAddNewClient.Checked =false;
            chkShowListClient.Checked = false;

            txtUserName.Enabled = true;
            btnFind.Enabled = true;
            VisibleAllFalse();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private int CalcPermissions()
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

        private void Enable_chkPermissions()
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

        private void Disable_chkPermissions()
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

        private void UpdateUserData(clsUser User)
        {

            User.SetFirstName(txtFirstName.Text);
            User.SetLastName(txtLastName.Text);
            User.SetEmail(txtEmail.Text);
            User.SetPhone(txtPhone.Text);
            User.SetPassword(txtPassword.Text);

            User.SetPermissions(CalcPermissions());


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

            UpdateUserData(CurrentUSer);

            SaveResult = CurrentUSer.Save();

            switch (SaveResult)
            {
                case clsUser.enSaveResults.svSucceeded:
                    {
                        if(CurrentUSer.GetUserName() == frmLogin.CurrentUser.GetUserName())
                        {
                            frmLogin.CurrentUser = CurrentUSer;
                        }

                        MessageBox.Show("تم تحديث الحساب بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
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
