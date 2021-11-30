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
    public partial class CardsFrm : Form
    {
        public CardsFrm()
        {
            InitializeComponent();
        }
        private void CardsFrm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgCards.AutoGenerateColumns = false;
            dgCards.DataSource = GetLoggedUserCards();

        }
        public static List<CreditCards> GetLoggedUserCards()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                IEnumerable<int> CardIDs = db.UsersCardsRepository.GetAllCardID(Main.LoggedUser.UserID).ToList();
                List<CreditCards> Cards = new List<CreditCards>();
                foreach (var CardID in CardIDs)
                {
                    Cards.Add(db.CardRepository.Get(CardID));
                }
                return Cards;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrEditCardFrm addOrEditCardFrm = new AddOrEditCardFrm();
            if (addOrEditCardFrm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCards.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Are you sure ?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        foreach (DataGridViewRow row in dgCards.SelectedRows)
                        {
                            int ID = int.Parse(row.Cells[0].Value.ToString());
                            db.UsersCardsRepository.Delete(db.UsersCardsRepository.GetAll(c => c.CardID == ID).First());
                        }
                        db.Save();
                    }
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please Select row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
