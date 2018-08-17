using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntityPostegre
{
    class Program
    {
        static void Main(string[] args)
        {

            Banco db = new Banco();
            db.Produtos.ToList()
                .ForEach(p => Console.WriteLine(p.Nome));


        }
    }
}
