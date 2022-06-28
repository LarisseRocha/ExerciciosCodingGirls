using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Mamifero : Animal
    {
        public string alimento;

        public Mamifero(string alimento, string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia) : base(nome, numeroPatas, cor, ambiente, velocidadeMedia)
        {
            alimento = alimento;
        }

        public string Alimento { get; set; }

        public void imprimeMamifero()
        {
            dados();
            Console.WriteLine($"Alimento do mamífero: {alimento}");
        }
    }
}
