using Guna.UI.WinForms;
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
    public partial class ucAddNewClient : UserControl
    {
        public ucAddNewClient()
        {
            InitializeComponent();
        }

        private void ClearTexts()
        {
            txtAccountNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPinCode.Clear();
            txtAccountBalance.Clear();

            txtAccountNumber.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrWhiteSpace(txtAccountNumber.Text) || String.IsNullOrWhiteSpace(txtFirstName.Text) || String.IsNullOrWhiteSpace(txtLastName.Text) ||
                String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtPhone.Text) || String.IsNullOrWhiteSpace(txtPinCode.Text) || String.IsNullOrWhiteSpace(txtAccountBalance.Text))
            {
                MessageBox.Show("الرجاء ادخال الحقول !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsBankClient.IsClientExist(txtAccountNumber.Text.Trim()))
            {
                MessageBox.Show("رقم الحساب مستخدم بالفعل، اختر رقمًا آخر", "العميل موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsBankClient NewClient = clsBankClient.GetAddNewClientObject(txtAccountNumber.Text.Trim());

            NewClient.SetFirstName(txtFirstName.Text);
            NewClient.SetLastName(txtLastName.Text);
            NewClient.SetEmail(txtEmail.Text);
            NewClient.SetPhone(txtPhone.Text);
            NewClient.SetPinCode(txtPinCode.Text);
            NewClient.SetPinCode(txtPinCode.Text);
            NewClient.SetAccountBalance(Convert.ToDouble(txtAccountBalance.Text));

            clsBankClient.enSaveResults saveResults;

            saveResults = NewClient.Save();

            switch(saveResults)
            {
                case clsBankClient.enSaveResults.svSucceeded :
                    {
                        MessageBox.Show("تمت إضافة العميل بنجاح", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTexts();
                        break;
                    }
                case clsBankClient.enSaveResults.svFaildEmptyObject:
                    {
                        MessageBox.Show("خطأ لم يتم حفظ حساب العميل لأنه فارغ", "العنصر فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case clsBankClient.enSaveResults.svFaildAccountNumberExists:
                    {
                        MessageBox.Show("خطأ لم يتم حفظ حساب العميل لأنه موجود بالفعل", "العنصر فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }

        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            GunaLineTextBox txtBox = ((GunaLineTextBox)sender);

            if (String.IsNullOrWhiteSpace(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                errorProvider1.SetError(txtBox, "هذا الحقل مطلوب !");
            }else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBox, "");
            }
            
        }

       
    }
}
