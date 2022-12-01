using System;
using System.Globalization;

namespace ExerciciosEstrCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ex 01
            Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("POSITIVO");
            }else
            {
                Console.WriteLine("NEGATIVO");
            }

            ex 02
            Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0)
            {
                Console.WriteLine("Par");
            }else
            {
                Console.WriteLine("Ímpar!");
            }

            ex 03
            Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 
            "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. 
            Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
            
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São multiplos!");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }

            ex 04
            Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
            sabendo que o mesmo podecomeçar em um dia e terminar em outro, tendo uma duração mínima 
            de 1 hora e máxima de 24 horas.
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int res = 0;
            
            if (A > B )
            {
                res = 24 - (A - B);
            }else if (B > A)
            {
                res =  24 - (B - A);
            }
            Console.WriteLine("O jogo durou {0} horas", res);
            
            ex 05
            Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
            A seguir, calcule e mostre o valor da conta a pagar.

            int hotDog = 1;
            int xSalada = 2;
            int xBacon = 3;
            int tSimples = 4;
            int refri = 5;

            double pHotDog = 4.00,
                pXSalada = 4.50,
                pXBacon = 5.00,
                pTSimples = 2.00,
                pRefri = 1.50;

            double total = 0;

            string[] vet = Console.ReadLine().Split(' ');
            int escolha1 = int.Parse(vet[0]);
            int escolha2 = int.Parse(vet[1]);

            if (escolha1 == hotDog)
            {
                total = pHotDog * escolha2;
            }
            else if (escolha1 == xSalada)
            {
                total = pXSalada * escolha2;
            }
            else if (escolha1 == xBacon)
            {
                total = pXBacon * escolha2;
            }
            else if (escolha1 == tSimples)
            {
                total = pTSimples * escolha2;
            }
            else if (escolha1 == refri)
            {
                total = pRefri * escolha2;
            }

            Console.WriteLine("Total: R$ {0:F2}", total);

            ex 06
            Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo
            em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se 
            encontra. Obviamente se o valor não estiver emnenhum destes intervalos, deverá ser 
            impressa a mensagem “Fora de intervalo”.

            Console.Write("Digite um valor: ");
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (d > 0.0 && d <= 25.0)
            {
                Console.WriteLine("Intervalo: [0,25]");
            }
            else if (d <= 50.0)
            {
                Console.WriteLine("Intervalo: [25,50]");
            }
            else if (d <= 75.0)
            {
                Console.WriteLine("Intervalo: [50,75]");
            }
            else if (d <= 100.0)
            {
                Console.WriteLine("Intervalo: [75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
            Console.ReadLine();
            
            ex 07
            Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
            de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
            Se o ponto estiver na origem, escreva a mensagem “Origem”.
            Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            situação. 
             

            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }

            ex 08

            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. 
            Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda
            
            Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, 
            pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. 
            No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, 
            o que resulta em R$ 80.36 no total. O valor deve ser impresso com
            duas casas decimais.
             */
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxa;
            if (salario <= 2000.0)
            {
                taxa = 0.0;
            }
            else if (salario <= 3000.0)
            {
                taxa = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                taxa = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                taxa = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (taxa == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + taxa.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
