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
    public partial class ChangePasswordFrm : Form
    {
        public ChangePasswordFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(PassValidate())
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    CreditCards Card = new CreditCards()
                    {
                        Amount = AddOrEditCardFrm.Card.Amount,
                        CardID = AddOrEditCardFrm.Card.CardID,
                        CardNumber = AddOrEditCardFrm.Card.CardNumber,
                        Cvv2 = AddOrEditCardFrm.Card.Cvv2,
                        ExpirationDate = AddOrEditCardFrm.Card.ExpirationDate,
                        InTheNameOf = AddOrEditCardFrm.Card.InTheNameOf,
                        IssueDate = AddOrEditCardFrm.Card.IssueDate,
                        RegisteredPhone = AddOrEditCardFrm.Card.RegisteredPhone,
                        Password = int.Parse(txtNewPass.Text)
                    };
                    db.CardRepository.Update(Card);
                    db.Save();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Password changed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool PassValidate()
        {
            bool IsValid = false;
            if (txtNewPass.Text == txtConfirm.Text)
            {
                int Chek;
                if (int.TryParse(txtNewPass.Text, out Chek))
                {
                    if(txtNewPass.Text.Length == 4)
                    {
                        IsValid = true;
                    }
                    else
                    {
                        MessageBox.Show("Password Lenght Must be 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password characters must be numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords are not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IsValid;
        }
    }
}
