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
    public partial class ucUpdateRate : UserControl
    {

        private clsCurrency clscurrency;


        public ucUpdateRate()
        {
            InitializeComponent();
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCountry.Checked == true)
            {
                lblFindBy.Text = "الدولة";
            }
            else
            {
                lblFindBy.Text = "رمز العملة";
            }
        }

        private void VisibleAllLblTrue()
        {
            lblValueCountry.Visible = true;
            lblValueCurrencyCode.Visible = true;
            lblValueCurrencyName.Visible = true;
            txtValueRate.Visible = true;
            btnSave.Visible = true;
        }

        private void VisibleAllLblFalse()
        {
            lblValueCountry.Visible = false;
            lblValueCurrencyCode.Visible = false;
            lblValueCurrencyName.Visible = false;
            txtValueRate.Visible = false;
            btnSave.Visible=false;
        }

        private void FillLblUser(clsCurrency Currency)
        {

            lblValueCountry.Text = Currency.GetCountry();
            lblValueCurrencyCode.Text = Currency.GetCurrencyCode();
            lblValueCurrencyName.Text = Currency.GetCurrencyName();
            txtValueRate.Text = Currency.GetRate().ToString();

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

            }
            else
            {
                Currency = clsCurrency.FindByCode(txtFindBy.Text.Trim());

            }

                clscurrency =Currency;

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

        private void Clear()
        {
            rbCountry.Checked = true;
            txtFindBy.Clear();

            lblValueCountry.Text = "";
            lblValueCurrencyCode.Text = "";
            lblValueCurrencyName.Text = "";

            txtValueRate.Clear();
            VisibleAllLblFalse();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtValueRate.Text))
            {
                MessageBox.Show("الحقل فارغ , الرجاء ادخال سعر العملة !", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         

            if (DialogResult.No == MessageBox.Show("هل أنت متأكد أنك تريد تحديث سعر العملة ؟", "هل أنت متأكد", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            clscurrency.UpdateRate(Convert.ToDouble(txtValueRate.Text));

            MessageBox.Show("تم تحديث سعر العملة !", "تم تحديث سعر العملة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            Clear();

        }


    }
}
