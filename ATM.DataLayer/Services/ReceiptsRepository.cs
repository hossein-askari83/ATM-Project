using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataLayer.Services
{
    public class ReceiptsRepository : GenericRepository<Receipts>
    {
        private ATM_DBEntities _db;
        public ReceiptsRepository(ATM_DBEntities contex) : base(contex)
        {
            _db = contex;
        }
    }
}
