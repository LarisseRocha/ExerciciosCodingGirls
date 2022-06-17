using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesadetrabalho
{
    class Triangulo : Forma { 

        double basee = double.Parse(Console.ReadLine());
        double altura = double.Parse(Console.ReadLine());
        double res;
        public override double dimensoes()
        {

            res = (basee * altura) / 2;
            return res ;
        } 
}
}
