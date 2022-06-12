using System;

namespace exercicios2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // descomente para executar cada
            
            //ex1();
           // ex2();
           // ex3();
          //  ex4();
          //  ex5();


            //1. Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade

            //2. Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.

            /*3. Escreva um programa que leia o número de horas trabalhadas e um funcionário,
             o valor que recebe por hora e calcula o salário desse funcionário.
             A seguir, mostre o número e o salário do funcionário, com duas casas decimais.*/

            /*4. Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
            Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos 
            de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
            Este é apenas um exercício com objetivo de testar raciocínio matemático simples.*/

            /*5. Construa um conversor de moedas:
            Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
            DOLAR, EURO, LIBRA ESTERLINA, DÓLAR CANADENSE, PESO ARGENTINO, PESO CHILENO
            Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real. Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real.
            Estes exercícios foram retirados da maior plataforma de maratona de programação beecrowd. Lá você encontra mais exercícios de lógica de programação para praticar!*/
        }


        static void ex1()
        {
            
            Console.WriteLine("Digite seu ano de nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());
            int anoAtual = 2022;
            Console.WriteLine($"Sua idade é: {anoAtual - anoNasc}");
        }

       
        static void ex2()
        {
            Console.WriteLine("Digite os números: ");

            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int num3 = int.Parse(Console.ReadLine());

            int num4 = int.Parse(Console.ReadLine());

            int num5 = int.Parse(Console.ReadLine());

            int num6 = int.Parse(Console.ReadLine());

            int num7 = int.Parse(Console.ReadLine());

            int num8 = int.Parse(Console.ReadLine());

            int num9 = int.Parse(Console.ReadLine());

            int num10 = int.Parse(Console.ReadLine());



            Console.WriteLine($"A soma dos 10 números é igual a: {num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10}");


        }

       

        static void ex3()
        {
            Console.WriteLine("Informe o número de horas trabalhadas: ");
            int horasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da hora trabalhada: ");
            float valorHora = float.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário trabalhou {horasTrab} e seu salário foi de {horasTrab * valorHora:00.00}");
        }

        static void ex4()
        {
            Console.WriteLine("Informe quantos anos você tem:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sua idade em anos são: {idade} anos, em meses são: {idade * 12} meses e em dias são: {idade * 365}");
        }

        static void ex5()
        {
            Console.WriteLine("Entre com o valor em reais: ");
            double real = double.Parse(Console.ReadLine());

            double dolar = real / 4.87;
            double euro = real / 5.21;
            double libra = 6.13;
            double dolarCan = real / 3.89;
            double pesoArg = real / 0.040;
            double pesoChil = real / 0.0059;

            Console.WriteLine($"Dolar: {dolar:00.00}\n Euro: {euro:00.00} \n Libra: {libra:00.00}\n " +
                $"Dolar Canadense: {dolarCan:00.00}\n Peso Argentino:{pesoArg:00.00}\n Peso Chileno: {pesoChil:00.00}");
        }
       


    }
}