using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager
{
    class DBContext : System.Data.Entity.DbContext
    {
        public DBContext() : base("StoreManager")
        {

        }

        public System.Data.Entity.DbSet<Check> checks { get; set; }  


    }
}
