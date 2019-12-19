using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;


namespace Sample
{
    public class Context : DbContext
    {
        public Context() : base("Connection") { }
        public DbSet <User> Users { get; set; }
        public DbSet <History> Histories { get; set; }
    }
}
