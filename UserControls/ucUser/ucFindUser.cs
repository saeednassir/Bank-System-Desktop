using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ucFindUser : UserControl
    {
        public ucFindUser()
        {
            InitializeComponent();
        }

        void VisibleAllLblTrue()
        {
            lblValueFirstName.Visible = true;
            lblValueLastName.Visible = true;
            lblValueEmail.Visible = true;
            lblValuePhone.Visible = true;
            lblValuePassword.Visible = true;
            lblValuePermissions.Visible = true;
        }

        void VisibleAllLblFalse()
        {
            lblValueFirstName.Visible = false;
            lblValueLastName.Visible = false;
            lblValueEmail.Visible = false;
            lblValuePhone.Visible = false;
            lblValuePassword.Visible = false;
            lblValuePermissions.Visible = false;
        }

        private void FillLblUser(clsUser User)
        {

            lblValueFirstName.Text = User.GetFirstName();
            lblValueLastName.Text = User.GetLastName();
            lblValueEmail.Text = User.GetEmail();
            lblValuePhone.Text = User.GetPhone();
            lblValuePassword.Text = User.GetPassword();
            lblValuePermissions.Text = SetPerPermissionsLabel(User);

            VisibleAllLblTrue();

        }

        string SetPerPermissionsLabel(clsUser user)
        {
            string Permissions = "";

            if(user.GetPermissions() == -1)
            {
                Permissions = "جميع الصلاحيات";
                return Permissions;
            }

            if(user.CheckAccessPermission(clsUser.enPermissions.pListClients))
            {
                Permissions += "عرض قائمة العملاء" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pAddNewClient))
            {
                Permissions += "إضافة عميل جديد" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pDeleteClient))
            {
                Permissions += "حذف العميل" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pUpdateClients))
            {
                Permissions += "تعديل العميل" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pFindClient))
            {
                Permissions += "ابحث عن العميل" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pTranactions))
            {
                Permissions += "المعاملات" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pCurrencyExchange))
            {
                Permissions += "تحويل العملات" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pRegisterLogin))
            {
                Permissions += "سجل الدخول" + " , ";
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                Permissions += "ادارة المستخدمين" + " , ";
            }

            return Permissions.Substring(0,Permissions.Length - 3);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("الرجاء ادخال رقم المستخدم", " رقم المستخدم فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsUser.IsUserExist(txtUsername.Text.Trim()))
            {
                MessageBox.Show("لم يتم العثور على اسم المستخدم، قم باختيار اسم مستخدم اخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                VisibleAllLblFalse();
                return;
            }

            clsUser User = clsUser.Find(txtUsername.Text.Trim());

            if (!User.IsEmpty())
            {
                MessageBox.Show("تم العثور على رقم المستخدم", " موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("لم يتم العثور على اسم المستخدم، قم باختيار اسم مستخدم اخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            FillLblUser(User);
        }

        
    }
}
