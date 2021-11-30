using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.DataLayer.Contex;
using ATM.DataLayer;

namespace ATM.App
{
    public partial class ReceiptFrm : Form
    {
        public ReceiptFrm()
        {
            InitializeComponent();
        }
        public bool IsBalance;
        private void ReceiptFrm_Load(object sender, EventArgs e)
        {
            if (!IsBalance)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Receipts Receipt = db.ReceiptsRepository.Get(TransferMoneyFrm.ReceiptID);
                    lblAmount.Text = Receipt.TransactionAmount.ToString();
                    lblFrom.Text = db.CardRepository.Get(Receipt.OriginCardID).CardNumber.ToString();
                    lblTo.Text = db.CardRepository.Get(Receipt.DestinationCardID).CardNumber.ToString();
                    lblDate.Text = Receipt.TransactionDate.ToString();
                    lblDesc.Text = Receipt.Description;
                }
            }
            else
            {
                lblTo.Visible = false;
                label4.Visible = false;
                lblDesc.Visible = false;
                label6.Visible = false;
                lblFrom.Text = AddOrEditCardFrm.Card.CardNumber.ToString();
                lblAmount.Text = AddOrEditCardFrm.Card.Amount.ToString();
                lblDate.Text = DateTime.Now.ToString();

            }
        }
    }
}
