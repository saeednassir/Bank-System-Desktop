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
    public partial class ucUpdateClient : UserControl
    {
        public ucUpdateClient()
        {
            InitializeComponent();
        }

        private clsBankClient CurrentClient;

        private void VisibleAllTrue()
        {
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblEmail.Visible = true;
            lblPhone.Visible = true;
            lblPinCode.Visible = true;
            lblAccountBalance.Visible = true;

            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtEmail.Visible = true;
            txtPhone.Visible = true;
            txtPinCode.Visible = true;
            txtAccountBalance.Visible = true;

            btnSave.Visible = true;
            btnClear.Visible = true;

            txtAccountNumber.Enabled = false;
            btnFind.Enabled = false;
        }

        private void VisibleAllFalse()
        {
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblEmail.Visible = false;
            lblPhone.Visible = false;
            lblPinCode.Visible = false;
            lblAccountBalance.Visible = false;

            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            txtEmail.Visible = false;
            txtPhone.Visible = false;
            txtPinCode.Visible = false;
            txtAccountBalance.Visible = false;

            btnSave.Visible = false;
            btnClear.Visible = false;

            
        }

        private void FilltxtClient(clsBankClient Client)
        {

            txtFirstName.Text = Client.GetFirstName();
            txtLastName.Text = Client.GetLastName();
            txtEmail.Text = Client.GetEmail();
            txtPhone.Text = Client.GetPhone();
            txtPinCode.Text = Client.GetPinCode();
            txtAccountBalance.Text = Client.GetAccountBalance().ToString();

            VisibleAllTrue();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtAccountNumber.Text.Trim()))
            {
                MessageBox.Show("الرجاء ادخال رقم العميل", " رقم العميل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsBankClient.IsClientExist(txtAccountNumber.Text.Trim()))
            {
                MessageBox.Show("لم يتم العثور على رقم الحساب، قم باختيار رقم آخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountNumber.Clear();
                VisibleAllFalse();
                return;
            }

            clsBankClient Client = clsBankClient.Find(txtAccountNumber.Text.Trim());

            CurrentClient = Client;

            if (!Client.IsEmpty())
            {
                MessageBox.Show("تم العثور على رقم الحساب", " موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FilltxtClient(Client);
            }
            else
            {
                MessageBox.Show("لم يتم العثور على رقم الحساب، قم باختيار رقم آخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Clear()
        {
            txtAccountNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPinCode.Clear();
            txtAccountBalance.Clear();

            txtAccountNumber.Enabled = true;
            btnFind.Enabled = true;
            VisibleAllFalse();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UpdateClientData()
        {

            CurrentClient.SetFirstName(txtFirstName.Text);
            CurrentClient.SetLastName(txtLastName.Text);
            CurrentClient.SetEmail(txtEmail.Text);
            CurrentClient.SetPhone(txtPhone.Text);
            CurrentClient.SetPinCode(txtPinCode.Text);
            CurrentClient.SetAccountBalance(Convert.ToDouble(txtAccountBalance.Text));


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtEmail.Text)
                || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtPinCode.Text) || String.IsNullOrEmpty(txtAccountBalance.Text))
            {
                MessageBox.Show("الحقول فارغة , الرجاء ادخال جميع الحقول !", "الحقول فارغة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (DialogResult.No == MessageBox.Show("هل أنت متأكد أنك تريد تحديث هذا العميل ؟", "هل أنت متأكد", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            clsBankClient.enSaveResults SaveResult;

            UpdateClientData();

            SaveResult = CurrentClient.Save();

            switch (SaveResult)
            {
                case clsBankClient.enSaveResults.svSucceeded:
                    {
                        MessageBox.Show("تم تحديث الحساب بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        break;
                    }
                case clsBankClient.enSaveResults.svFaildEmptyObject:
                    {
                        MessageBox.Show("خطأ لم يتم حفظ حساب لأنه فارغ !", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    }
            }

        }



    }

}
