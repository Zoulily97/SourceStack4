using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    class Helper
    {
        private static SqlDbcontext _context;
        static  Helper()
        {
            _context = new SqlDbcontext();

        }
        internal static SqlDbcontext GetDbcontext() => _context;
    }
}
