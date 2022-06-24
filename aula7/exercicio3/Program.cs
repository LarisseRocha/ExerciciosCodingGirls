
namespace exercicio3
{

    internal class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria cb = new ContaBancaria(0, "");



            int verificar;
            do
            {
                Console.WriteLine("escolha a ação que deseja realizar:");
                string res = Console.ReadLine();
                switch (res)
                {
                    case "1":
                        Console.WriteLine("Alterar nome");
                        cb.alteraNome("");
                        break;

                    case "2":
                        Console.WriteLine("---realizar depósito--- \n");

                        Console.WriteLine("informe o número da conta:");
                        cb.NumeroConta = int.Parse(Console.ReadLine());

                        Console.WriteLine("informe o nome do cliente:");
                        cb.NomeCliente = Console.ReadLine();

                        Console.WriteLine("valor do depósito:");
                        cb.deposito();

                        Console.WriteLine($"você efetuou um depósito de" +
                            $"{cb.deposito()} e seu saldo atual é de: {cb.Saldo}");
                        break;

                    case "3":
                        Console.WriteLine("---Operação: realizar saque--- \n");

                        Console.WriteLine("informe o número da conta:");
                        cb.NumeroConta = int.Parse(Console.ReadLine());

                        Console.WriteLine("informe o nome do cliente:");
                        cb.NomeCliente = (Console.ReadLine());

                        Console.WriteLine("relizar saque");
                        cb.saque();

                        Console.WriteLine($"você efetuou um saque de:{cb.saque()} e de:" +
                            $" seu saldo atual é de:{cb.Saldo}");
                        break;

                    default:
                        Console.WriteLine("valor inválido");
                        break;


                }

                Console.WriteLine("Realizar outra operação? Clique para 0- Não 1- Sim");
                verificar = int.Parse(Console.ReadLine());

            } while (verificar != 0);

        }
    }

}
