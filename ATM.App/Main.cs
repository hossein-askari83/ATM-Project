using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.DataLayer;
using ATM.DataLayer.Contex;

namespace ATM.App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public static Users LoggedUser;
        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            SignInOrSignUpfrm Loginfrm = new SignInOrSignUpfrm();
            if (Loginfrm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SignInOrSignUpfrm Loginfrm = new SignInOrSignUpfrm();
            Loginfrm.UserID = LoggedUser.UserID;
            if (Loginfrm.ShowDialog() == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            CardsFrm cardsFrm = new CardsFrm();
            cardsFrm.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferMoneyFrm Transfer = new TransferMoneyFrm();
            if (Transfer.ShowDialog() == DialogResult.OK)
            {
                ReceiptFrm receiptFrm = new ReceiptFrm();
                receiptFrm.ShowDialog();
            }
        }

        private void btnCardBalance_Click(object sender, EventArgs e)
        {
            AddOrEditCardFrm Balance = new AddOrEditCardFrm();
            Balance.IsCheck = true;
            if (Balance.ShowDialog() == DialogResult.OK)
            {
                ReceiptFrm receiptFrm = new ReceiptFrm();
                receiptFrm.IsBalance = true;
                receiptFrm.ShowDialog();
            }
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            AddOrEditCardFrm Transaction = new AddOrEditCardFrm();
            Transaction.IsCheck = true;
            if (Transaction.ShowDialog() == DialogResult.OK)
            {
                RecentTransactionsFrm recentTransactionsFrm = new RecentTransactionsFrm();
                recentTransactionsFrm.ShowDialog();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            AddOrEditCardFrm Chek = new AddOrEditCardFrm();
            Chek.IsCheck = true;
            if (Chek.ShowDialog() == DialogResult.OK)
            {
                ChangePasswordFrm changepass = new ChangePasswordFrm();
                changepass.ShowDialog();
            }
        }
    }
}
