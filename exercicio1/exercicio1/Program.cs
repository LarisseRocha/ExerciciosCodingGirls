using System;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Exercicíos do primeiro dia de aula==============");

            Console.WriteLine("\n");

            // Elabore um programa que escreve seu nome completo,
            // seu endereço, o CEP e telefone em linhas separadas.
            Console.WriteLine("-----Exercício 1-------");

            string nome = "Larisse Batista de Melo";
            Console.WriteLine(nome);

            
            string endereco = "Avenida Santos Dumont 165";
            Console.WriteLine(endereco);

            string cep = "987000";
            Console.WriteLine(cep);

            string tel = "901100001188";
            Console.WriteLine(tel);
           

            Console.WriteLine("\n");



            //Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome,
            //sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.

            Console.WriteLine("-----Exercício 2------");

            string cientista = "Ada Lovelace";
            Console.WriteLine(cientista);

            string formacao = "Matemática";
            Console.WriteLine(formacao);

            string contribuicao = "Desenvolveu o primeiro algoritmo da história capaz de ser processado por uma máquina";
            Console.WriteLine(contribuicao);

      
            Console.WriteLine("\n");

            //Elabore um programa que mostre na tela uma letra de música que você gosta,
            //o compositor e o gênero musical em linhas separadas.

            Console.WriteLine("-----Exercicio 3------");

            Console.WriteLine("Mergulho no mar pra lavar a alma \n" +
                            "Frescor vem trazendo a calma \n" +
                            "Amanhecendo o dia\n" +
                            " Sinto os pés sobre búzios e conchas \n" +
                            "Corais refletidos em ondas \n" +
                            "Uma nova brisa \n" +
                            "Ando pensando em você \n" +
                            "Sonho alto ao noite e dia \n" +
                            "Para pra ver pode dar muito certo, oh - oh \n" +
                            "Eh, é só querer");

            string compositor = "Gabriela Melim";
            Console.WriteLine(compositor);

            string genero = "pop";
            Console.WriteLine(genero);


            //Elabore um programa que exibe uma mensagem que incentive outras mulheres
            //a entrar na tecnologia.
            Console.WriteLine("\n");
            Console.WriteLine("-----Exercício 4------");

            string poder = "Densenvolver";
            Console.WriteLine($"Todas nós podemos {poder}");




        }

    }
}
