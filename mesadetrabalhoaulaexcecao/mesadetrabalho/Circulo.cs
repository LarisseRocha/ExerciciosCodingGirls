using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesadetrabalho
{
   class Circulo : Forma
    {
        double pi = 3.14;
        double raio = double.Parse(Console.ReadLine());
        public override double dimensoes()
        {
            return pi * (raio * raio);
        }
    }
}
