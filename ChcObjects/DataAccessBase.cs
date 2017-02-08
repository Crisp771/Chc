using ChcDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    public class DataAccessBase
    {
        protected readonly IChcDBEntities _context;

        public DataAccessBase()
        {
            _context = new ChcDBEntities();
        }

        public DataAccessBase(IChcDBEntities context)
        {
            _context = context;
        }
    }
}
