using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.ViewModel;
using ATM.DataLayer.Contex;
using System.Linq.Expressions;

namespace ATM.DataLayer.Services
{
    public class UserRepository : GenericRepository<Users>
    {
        private ATM_DBEntities _db;
        public UserRepository(ATM_DBEntities contex) : base(contex)
        {
            _db = contex;
        }
        public List<UserViewModel> GetUsernamePhoneUsercardid(Expression<Func<UserViewModel, bool>> where = null)
        {

            if (where == null)
            {
                return _db.Users.Select(u => new UserViewModel()
                {
                    UserName = u.UserName,
                    Phone = u.UserPhone,
                }).ToList();

            }

            return _db.Users.Select(u => new UserViewModel()
            {
                UserName = u.UserName,
                Phone = u.UserPhone,
            }).Where(where).ToList();
            


        }

        public virtual Users GetByUserName(string userName)
        {
            return _db.Users.Single(u => u.UserName == userName);
        }

        public virtual List<UserViewModel> GetUserNamePassword()
        {
            return _db.Users.Select(u => new UserViewModel()
            {
                UserName = u.UserName,
                Password = u.UserPassword,
            }).ToList();
        }

    }
}
