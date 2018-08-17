using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntityPostegre
{
    public class Banco : DbContext
    {
        public Banco() : base("entity")
        {
        }

        public DbSet<Produto> Produtos { get; set; }

    }

}
