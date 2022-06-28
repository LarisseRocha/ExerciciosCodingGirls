using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Animal
    {
        protected string nome;
        protected int numeroPatas;
        protected string cor;
        protected string ambiente;
        protected double velocidadeMedia;

        public Animal()
        {
        }

        public Animal(string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia)
        {
            nome = nome;
            numeroPatas = numeroPatas;
            cor = cor;
            ambiente = ambiente;
            velocidadeMedia = 0;
        }

        public string Nome { get; set; }
        public int NumeroPatas { get; set; }
        public string Cor { get; set; }
        public string Ambiente { get; set; }
        public double VelocidadeMedia { get; set; }


        public void dados()
        {
            Console.WriteLine($" O nome do animal é:{nome}");
            Console.WriteLine($"Este animal possui:{numeroPatas}");
            Console.WriteLine($" A cor desse anmal é:{cor}");
            Console.WriteLine($" O ambiente em que este animal vive é:{ambiente}");
            Console.WriteLine($"A velocidade média deste animal é:{velocidadeMedia}");


        }
    }
}
