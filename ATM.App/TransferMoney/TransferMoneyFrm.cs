using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Utility;
using ATM.DataLayer.Contex;
using ValidationComponents;
using ATM.DataLayer;
using ATM.Business;

namespace ATM.App
{
    public partial class TransferMoneyFrm : Form
    {
        public TransferMoneyFrm()
        {
            InitializeComponent();
        }
        public static string FromCardNumber;
        public static string ToCardNumber;
        public static string Amount;
        public static int ReceiptID;
        private void TransferMoneyFrm_Load(object sender, EventArgs e)
        {
            foreach (var Card in CardsFrm.GetLoggedUserCards())
            {
                txtFromCardNumber.Items.Add(Card.CardNumber);
                txtToCardNumber.Items.Add(Card.CardNumber);
            }
            lblCode.Text = GRandom.RandomString(5);
        }

        private void txtChangeCode_Click(object sender, EventArgs e)
        {
            lblCode.Text = GRandom.RandomString(5);
        }

        private void txtFromCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPass.Visible = false;
            txtPassword.Visible = false;
            lblDate.Visible = false;
            lblMonth.Visible = false;
            txtMonth.Visible = false;
            lblYear.Visible = false;
            txtYear.Visible = false;
            lblCvv2.Visible = false;
            txtCvv2.Visible = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                var Card = db.CardRepository.GetByCardNumber(long.Parse(txtFromCardNumber.Text));
                DateTime ExpireDate = Card.ExpirationDate;
                txtYear.Text = ExpireDate.Year.ToString();
                txtMonth.Text = ExpireDate.Month.ToString();
                txtPassword.Text = Card.Password.ToString();
                txtCvv2.Text = Card.Cvv2.ToString();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                FromCardNumber = txtFromCardNumber.Text;
                ToCardNumber = txtToCardNumber.Text;
                Amount = txtAmount.Value.ToString();
                ConfirmationForm confirmation = new ConfirmationForm();
                if (confirmation.ShowDialog() == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        CreditCards OriginCard = db.CardRepository.GetByCardNumber(long.Parse(txtFromCardNumber.Text));
                        CreditCards DestinationCard = db.CardRepository.GetByCardNumber(long.Parse(txtToCardNumber.Text));
                        Receipts newTransaction = new Receipts()
                        {
                            TransactionAmount = int.Parse(txtAmount.Value.ToString()),
                            OriginCardID = OriginCard.CardID,
                            DestinationCardID = DestinationCard.CardID,
                            TransactionDate = DateTime.Now,
                            Description = txtDesc.Text
                        };
                        Calculate.CalculateAmount(OriginCard, DestinationCard, int.Parse(txtAmount.Value.ToString()));
                        db.ReceiptsRepository.Insert(newTransaction);
                        db.Save();
                        ReceiptID = newTransaction.TransactionID;
                        DialogResult = DialogResult.OK;
                    }
                }
                this.Close();
            }
        }

        private bool Validator()
        {
            bool IsValid = false; ;
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    bool IsFromCardsExist = db.CardRepository.GetCardNumbers().Any(c => c.CardNumber == long.Parse(txtFromCardNumber.Text));
                    bool IsToCardExitst = db.CardRepository.GetCardNumbers().Any(c => c.CardNumber == long.Parse(txtToCardNumber.Text));
                    if (IsFromCardsExist && IsToCardExitst)
                    {
                        if (txtFromCardNumber.Text != txtToCardNumber.Text)
                        {
                            var Card = db.CardRepository.GetByCardNumber(long.Parse(txtFromCardNumber.Text));
                            if (Card.Password.ToString() == txtPassword.Text && Card.ExpirationDate.Year.ToString() == txtYear.Text && Card.ExpirationDate.Month.ToString() == txtMonth.Text && Card.Cvv2.ToString() == txtCvv2.Text)
                            {
                                if (lblCode.Text == txtCode.Text)
                                {
                                    if (Card.Amount >= txtAmount.Value)
                                    {
                                        IsValid = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Inventory is not enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Security code is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Card Information is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Origin and destination cards are same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Card Number is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return IsValid;
        }

        private void txtFromCardNumber_TextChanged(object sender, EventArgs e)
        {
            lblPass.Visible = true;
            txtPassword.Visible = true;
            lblDate.Visible = true;
            lblMonth.Visible = true;
            txtMonth.Visible = true;
            lblYear.Visible = true;
            txtYear.Visible = true;
            lblCvv2.Visible = true;
            txtCvv2.Visible = true;

            txtPassword.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            txtCvv2.Text = "";
        }

        private void txtFromCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCvv2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtToCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
