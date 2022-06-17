using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{

    public class Aluno
    {
        
        public int matricula;

        public string nome = "";

        public double nota1;

        public double nota2;

        public double notaTrabalho;

        public double calcularMedia()
        {
            double media = (nota1 + nota2 + notaTrabalho) / 3;
            return media;
        }

        public double notaFinal()
         {
            double resultadoFinal ;
            resultadoFinal = 18 - calcularMedia();

        
            return resultadoFinal;
        } 
    }
}
