using System;
using System.Globalization;

namespace ExerciciosVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ex 01
            Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
            pessoas.
            int x = int.Parse(Console.ReadLine());

            double[] vet = new double[x];

            for (int i = 0; i < x; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;
            for (int i = 0; i < x; i++)
            {
                soma += vet[i];
            }
            double media = soma / x;
            Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture));
            
            ex 02
            Fazer um programa para ler um número inteiro N e os dados (nome e
            preço) de N Produtos. Armazene os N produtos em um vetor. Em
            seguida, mostrar o preço médio dos produtos.

            Console.WriteLine("Digite quntos produtos você quer calcular a média: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome do produto {i}: ");
                string nome = Console.ReadLine();
                Console.Write("Valor: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto(nome, valor);
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("Média de todos valores: " + media.ToString("F2", CultureInfo.InvariantCulture));


            ex 03
            A dona de um pensionato possui dez quartos para alugar para estudantes,
            sendo esses quartos identificados pelos números 0 a 9.
            Quando um estudante deseja alugar um quarto, deve-se registrar o nome
            e email deste estudante.
            Fazer um programa que inicie com todos os dez quartos vazios, e depois
            leia uma quantidade N representando o número de estudantes que vão
            alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
            N estudantes. Para cada registro de aluguel, informar o nome e email do
            estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
            que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
            um relatório de todas ocupações do pensionato, por ordem de quarto,
            conforme exemplo.
             */
            Aluno[] alunos = new Aluno[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome :");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                alunos[quarto] = new Aluno(nome, email);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (alunos[i] != null)
                {
                    Console.WriteLine(i + ": " + alunos[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
