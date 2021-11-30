using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.ViewModel;

namespace ATM.DataLayer.Services
{
    public class CreditCardRepository : GenericRepository<CreditCards>
    {
        private ATM_DBEntities _db;
        public CreditCardRepository(ATM_DBEntities contex) : base(contex)
        {
            _db = contex;
        }

        public virtual CreditCards GetByCardNumber(long cardnumber)
        {
            return _db.CreditCards.SingleOrDefault(c => c.CardNumber == cardnumber);
        }

        public virtual List<CreditCardViewModel> GetCardNumbers()
        {
            return _db.CreditCards.Select(c => new CreditCardViewModel()
            {
                CardNumber = c.CardNumber
            }).ToList();
        }
    }
}
