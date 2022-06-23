namespace exercicio4
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Random escolheNum = new Random();

            int num = escolheNum.Next();

            Console.WriteLine($"A escolha do computador foi:{num}");


        }
    }

}