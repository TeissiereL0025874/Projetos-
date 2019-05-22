using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double pre, codpag, r;
            Console.Write("Digite o código da etiqueta ");
            codpag = double.Parse(Console.ReadLine());
            Console.Write("Digite o preço do código da etiqueta ");
            pre = double.Parse(Console.ReadLine());
            if (codpag == 1)
            {
                r = pre - (pre * 0.01);
                Console.WriteLine("O valor é de {0}", r);
            }
             if (codpag == 2)
            {
                r = pre - (pre * 0.05);
                Console.WriteLine("O valor é de {0}", r);

            }
             if (codpag == 3)
    
            {
                r = pre / 2;
                Console.WriteLine("O valor é de {0}", r);
            }
            if (codpag == 4)

            {
                r = pre / 3;
                Console.WriteLine("O valor é de {0}", r);
            }
            Console.ReadKey();
        }
    }
}
