namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex4();
        }


        static void Ex4()
        {
            int vitorias = 0;

            string respostaFinal = "";

            int contJogador = 0;

            int contPc = 0;

            string[] opcoes = { "pedra", "papel", "tesoura" };

            Console.WriteLine("0-pedra 1-papel 2-tesoura");

            int rodadas = 0;

            while (respostaFinal != "s")
            {
                Console.WriteLine("Quantas jogadas vamos jogar?");

                int qtdVezes = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtdVezes; i++)
                {
                    Console.WriteLine("Sua escolha: 0 - Pedra 1 - Papel 2 - Tesoura");

                    int minhaEscolha = int.Parse(Console.ReadLine());

                    if (minhaEscolha == 0)

                    {
                        Console.WriteLine("Você escolheu pedra.");
                    }

                    else if (minhaEscolha == 1)
                    {

                        Console.WriteLine("Você escolheu papel.");

                    }

                    else if (minhaEscolha == 2)
                    {
                        Console.WriteLine("Você escolheu tesoura.");
                    }

                    else
                    {
                        Console.WriteLine("Escolha inexistente, tente novamente");
                    }


                    Console.WriteLine("\n");

                    Console.WriteLine("Escolha do Computador:");

                    Random escolhaPc = new Random();

                    int indice = escolhaPc.Next(opcoes.Length);

                    Console.WriteLine($"A escolha do computador foi:{indice}");

                    if (indice == 0)

                    {
                        Console.Write("pedra");
                    }

                    else if (indice == 1)
                    {
                        Console.Write("papel");

                    }

                    else if (indice == 2)
                    {
                        Console.Write("tesoura");
                    }

                    Console.WriteLine("\n");



                    if (minhaEscolha == 0 && indice == 0)
                    {

                        Console.WriteLine("Empate!");
                    }

                    if (minhaEscolha == 0 && indice == 1)
                    {
                        Console.WriteLine("Poxa... Você perdeu! :(");
                        contPc++;

                    }

                    else if (minhaEscolha == 0 && indice == 2)
                    {
                        Console.WriteLine("Poxa... Você perdeu! :(");
                        contPc++;
                    }

                    else if (minhaEscolha == 1 && indice == 0)
                    {

                        Console.WriteLine("Aeee, você ganhou! :D");
                        contJogador++;
                    }

                    else if (minhaEscolha == 1 && indice == 1)
                    {

                        Console.WriteLine("Empate!");

                    }

                    else if (minhaEscolha == 1 && indice == 2)
                    {
                        Console.WriteLine("Aeee, você ganhou! :D");
                        contJogador++;
                    }

                    else if (minhaEscolha == 2 && indice == 0)
                    {
                        Console.WriteLine("Poxa... Você perdeu! :(");
                        contPc++;
                    }

                    else if (minhaEscolha == 2 && indice == 1)

                    {
                        Console.WriteLine("Aeee, você ganhou! :D");
                        contJogador++;
                    }

                    else if (minhaEscolha == 2 && indice == 2)

                    {
                        Console.WriteLine("Empate!");
                    }

                }


                Console.WriteLine($"Seu total de vitórias:{contJogador}");

                Console.WriteLine($"Total de vitórias do computador:{contPc}");

                if (contPc > contJogador)
                {
                    Console.WriteLine("Computador venceu!");
                }

                else
                {
                    Console.WriteLine("Você venceu!");
                }


                Console.WriteLine("Deseja parar? (s-n)");
                respostaFinal = Console.ReadLine();
                rodadas++;

                if (respostaFinal == "s" || respostaFinal == "sim")
                {
                    Console.WriteLine($"Total de rodadas:{rodadas}");
                    break;

                }

            }

        }

    }
}