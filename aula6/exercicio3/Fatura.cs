using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
     class Fatura
    {
        public int numero;
        public string descricao;
        public int quantidade;
        public double preco;


        public Fatura(int numero, string descricao, int quantidade, double preco)
        {
            numero = numero;
            descricao = descricao;
            quantidade = 0;
            preco = 0;
        }

        public int Numero { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public double calcularFatura(double preco, double quantidade)
        {
            double valorFinal = 0;
            return valorFinal;

            valorFinal = preco * quantidade;

            return valorFinal;


        }

    }
}
