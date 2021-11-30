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
    public partial class AddOrEditCardFrm : Form
    {
        public AddOrEditCardFrm()
        {
            InitializeComponent();
        }
        public bool IsCheck;
        public static CreditCards Card;
        private void AddOrEditCardFrm_Load(object sender, EventArgs e)
        {
            if (IsCheck)
            {
                this.Text = "Confirm";
                btnSubmit.Text = "Submit";
                foreach (var Card in CardsFrm.GetLoggedUserCards())
                {
                    txtCardNumber.Items.Add(Card.CardNumber);
                }
            }
            else
            {
                this.Text = "Add Card";
                btnSubmit.Text = "Add";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (!IsCheck)
                {

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        UsersCards NewOwnership = new UsersCards()
                        {
                            UserID = Main.LoggedUser.UserID,
                            CardID = db.CardRepository.GetByCardNumber(long.Parse(txtCardNumber.Text)).CardID
                        };
                        db.UsersCardsRepository.Insert(NewOwnership);
                        db.Save();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    using(UnitOfWork db = new UnitOfWork())
                    {
                        Card = db.CardRepository.GetByCardNumber(long.Parse(txtCardNumber.Text));
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private bool IsValid()
        {
            bool Isvalid = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                bool IsCardExist = db.CardRepository.GetCardNumbers().Any(c => c.CardNumber == long.Parse(txtCardNumber.Text));
                if (IsCardExist)
                {
                    CreditCards Card = db.CardRepository.GetByCardNumber(long.Parse(txtCardNumber.Text));
                    if (Card.Password == long.Parse(txtPassword.Text))
                    {
                        if (!IsCheck)
                        {
                            if (Card.RegisteredPhone == Main.LoggedUser.UserPhone)
                            {
                                if (db.UsersCardsRepository.GetAllCardID().All(c => c != Card.CardID))
                                {
                                    Isvalid = true;
                                }
                                else
                                {
                                    MessageBox.Show("Card Is Used By Another Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Card Is Not Registered With Your Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            Isvalid = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password Is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Card With This Number Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return Isvalid;
        }

        private void txtCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtPassword.Visible = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                txtPassword.Text = db.CardRepository.GetByCardNumber(long.Parse(txtCardNumber.Text)).Password.ToString();
            }
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            txtPassword.Visible = true;
            txtPassword.Text = "";
        }
    }
}
