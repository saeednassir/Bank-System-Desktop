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
    public partial class ucFindCurrency : UserControl
    {
        public ucFindCurrency()
        {
            InitializeComponent();
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCountry.Checked == true)
            {
                lblFindBy.Text = "الدولة";
            }else
            {
                lblFindBy.Text = "رمز العملة";
            }
        }

        void VisibleAllLblTrue()
        {
            lblValueCountry.Visible = true;
            lblValueCurrencyCode.Visible = true;
            lblValueCurrencyName.Visible = true;
            lblValueRate.Visible = true;
           
        }

        void VisibleAllLblFalse()
        {
            lblValueCountry.Visible = false;
            lblValueCurrencyCode.Visible = false;
            lblValueCurrencyName.Visible = false;
            lblValueRate.Visible = false;
           
        }

        private void FillLblUser(clsCurrency Currency)
        {

            lblValueCountry.Text = Currency.GetCountry();
            lblValueCurrencyCode.Text = Currency.GetCurrencyCode();
            lblValueCurrencyName.Text = Currency.GetCurrencyName();
            lblValueRate.Text = Currency.GetRate().ToString();
           
            VisibleAllLblTrue();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            

            if (String.IsNullOrWhiteSpace(txtFindBy.Text))
            {
                MessageBox.Show("الرجاء ادخال الحقل ", " الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            clsCurrency Currency;

            if (rbCountry.Checked)
            {
                 Currency = clsCurrency.FindByCountry(txtFindBy.Text.Trim());

            }else
            {
                 Currency = clsCurrency.FindByCode(txtFindBy.Text.Trim());

            }


            if (!Currency.IsEmpty())
            {
                MessageBox.Show("تم العثور على العملة", " موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillLblUser(Currency);
            }
            else
            {
                MessageBox.Show("لم يتم العثور على العملة", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindBy.Clear();
                txtFindBy.Focus();
                VisibleAllLblFalse();
            }

        }

    }
}
