using exercicio3;

namespace exercicio4
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Fatura f = new Fatura(1, "nomm", 12, 90.0);

            Console.WriteLine("Informe o número do produto:");
            f.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a descrição do produto:");
            f.descricao = Console.ReadLine();

            Console.WriteLine("Informe a quantidade comprada deste produto:");
            f.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço deste produto:");
            f.preco = double.Parse(Console.ReadLine());

            f.calcularFatura(f.preco, f.quantidade);

            Console.WriteLine($"O número do produto é {f.numero}, a descricao é {f.descricao}" +
                $" a quantidade comprada deste produto foi de {f.quantidade} e o preço unitário" +
                $"é {f.preco}");

            Console.WriteLine($"O valor total da sua fatura é de: " +
                $"{f.calcularFatura(f.preco, f.quantidade)}");
        }
    }

}