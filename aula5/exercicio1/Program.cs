using exercicio1;
using System.Globalization;

namespace CalcImc
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total distribuido 30 pontos para cada prova, " +
                "40 de trabalho. Média para aprovação: 18 pontos\n");

            Aluno a = new Aluno();
            Console.WriteLine("Entre com seu numero de matrícula:");
            a.matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu nome:");
            a.nome = Console.ReadLine();

            Console.WriteLine("Entre com a nota da prova 1:");
            a.nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota da prova 2:");
            a.nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota do trabalho:");
            a.notaTrabalho = double.Parse(Console.ReadLine());

            if (a.calcularMedia() > 18)
            {
                Console.WriteLine($"Aluno aprovado com média: {a.calcularMedia()}");
            }
            else {
                
                Console.WriteLine($"Nota final do aluno:{a.calcularMedia()} e você precisa" +
                    $" tirar:{a.notaFinal()} para ser aprovado na prova final");
            }
           
        }

    }
       
} 

