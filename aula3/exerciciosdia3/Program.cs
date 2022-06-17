using System;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Descomente para chamar a função

            //ex1();
            //ex2();
            //ex3();
            //ex4();
            ex5();
         
        }

        /*Leia um valor de ponto flutuante com duas casas decimais. 
            * Este valor representa um valor monetário. A seguir, calcule o
            * menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
            * As notas consideradas são de 100, 50, 20, 10, 5, 2.*/

        static void ex1()
        {
            Console.WriteLine("Informe o valor");
            double valor = int.Parse(Console.ReadLine());

            int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0;
            
            
                if (valor % 100 == 1)
                {
                    nota100++;
                    Console.WriteLine();
                }

                if (valor % 20 == 1)
                {
                    nota50++;
                }

                if (valor % 10 == 1)
                {
                    nota10++;
                }

                if (valor % 5 == 1)
                {
                    nota5++;
                }

                if (valor % 2 == 1)
                {
                    nota2++;
                }
        }

        /*2. Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da
         * mensagem “x é o maior”.*/
        static void ex2()
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor:");
            int valor3 = int.Parse(Console.ReadLine());

            if ((valor1 > valor2) && (valor1 > valor3)) 
            {
                Console.WriteLine("O primeiro valor é o maior!");
            }

            else if ((valor2 > valor1) && (valor2 > valor3))
            {
                Console.WriteLine("O segundo valor  é o maior!");
            }

            else if ((valor3 > valor1) && (valor3 > valor2))
            {
                Console.WriteLine("O terceiro valor é o maior!");
            }
        }

        /*
            3.Leia 3 valores que são as três notas de um aluno.
        A seguir, calcule a média do aluno. Considere que cada nota
        pode ir de 0 até 10.0, sempre com uma casa decimal. Imprima se o aluno foi 
        aprovado ou reprovado considerando a média 7.
         */

        static void ex3()
        {
            Console.WriteLine("Informe os valores: ");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());

            int nota = (valor1 + valor2 + valor3) / 3;

            if (nota < 7)
            {
                Console.WriteLine("Aluno reprovado!");
            }else
            {
                Console.WriteLine("Aluno aprovado");
            }


        }

        /*4.Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
        Se a nota for menor que 6.0, deve exibir a nota F.
        Se a nota for de 6.0 até 7.0, deve exibir a nota D.
        Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
        Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
        Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
        Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns para aprovação ou algo mais complexo.
        Exemplo de Entrada 10 8 9
        Exemplo de Saída O aluno tirou A. Parabéns!*/

        static void ex4()
        {
            Console.WriteLine("Informe os valores: ");
            double valor1 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());


            double nota = (valor1 + valor2 + valor3) / 3;

            if (nota < 6)
            {
                Console.WriteLine("Precisamos estudar um pouco mais. Nota F");
            }
            else if (nota >= 6 && nota <= 7)
            {
                Console.WriteLine("Bora estudar um pouco mais. Nota D");
            }
            else if (nota >= 7 && nota <= 8)
            {
                Console.WriteLine("Não tá ruim.. mas pode melhorar. Nota C");
            }
            else if (nota >= 8 && nota <= 9)
            {
                Console.WriteLine("Muito bom. Nota B");
            }
            else if (nota >= 9 && nota <= 10)
            {
                Console.WriteLine("Fantástico! Nota A");
            }
        }
            /*5. A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00 
            ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4% Leia o salário do funcionário e
            calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
            Exemplo de Entrada 400.00 Exemplo de Saída Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %
            Estes exercícios foram retirados e adaptados da maior plataforma de maratona de programação beecrowd. Lá você encontra mais exercícios de lógica de programação para praticar!
            Bons Estudos!*/

            static void ex5()
            {

            Console.WriteLine("Informe o salário do funcionário:");
            double salario = double.Parse(Console.ReadLine());
            double reajuste;
            double salFinal;

            if ((salario > 0) && (salario <= 400))
            {
                reajuste = (salario * 15) / 100;
                salFinal = salario + reajuste;
                Console.WriteLine();
                
                Console.WriteLine($"O novo salário é de:{salFinal:00.00}, com reajuste de: {reajuste:00.00} e aumento de: 15%");
            }

            else if ((salario >= 401) && (salario <= 800))
            {
                reajuste = (salario * 12) / 100;
                salFinal = salario + reajuste;
                Console.WriteLine();

                Console.WriteLine($"O novo salário é de:{salFinal:00.00}, com reajuste de: {reajuste:00.00} e aumento de: 12%");
            }

            else if ((salario > 800.01) && (salario < 1200))
            {
                reajuste = (salario * 10) / 100;
                salFinal = salario + reajuste;
                Console.WriteLine();

                Console.WriteLine($"O novo salário é de:{salFinal:00.00}, com reajuste de: {reajuste:00.00} e aumento de: 10%");
            }


            else if ((salario > 1200.01) && (salario < 2000))
            {
                reajuste = (salario * 7) / 100;
                salFinal = salario + reajuste;
                Console.WriteLine();

                Console.WriteLine($"O novo salário é de:{salFinal:00.00}, com reajuste de: {reajuste:00.00} e aumento de: 7%");
            }


            else if ((salario > 2000))
            {
                reajuste = (salario * 4) / 100;
                salFinal = salario + reajuste;
                Console.WriteLine();

                Console.WriteLine($"O novo salário é de:{salFinal:00.00}, com reajuste de: {reajuste:00.00} e aumento de: 4%");
            }

        }

        
    }
}