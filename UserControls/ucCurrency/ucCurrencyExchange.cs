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
    public partial class ucCurrencyExchange : UserControl
    {

        ucListCurrensise ucListCurrensise = new ucListCurrensise();

        ucFindCurrency ucFindCurrency = new ucFindCurrency();

        ucUpdateRate ucUpdateRate = new ucUpdateRate();

        ucCurrencyCalculator ucCurrencyCalculator = new ucCurrencyCalculator();


        public ucCurrencyExchange()
        {
            InitializeComponent();

            changeSidePanal(btnListCurrensise);
            addUserControl(ucListCurrensise);
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

        private void btnListCurrensise_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucListCurrensise);
        }

        private void btnFindCurrency_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucFindCurrency);
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucUpdateRate);
        }

        private void btnCurrencyCalculator_Click(object sender, EventArgs e)
        {
            changeSidePanal((Button)sender);
            addUserControl(ucCurrencyCalculator);
        }


    }
}
