namespace exercicios4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();

        }


        static void Ex1()
        {

            Console.WriteLine("Digite os 10 números:");
            int[] numeros = new int[10];
            int[] vetNum = new int[10];
            for (int i = 0; i < 10; i++)
            {

                numeros[i] = int.Parse(Console.ReadLine());
                vetNum[i] = numeros[i] * 5;

            }
            Console.WriteLine("\n");
            Console.WriteLine("A multiplicação dos números é igual a:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetNum[i]);

            }

            Console.ReadLine();
        }

    }
}

