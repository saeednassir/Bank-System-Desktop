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
    public partial class frmLogin : Form
    {
        public static clsUser CurrentUser;

        private byte FaildLoginCount = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم و كلمة المرور !", "الحقول فارغة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            clsUser user = clsUser.Find(txtUsername.Text,txtPassword.Text);

            if (!user.IsEmpty())
            {
                CurrentUser = user;
                CurrentUser.RegisterLogIn();
                new frmMain().Show();
                this.Hide();
                FaildLoginCount = 0;
            }else
            {
                FaildLoginCount++;
                MessageBox.Show($" المحاولة ( {FaildLoginCount} ) اسم المستخدم أو كلمة المرور غير صحيحة !","خطأ في اسم المستخدم أو كلمة المرور",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }

            if (FaildLoginCount == 3)
            {
                MessageBox.Show("ثلاث محاولات فاشلة , تم تعطيل الحساب الرجاء مراجعة الإدارة !", "الحساب معطل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
                chk_imgShowPassword.Enabled = false;
                return;

            }

        }

        private void chk_imgShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_imgShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }

}
