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
    public partial class ucTransfer : UserControl
    {
        public ucTransfer()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtAccountNumberSourceClient.Clear();
            txtAccountNumberDestinationClient.Clear();
            txtAmount.Clear();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtAccountNumberSourceClient.Text) ||
               String.IsNullOrWhiteSpace(txtAccountNumberDestinationClient.Text) ||
               String.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("الرجاء ادخال الحقول !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.No == MessageBox.Show("هل أنت متأكد أنك تريد إجراء هذه العملية؟", "تحويل", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            clsBankClient SourceClient = clsBankClient.Find(txtAccountNumberSourceClient.Text.Trim());

            if(SourceClient.IsEmpty())
            {
                MessageBox.Show("حساب المرسل منه غير موجود !", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsBankClient DestinationClient = clsBankClient.Find(txtAccountNumberDestinationClient.Text.Trim());

            if (DestinationClient.IsEmpty())
            {
                MessageBox.Show("حساب المرسل إليه غير موجود !", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(SourceClient.GetAccountNumber() == DestinationClient.GetAccountNumber())
            {
                MessageBox.Show("لا يمكن إرسال إلى نفس الحساب !", "الحسابين متشابهين", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SourceClient.Transfer(Convert.ToDouble(txtAmount.Text.Trim()), DestinationClient,frmLogin.CurrentUser.GetUserName()))
            {
                MessageBox.Show("تمت عملية التحويل بنجاح", "تم التحويل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show($"لا يمكن التحويل، الرصيد غير كافي رصيد المرسل منه هو {SourceClient.GetAccountBalance()}!", "المبلغ غير كافي", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
