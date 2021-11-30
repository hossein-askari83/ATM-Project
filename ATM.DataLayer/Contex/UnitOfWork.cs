using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DataLayer;
using ATM.DataLayer.Repository;
using ATM.DataLayer.Services;

namespace ATM.DataLayer.Contex
{
    public class UnitOfWork : IDisposable
    {
        ATM_DBEntities db = new ATM_DBEntities();

        private UserRepository _userRepository;
        public UserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    return _userRepository = new UserRepository(db);
                }
                return _userRepository;
            }
        }
        private CreditCardRepository _cardrepository;
        public CreditCardRepository CardRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    return _cardrepository = new CreditCardRepository(db);
                }
                return _cardrepository;
            }
        }

        private UsersCardsRepository _userscardsRepository;
        public UsersCardsRepository UsersCardsRepository
        {
            get
            {
                if (_userscardsRepository == null)
                {
                    return _userscardsRepository = new UsersCardsRepository(db);
                }
                return _userscardsRepository;
            }
        }

        private ReceiptsRepository _receiptsRepository;
        public ReceiptsRepository ReceiptsRepository
        {
            get
            {
                if(_receiptsRepository == null)
                {
                    return _receiptsRepository = new ReceiptsRepository(db);
                }
                return _receiptsRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }

    }

}
