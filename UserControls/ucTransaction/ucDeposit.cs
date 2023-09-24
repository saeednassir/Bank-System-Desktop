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
    public partial class ucDeposit : UserControl
    {

        clsBankClient CurrentClient;



        public ucDeposit()
        {
            InitializeComponent();
        }

        void VisibleAllLblTrue()
        {
            lblValueFirstName.Visible = true;
            lblValueLastName.Visible = true;
            lblValueEmail.Visible = true;
            lblValuePhone.Visible = true;
            lblValuePinCode.Visible = true;
            lblValueAccountBalance.Visible = true;

            lblAmount.Visible = true;
            txtAmount.Visible = true;
            btnDeposit.Visible = true;

        }

        void VisibleAllLblFalse()
        {
            lblValueFirstName.Visible = false;
            lblValueLastName.Visible = false;
            lblValueEmail.Visible = false;
            lblValuePhone.Visible = false;
            lblValuePinCode.Visible = false;
            lblValueAccountBalance.Visible = false;


            lblAmount.Visible = false;
            txtAmount.Visible = false;
            btnDeposit.Visible = false;

        }

        private void FillLblClient(clsBankClient Client)
        {

            lblValueFirstName.Text = Client.GetFirstName();
            lblValueLastName.Text = Client.GetLastName();
            lblValueEmail.Text = Client.GetEmail();
            lblValuePhone.Text = Client.GetPhone();
            lblValuePinCode.Text = Client.GetPinCode();
            lblValueAccountBalance.Text = Client.GetAccountBalance().ToString();

            VisibleAllLblTrue();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAccountNumber.Text.Trim()))
            {
                MessageBox.Show("الرجاء ادخال رقم العميل", " رقم العميل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsBankClient.IsClientExist(txtAccountNumber.Text.Trim()))
            {
                MessageBox.Show("لم يتم العثور على رقم الحساب، قم باختيار رقم آخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountNumber.Clear();
                VisibleAllLblFalse();
                return;
            }

            clsBankClient Client = clsBankClient.Find(txtAccountNumber.Text.Trim());

            CurrentClient = Client;

            if (!Client.IsEmpty())
            {
                MessageBox.Show("تم العثور على رقم الحساب", " موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("لم يتم العثور على رقم الحساب، قم باختيار رقم آخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            FillLblClient(Client);
        }

        private void Clear()
        {
            txtAccountNumber.Clear();

            lblValueFirstName.Text = "";
            lblValueLastName.Text = "";
            lblValueEmail.Text = "";
            lblValuePhone.Text = "";
            lblValuePinCode.Text = "";
            lblValueAccountBalance.Text = "";

            txtAmount.Clear();

            VisibleAllLblFalse();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAmount.Text.Trim()))
            {
                MessageBox.Show("الرجاء ادخال المبلغ !", "المبلغ فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.No == MessageBox.Show("هل أنت متأكد أنك تريد إجراء هذه العملية؟", "إيداع",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                return;
            }

            

            CurrentClient.Deposit(Convert.ToDouble(txtAmount.Text.Trim()));

            lblValueAccountBalance.Text = CurrentClient.GetAccountBalance().ToString();
            MessageBox.Show($"تم إيداع المبلغ بنجاح الرصيد الحالي هو {CurrentClient.GetAccountBalance()}.", "تم الإيداع", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Clear();

        }



    }
}
