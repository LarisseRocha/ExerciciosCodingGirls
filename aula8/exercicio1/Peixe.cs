using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Peixe : Animal
    {
        private string caracteristica;
        public Peixe(string caracteristica, string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia) : base(nome, numeroPatas, cor, ambiente, velocidadeMedia)
        {
            caracteristica = caracteristica;
        }

        public string Caracteristica { get; set; }

        public void imprimePeixe()
        {
            dados();
            Console.WriteLine($"característica do peixe:{caracteristica}");
        }
    }
}
