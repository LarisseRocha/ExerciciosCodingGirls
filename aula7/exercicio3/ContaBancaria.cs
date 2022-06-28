using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio3
{
    class ContaBancaria
    {
        private int numeroConta;

        private string nomeCliente;

        private double saldo;


        public ContaBancaria(int numeroConta, string nomeCliente)
        {
            numeroConta = numeroConta;
            nomeCliente = "";
            saldo = 0;
        }

        public int NumeroConta {
          
            get { return numeroConta; }
            set
            {

            }
            
        }

        public string NomeCliente {

            get { return nomeCliente; }

            set { 
                  nomeCliente = nomeCliente; 
                }
        }

        public double Saldo {

            get { return saldo; }

            set
            {
                saldo = 100.00;
            }
        }

       public string alteraNome(string nomeCliente)
        {
            string altera = Console.ReadLine();
            return altera;
        }

       public double deposito()
        {
            double depositoValor = 0;            
           
            depositoValor = double.Parse(Console.ReadLine());
            saldo = saldo + depositoValor;

            return saldo;
        }


        public double saque()
        {
            
            Console.WriteLine("Valor do saque:");
            double valor = double.Parse(Console.ReadLine());

            if (saldo > 0 && valor < saldo) {

                saldo = saldo - valor;
            }
            else
            {
                Console.WriteLine("Não é possível realizar o saque, você" +
                    "não tem saldo suficiente!");
            }
         
            return saldo;
        }
    }
}
