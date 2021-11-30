using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DataLayer;

namespace ATM.Business
{
    public class Calculate
    {
        public static void CalculateAmount(CreditCards origincard, CreditCards destinationcard, int amount)
        {
            origincard.Amount -= amount;
            destinationcard.Amount += amount;
        }
    }
}
