namespace exercicios4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex2();

        }


        static void Ex2()
        {
            int[] numeros = new int[10];

            int[] vetPar = new int[10];

            int[] vetImpar = new int[10];

            int contPar = 0;

            int contImpar = 0;

            Console.WriteLine("Digite os números: ");

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    vetPar[contPar] = numeros[i];
                    contPar++;

                }

                else
                {
                    vetImpar[contImpar] = numeros[i];
                    contImpar++;

                }
            }

            Console.WriteLine("Números pares:\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{vetPar[i]}-");

            }

            Console.WriteLine();

            Console.WriteLine("Números ímpares:\n");
            for (int i = 0; i < 5; i++)
            {

                Console.Write($"{vetImpar[i]}-");
            }

            Console.ReadLine();
        }
    }

}
