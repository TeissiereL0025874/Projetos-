using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int cdo;
            double pr;
            Console.Write("Digite o preço do produto:");
            pr = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código de origem de '1' até '5'");
            cdo = int.Parse(Console.ReadLine());
            switch (cdo)
            {
                case 1:
                    Console.WriteLine("O preço do produto é de R$ {0}", pr + " e sua procedência é Sul");
                    break;
                case 2:
                    Console.WriteLine("O preço do produto é de R$ {0}", pr + " e sua procedência é Sudeste");
                    break;
                case 3:
                    Console.WriteLine("O preço do produto é de R$ {0}", pr + " e sua procedência é Centro-Oeste");
                    break;
                case 4:
                    Console.WriteLine("O preço do produto é de R$ {0}", pr + " e sua procedência é Norte");
                    break;
                case 5:
                    Console.WriteLine("O preço do produto é de R$ {0}", pr + " e sua procedência é Nordeste");
                    break;
            }
            Console.ReadKey();
            }
    }
}
