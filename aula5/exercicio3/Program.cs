using exercicio3;
using System.Globalization;

namespace CalcImc
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            Console.WriteLine("Escolha o que deseja fazer 1- Multiplicar 2- Dividr 3-Subtrair");
            string res = Console.ReadLine();

            Console.WriteLine("Entre com o primeiro número:");
            c.num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número:");
            c.num2 = double.Parse(Console.ReadLine());

            switch (res)
            {
                case "1":
                    c.multiplicacao();
                    Console.WriteLine($"O resultado é:{c.multiplicacao()}");
                    break;

                case "2":
                    c.divisao();
                    Console.WriteLine($"O resultado é:{c.divisao()}");
                    break;

                case "3":

                    c.subtracao();
                    Console.WriteLine($"O resultado é:{c.subtracao}");
                    break;

                default:
                    Console.WriteLine("Opcão inválida");
                    break;

            }
           
        }
    }
}