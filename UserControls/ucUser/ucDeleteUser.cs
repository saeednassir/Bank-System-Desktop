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
    public partial class ucDelete_User : UserControl
    {

        private clsUser CurrentUser;


        public ucDelete_User()
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

            btnDelete.Visible = false;
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
            btnDelete.Visible = true;
        }

        string SetPerPermissionsLabel(clsUser user)
        {
            string Permissions = "";

            if (user.GetPermissions() == -1)
            {
                Permissions = "جميع الصلاحيات";
                return Permissions;
            }

            if (user.CheckAccessPermission(clsUser.enPermissions.pListClients))
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

            return Permissions.Substring(0, Permissions.Length - 3);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                MessageBox.Show("الرجاء ادخال رقم المستخدم", " رقم المستخدم فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsUser.IsUserExist(txtUserName.Text.Trim()))
            {
                MessageBox.Show("لم يتم العثور على اسم المستخدم، قم باختيار اسم مستخدم اخر", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                VisibleAllLblFalse();
                return;
            }

            clsUser User = clsUser.Find(txtUserName.Text.Trim());

            CurrentUser = User;

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

        private void Clear()
        {
            txtUserName.Clear();
            lblValueFirstName.Text = "";
            lblValueLastName.Text = "";
            lblValueEmail.Text = "";
            lblValuePhone.Text = "";
            lblValuePassword.Text = "";
            lblValuePermissions.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا المستخدم ؟", "حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            if(CurrentUser.GetUserName() == frmLogin.CurrentUser.GetUserName())
            {
                MessageBox.Show("! لا يمكنك حذف حسابك المسجل به الدخول حالياً","لا يمكن حذف حسابك", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (CurrentUser.Delete())
            {
                Clear();
                VisibleAllLblFalse();
                MessageBox.Show("تم حذف المستخدم بنجاح", " تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("خطأ لم يتم حذف المستخدم", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




    }
}
