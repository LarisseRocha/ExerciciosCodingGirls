namespace Empregado
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado e = new Empregado();
            Console.WriteLine($"O seu novo salário é:{e.aumentoDeSalario(e.salario)}");
            
      
        }
    } 
    
 }