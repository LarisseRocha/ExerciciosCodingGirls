using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesadetrabalho
{
    class Quadrado : Forma
    {
        
        double lado = double.Parse(Console.ReadLine());
        
        public override double dimensoes ()
        {
            double res = lado * lado;
            return res;
             
            
        }
    }
}
