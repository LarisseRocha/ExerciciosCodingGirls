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

            string[] vetAux = new string[5];

            Console.WriteLine("Digite as palavras:\n");

            for (int i = 0; i < 5; i++)
            {
                palavras[i] = Console.ReadLine();
                ;
                Console.WriteLine("\n");

            }

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(palavras[i].Length);
                    }


            Console.ReadLine();
        }

    }
}

