using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ExerciciosIntPOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            ex 01
            Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa.");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");

            Console.WriteLine("Dados da segunda pessoa.");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.nome);
            }
            
            ex 02
            Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários. 

            Funcionario a = new Funcionario();
            Funcionario b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.salario + b.salario) / 2;
            Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Produto p = new Produto();
            Console.WriteLine("Entre com os dados de um produto");
            
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dados do produto:" 
                +"\n--------------------------------------\n"
                +p+ "\n--------------------------------------\n");

            Console.Write("");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);
            Console.Write("Dados atualizados:"
                + "\n--------------------------------------\n"
                + p
                + "\n--------------------------------------\n");

            Console.Write("");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);
            Console.Write("Dados atualizados:"
                + "\n--------------------------------------\n"
                + p
                + "\n--------------------------------------\n");
            ex 01
            Fazer um programa para ler os valores da largura e altura
            de um retângulo. Em seguida, mostrar na tela o valor de
            sua área, perímetro e diagonal.

            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\n--------------------------------------\n");
            Console.WriteLine($"Área = {r.Area(r.Largura, r.Altura)}");
            Console.WriteLine($"Perímetro = {r.Perimetro(r.Largura, r.Altura)}");
            Console.WriteLine($"Diagonal = {r.Diagonal(r.Largura, r.Altura)}");
            
            ex 02
            Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em
            seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o
            salário do funcionário com base em uma porcentagem dada (somente o salário bruto é
            afetado pela porcentagem) e mostrar novamente os dados do funcionário.
             
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.SalarioLiquido();

            Console.WriteLine("\n--------------------------------------\n" +
                f+
                "\n--------------------------------------\n");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(aumento);

            Console.WriteLine("\n--------------------------------------\n" +
                f +
                "\n--------------------------------------\n");

             ex 03
            Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos).
            
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.CalcNotaFinal();

            Console.WriteLine("Nota final: " + a.NotaFinal.ToString("F2", CultureInfo.InvariantCulture));
            if (a.NotaFinal >= 60.00)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                double sobra = 60.00 - a.NotaFinal;
                Console.WriteLine("Reprovado.");
                Console.Write("Restam " + sobra.ToString("F2", CultureInfo.InvariantCulture)+ " pontos.");
            }
            
            ex 04
            Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
            uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
            que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
            para ser responsável pelos cálculos.
             
             */
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor = ConversorDeMoeda.ConveterDpR(cotacao, compra);

            Console.Write("Valor a pagar: " + valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
        
        //Pessoa ex 01
        /*
        public class Pessoa
        {
            public string nome;
            public int idade;
        }

        //funcionario ex 02
        public class Funcionario
        {
            public string nome;
            public double salario;
        }
        */
    }
}
