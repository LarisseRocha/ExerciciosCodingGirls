using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Aluno
    {
        private string nome;
        private double nota;
        private string frequencia;

        public string Nome
        {
            get { return nome; }
            set { nome = Console.ReadLine();}
        }

        public double Nota
        {
            get { return nota; }
            set { nota = double.Parse(Console.ReadLine());}
        }

        public string Frequencia
        {
            get { return frequencia; }
            set { frequencia = Console.ReadLine(); }
        }

        public Aluno(string nome, double nota, string frequencia)
        {
            nome = nome;
            nota = 0;
            frequencia = frequencia;

        }


    }
}
