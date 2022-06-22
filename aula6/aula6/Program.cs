namespace Empregado
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado e = new Empregado("mnn", ",nnk", 10000);

            e.aumentoDeSalario(8868687);

            Console.WriteLine("Informe o nome:");
            e.nome = Console.ReadLine();
           
            Console.WriteLine("Informe o cargo");
            e.cargo = Console.ReadLine();

            Console.WriteLine("Informe o salario");
            e.salario = double.Parse(Console.ReadLine());

            if(e.salario < 0)
            {
                e.salarioNegativo();
            }
            else if(e.salario > 0)
            {
                e.imprimirSalario();
            }

            
      
        }
    } 
    
 }