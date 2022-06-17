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
            c.num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número:");
            c.num2 = int.Parse(Console.ReadLine());

            if (res == "1")
            {
                c.multiplicacao();
                Console.WriteLine($"O resultado é:{c.multiplicacao()}");
                c.divisao();
            }

            else if (res == "2")
            {
                c.divisao();
                Console.WriteLine($"O resultado é:{c.divisao()}");
                c.divisao();
            }

            else if (res == "3")
            {
                c.subtracao();
                Console.WriteLine($"O resultado é:{c.subtracao}");
            }
        }
    }
}