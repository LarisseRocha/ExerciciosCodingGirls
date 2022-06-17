
using mesadetrabalho;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a operação: 1- quadrado 2- triangulo 3- círculo");
        string res = Console.ReadLine();

        if(res == "1") {
            Console.WriteLine("Entre com o lado do quadrado:");
            var q = new Quadrado();
            q.dimensoes();
            Console.WriteLine($"Área do quadrado:{q.dimensoes()}");

        }

        else if (res == "2")
        {
            Console.WriteLine("Entre com a base e depois com a altura:");
            var t = new Triangulo();
            t.dimensoes();
            Console.WriteLine($"Área do trianguloo:{t.dimensoes()}");

        }


        else if (res == "3")
        {
            Console.WriteLine("Entre com o valor do raio:");
            var c = new Circulo();
            c.dimensoes();
            Console.WriteLine($"Área do círculo:{c.dimensoes()}");

        }

    }
}