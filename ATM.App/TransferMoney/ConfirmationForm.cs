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

namespace ATM.App
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            lblFrom.Text = TransferMoneyFrm.FromCardNumber;
            lblTo.Text = TransferMoneyFrm.ToCardNumber;
            lblAmount.Text = TransferMoneyFrm.Amount;
            using (UnitOfWork db = new UnitOfWork())
            {
               lblNamed.Text = db.CardRepository.GetByCardNumber(long.Parse(lblTo.Text)).InTheNameOf;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
