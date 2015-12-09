using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace jthacker2747ex2e1dbmapper
{
    class AdventureWorksDbContext
    {
        public static SqlConnection connection;
        public static SqlTransaction transaction;
    }
}
