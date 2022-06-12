namespace exercicios3
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

            int maior = 0;

            int contMaior = 0;

            
            Console.WriteLine("Digite as palavras:\n");

            for (int i = 0; i < 5; i++)
            {
                palavras[i] = Console.ReadLine();


            }

            Console.WriteLine("Vetor ordenado:\n");

            for (int i=0; i<5; i++)
            {
                Console.WriteLine(vetAux[i]);

            }            

            Console.ReadLine();
        }
    }
}