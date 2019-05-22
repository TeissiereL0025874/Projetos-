using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int an, at, r;
            Console.WriteLine("Digite o ano de seu nascimento");
            an = int.Parse(Console.ReadLine());
            at = 2019;
            r = at - an;
            if (r >= 16)
            {
                Console.WriteLine("{0} anos", r);
                Console.WriteLine("Já pode votar");
            }
         
            if (r > 18)
            {
                Console.WriteLine("já pode conseguir a carteira de habilitação");
            }
            Console.ReadKey();
        }
    }
}
