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
    public partial class RecentTransactionsFrm : Form
    {
        public RecentTransactionsFrm()
        {
            InitializeComponent();
        }

        private void RecentTransactionsFrm_Load(object sender, EventArgs e)
        {
            dgTransactions.AutoGenerateColumns = false;
            using(UnitOfWork db = new UnitOfWork())
            {
                string Type = "";
                string OriginCardNumber;
                string DestinationCardNumber;
                var Transactions = db.ReceiptsRepository.GetAll(c => c.OriginCardID == AddOrEditCardFrm.Card.CardID || c.DestinationCardID == AddOrEditCardFrm.Card.CardID).ToList();
                foreach (var Transaction in Transactions)
                {
                    if (Transaction.DestinationCardID.ToString() == AddOrEditCardFrm.Card.CardID.ToString())
                    {
                        Type = "Recive";
                        OriginCardNumber = db.CardRepository.Get(Transaction.OriginCardID).CardNumber.ToString();
                        DestinationCardNumber = AddOrEditCardFrm.Card.CardNumber.ToString();
                    }
                    else
                    {
                        Type = "Pay";
                        OriginCardNumber = AddOrEditCardFrm.Card.CardNumber.ToString();
                        DestinationCardNumber = db.CardRepository.Get(Transaction.DestinationCardID).CardNumber.ToString();
                    }
                    dgTransactions.Rows.Add(Transaction.TransactionID, Type, Transaction.TransactionAmount, OriginCardNumber, DestinationCardNumber, Transaction.TransactionDate, Transaction.Description);
                }
            }
        }
    }
}
