using System.Globalization;

namespace CalcImc
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a altura");
            double alturaDoUsuario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o peso");
            double pesoDoUsuario = double.Parse(Console.ReadLine());

            string retorno = retornarDiagnosticoDoUsuario(alturaDoUsuario, pesoDoUsuario);

            Console.WriteLine($"Seu diagnóstico é {retorno}");


        }
        static string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
        {

            double imc = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);

            string resultado = "";


            if (imc < 18.5)
            {

                resultado = $"anêmico e seu imc é:{imc}";

            }

            else if (imc > 18.5 && imc < 24.9)
            {
                resultado = $"normal e seu imc é:{imc}";
            }

            else if (imc > 25 && imc < 29.9)
            {
                resultado = $"sobrepeso e seu imc é{imc}";
            }

            else if (imc > 30)
            {
                resultado = $"obesidade e seu imc é{imc}";
            }

            else if (imc > 40)
            {
                resultado = $"grave e seu imc é{imc}";
            }

            else
            {
                resultado = $"Entre com um valor válido.";
            }


            return resultado;


        }

    }
}