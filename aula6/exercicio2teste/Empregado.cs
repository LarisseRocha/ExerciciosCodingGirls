
namespace exercicio2teste
{


    public class Empregado
    {
        public string nome;

        public string cargo;

        public double salario;

        public Empregado()
        {
            nome = "";
            cargo = "";
            salario = 0;


        }


        private double aumentoDeSalario(double salario)
        {
            Console.WriteLine("Informe o salario");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o cargo");
            cargo = Console.ReadLine();

            double salarioAumento = 0;

            if (salario < 0)
            {
                salarioAumento = 0.0;

            }

            else if (salario >= 0 && salario < 400.00)
            {
                salarioAumento = (salario * 0.15) + salario;
            }

            else if (salario >= 400.01 && salario < 800.00)
            {

                salarioAumento = (salario * 0.12) + salario;
            }

            else if (salario >= 800.01 && salario < 1200)
            {
                salarioAumento = (salario * 0.10) + salario;
            }

            else if (salario >= 1200.01 && salario < 2000)
            {
                salarioAumento = (salario * 0.07) + salario;
            }

            else if (salario > 2000)
            {
                salarioAumento = (salario * 0.04) + salario;
            }

            else
            {
                Console.WriteLine("Valor inválido!");

            }

            return salarioAumento;
        }
    }
}
