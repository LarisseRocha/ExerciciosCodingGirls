namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ex3();
        }


        static void Ex3()
        {
            string[] palavras = new string[5];

            string[] vetAux = { "1", "22", "333", "4444", "55555" };

            Console.WriteLine("Digite as palavras:\n");

            for (int i = 0; i < 5; i++)
            {
                palavras[i] = Console.ReadLine();


            }


            Console.ReadLine();
        }

    }
}

