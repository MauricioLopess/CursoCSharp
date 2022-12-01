using System;
using System.Globalization;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace ExerciciosEstrSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ex 01
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses 
            números com uma mensagem explicativa, conforme exemplos.
            
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine("SOMA = {0}", soma);

            ex 02
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área
            deste círculo com quatro casas decimais conforme exemplos
           

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture)); 
            
            ex 03 
            Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a 
            diferença do produtode A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int dif = (A * B - C * D);

            Console.WriteLine("DIFERENÇA = " + dif);

            ex 04
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor 
            que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o 
            salário do funcionário, com duas casas decimais

            int numFuncionario = int.Parse(Console.ReadLine());
            int horaTrabalho = int.Parse(Console.ReadLine());
            double valorTrabalho = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horaTrabalho * valorTrabalho;

            Console.WriteLine("Number: " + numFuncionario);
            Console.WriteLine("Salary: "+ salario.ToString("F2", CultureInfo.InvariantCulture));
            
            ex 05
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário 
            de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de 
            cada peça 2. Calcule e mostre o valor a ser pago
             
          
            int codPeca1, numPeca1;
            int codPeca2, numPeca2;
            double pagamento, valUnitPeca1, valUnitPeca2;

            string[] vet1 = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(vet1[0]);
            numPeca1 = int.Parse(vet1[1]);
            valUnitPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 =Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(vet2[0]);
            numPeca2 = int.Parse(vet2[1]);
            valUnitPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            pagamento = (valUnitPeca1*numPeca1) + (valUnitPeca2*numPeca2);

            Console.WriteLine("Valor a pagar: R$ " + pagamento.ToString("F2", CultureInfo.InvariantCulture));
            
            ex 06
            Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
            Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.
 
            */
            double A, B, C;
            double areaTriangulo,
                areaCirculo,
                areaTrapezio,
                areaQuadrado,
                areaRetangulo;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTriangulo = (A * C) / 2;
            areaCirculo = 3.14159 * (Math.Pow(C, 2.0));
            areaTrapezio = ((A + B) * C) / 2;
            areaQuadrado = Math.Pow(B, 2.0);
            areaRetangulo = A * B;

            Console.WriteLine("Triângulo: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
