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
    public partial class ucCurrencyCalculator : UserControl
    {
        public ucCurrencyCalculator()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtFromCurrencyCode.Clear();
            txtToCurrencyCode.Clear();
            txtAmount.Clear();
            txtFromCurrencyCode.Focus();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFromCurrencyCode.Text) ||
             String.IsNullOrWhiteSpace(txtToCurrencyCode.Text) ||
             String.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("الرجاء ادخال الحقول !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if(!clsCurrency.IsCurrencyExist(txtFromCurrencyCode.Text.ToLower())
                || !clsCurrency.IsCurrencyExist(txtToCurrencyCode.Text.ToLower()))
            {
                MessageBox.Show("الرجاء ادخال رمز عملة صحيح !", "العملة غير موجودة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          

            clsCurrency FromCurrency = clsCurrency.FindByCode(txtFromCurrencyCode.Text);
            clsCurrency ToCurrency = clsCurrency.FindByCode(txtToCurrencyCode.Text);


            double AmountInCurrrencyTo = FromCurrency.ConvertToOtherCurrency(Convert.ToDouble(txtAmount.Text),ToCurrency);

            string message = $"{txtAmount.Text} {FromCurrency.GetCurrencyCode()} = {AmountInCurrrencyTo} {ToCurrency.GetCurrencyCode()}";

            MessageBox.Show($"    {message}    ", "تم التحويل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Clear();

        }
    }
}
