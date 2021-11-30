using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ATM.ViewModel;

namespace ATM.DataLayer.Services
{
    public class UsersCardsRepository : GenericRepository<UsersCards>
    {
        private ATM_DBEntities _db;
        public UsersCardsRepository(ATM_DBEntities contex) : base(contex)
        {
            _db = contex;
        }
        public virtual IEnumerable<int> GetAllCardID(int filter = 0)
        {
            if (filter == 0 )
            {
                return _db.UsersCards.Select(c => c.CardID);
            }
            return _db.UsersCards.Where(c => c.UserID == filter).Select(c => c.CardID);
        }

    }
}
