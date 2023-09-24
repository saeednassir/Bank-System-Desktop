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
    public partial class ucMangeUsers : UserControl
    {

        ucAddNewUser ucAddNewUser = new ucAddNewUser();

        ucDelete_User ucDelete_User = new ucDelete_User();

        ucUpdateUser ucUpdateUser = new ucUpdateUser();

        ucFindUser ucFindUser = new ucFindUser();

        ucResetPassword ucResetPassword = new ucResetPassword();



        public ucMangeUsers()
        {
            InitializeComponent();

            ucListUsers ucListUsers = new ucListUsers();

            changeSidePanal(btnListUsers);
            addUserControl(ucListUsers);
        }

        void changeSidePanal(Button btn)
        {
            SidePanal.Height = btn.Height;
            SidePanal.Top = btn.Top;
        }

        void addUserControl(UserControl userControl)
        {
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(userControl);
                userControl.BringToFront();
            }
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            ucListUsers ucListUsers = new ucListUsers();

            changeSidePanal((Button)sender);
            addUserControl(ucListUsers);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucAddNewUser);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucDelete_User);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucUpdateUser);
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucFindUser);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucResetPassword);
        }


    }
}
