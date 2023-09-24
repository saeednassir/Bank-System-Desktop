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
    public partial class ucResetPassword : UserControl
    {
        public ucResetPassword()
        {
            InitializeComponent();
        }

        private void chk_imgOldPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_imgOldPass.Checked)
            {
               txtOldPassword.UseSystemPasswordChar = false;
                

            }
            else
            {
                txtOldPassword.UseSystemPasswordChar = true;
              


            }
        }

        private void chk_imgNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_imgNewPass.Checked)
            {
                txtNewPassword.UseSystemPasswordChar=false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void chk_imgRestNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_imgRestNewPass.Checked)
            {
                txtRestNewPassword.UseSystemPasswordChar = false;
            }
            else
            {

                txtRestNewPassword.UseSystemPasswordChar = true;
            }
        }       

        private void ucResetPassword_Load(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtRestNewPassword.UseSystemPasswordChar = true;

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtOldPassword.Text) || String.IsNullOrWhiteSpace(txtNewPassword.Text)
                || String.IsNullOrWhiteSpace(txtRestNewPassword.Text))
            {
                MessageBox.Show("الرجاء إدخال الحقول !","الحقول فارغة",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(txtNewPassword.Text == txtOldPassword.Text)
            {
                MessageBox.Show("الرجاء إدخال كلمة مرور جديدة، وليس مثل كلمة المرور القديمة !", "الكلمة القديمة مثل الكلمة الجديدة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNewPassword.Text != txtRestNewPassword.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة !", "غير متطابقة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtOldPassword.Text != frmLogin.CurrentUser.GetPassword())
            {
                MessageBox.Show("كلمة المرور القديمة غير صحيحة !", "كلمة المرور القديمة خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           if(DialogResult.No == MessageBox.Show("هل أنت متأكد أنك تريد إجراء هذه العملية؟", "تغير كلمة المرور", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            if(frmLogin.CurrentUser.ResetPassword(txtNewPassword.Text) == clsUser.enSaveResults.svSucceeded)
            {
                MessageBox.Show("تم تغير كلمة المرور بنجاح !", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Clear();
                txtNewPassword.Clear();
                txtRestNewPassword.Clear();

            }else
            {
                MessageBox.Show("فشلت عملية تغير كلمة المرور !", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


    }
}
