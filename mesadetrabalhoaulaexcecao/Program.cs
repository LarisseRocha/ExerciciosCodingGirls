
namespace mesadetrabalhoexcecao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a operação: 1- soma 2- subtrai 3- divide 4- multiplica 5- zerar calculadora");
        string resposta = Console.ReadLine();
        Console.WriteLine("Informe o primeiro valor.");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor.");
        int num2 = int.Parse(Console.ReadLine());
        int res;

        if (resposta == "1")
        {

            res = num1 + num2;
            Console.WriteLine(res);
        }

        else if (resposta == "2")
        {

            res = num1 - num2;
            Console.WriteLine(res);
        }

        else if (resposta == "3")
        {
            
                
               
             try {

                    res = num1 / num2;
                    Console.WriteLine(res);

             } 
            catch{
                    Console.WriteLine("Não é possível efeturar a divisão por 0");

             }
            finally{

            }
            
        }

            else if (resposta == "4")
            {

                res = num1 * num2;
                Console.WriteLine(res);
            }


        }
    }
