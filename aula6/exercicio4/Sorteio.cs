using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    class Sorteio
    {
        public int num;

        public int sorteio()
        {
            Random escolheNum = new Random();

            num = escolheNum.Next();

            Console.WriteLine($"A escolha do computador foi:{num}");

            return num;
        }

       
    }
}
