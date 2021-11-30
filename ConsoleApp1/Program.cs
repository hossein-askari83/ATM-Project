using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DataLayer;
using ATM.DataLayer.Contex;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();
          List<Users> ali =  db.UserRepository.GetAll().ToList();
        }
    }
}
