namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex5();
        }

        static void Ex5()
        {
            string[,] tabuleiro = new string[3, 3];

            string jogadorA;

            string jogadorB;


            Console.WriteLine("JogadorA = X e JogadorB = O");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.WriteLine(" A [0, 0] B [0, 1] C [0, 2] \n D [1, 0] E [1, 1] F [1, 2] \n G [2, 0] H [2, 1] I [2, 2]");
                    Console.WriteLine("Escolha a letra correspondente ao campo que deseja marcar.");
                    jogadorA = Console.ReadLine();

                    Console.WriteLine("Escolha a letra correspondente ao campo que deseja marcar.");
                    jogadorB = Console.ReadLine();

                    if (jogadorA == "A")
                    {
                        tabuleiro[0, 0] = "X";
                    }

                    else if (jogadorB == "A") {

                        tabuleiro[0, 0] = "O";
                    }

                    if(jogadorA == "B")
                    {
                        tabuleiro[0, 1] = "X";
                    }

                    else if (jogadorB == "B")
                    {
                        tabuleiro[0, 1] = "O";
                    }

                    if (jogadorA == "C")
                    {
                        tabuleiro[0, 2] = "X";
                    }

                    else if (jogadorB == "C")
                    {
                        tabuleiro[0, 2] = "O";
                    }

                    if (jogadorA == "D")
                    {
                        tabuleiro[1, 0] = "X";
                    }

                    else if (jogadorB == "D")
                    {
                        tabuleiro[1, 0] = "O";
                    }

                    if (jogadorA == "E")
                    {
                        tabuleiro[1, 1] = "X";
                    }

                    else if (jogadorB == "E")
                    {
                        tabuleiro[1, 1] = "O";
                    }

                    if (jogadorA == "F")
                    {
                        tabuleiro[1, 2] = "X";
                    }

                    else if (jogadorB == "F")
                    {
                        tabuleiro[1, 2] = "O";
                    }

                    if (jogadorA == "G")
                    {
                        tabuleiro[2, 0] = "X";
                    }

                    else if (jogadorB == "G")
                    {
                        tabuleiro[2, 0] = "O";
                    }

                    if (jogadorA == "H")
                    {
                        tabuleiro[2, 1] = "X";
                    }

                    else if (jogadorB == "H")
                    {
                        tabuleiro[2, 1] = "O";
                    }

                    if (jogadorA == "I")
                    {
                        tabuleiro[2, 2] = "X";
                    }

                    else if (jogadorB == "B")
                    {
                        tabuleiro[2, 2] = "O";
                    }


                }

            }

            Console.WriteLine("\n");
            Console.WriteLine("tabuleiro \n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[" + tabuleiro[i,j]+"]");

                }

                Console.WriteLine("\n");

            }
        }
    }
}