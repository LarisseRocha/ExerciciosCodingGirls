
namespace Empregado
{

   
    public class Empregado
    {
        public string nome;

        public string cargo;

        public double salario;

        public Empregado(string nome, string cargo, double salario)
        {
            nome = nome;
            cargo = cargo;
            salario = 0;            
           
        }

        public void salarioNegativo()
        {
            if(salario < 0)
            {
               Console.WriteLine($"Seu salário é de:{salario = 0.0}");
            }
            else
            {
                imprimirSalario();
            }
            
        }

       public double aumentoDeSalario(double salario)
        {
           

            double salarioAumento = 0;
           
            if (salario >=  0 && salario < 400.00)
            {
                salarioAumento = (salario * 0.15) + salario;
            }

            else if(salario >=400.01 && salario < 800.00)
            {

                salarioAumento = (salario * 0.12) + salario;
            }

            else if (salario >= 800.01 && salario <= 1200)
            {
                salarioAumento = (salario * 0.10) + salario;
            }

            else if (salario >= 1200.01 && salario < 2000)
            {
                salarioAumento = (salario * 0.07) + salario;
            }

            else if (salario >= 2000)
            {
                salarioAumento = (salario * 0.04) + salario;
            }

            else
            {
                Console.WriteLine("Valor inválido!");
            }

            return salarioAumento;
      }

       public void imprimirSalario()
        {
            Console.WriteLine($"Salario do funcionário {aumentoDeSalario(salario)}");         


        }
    }
}
