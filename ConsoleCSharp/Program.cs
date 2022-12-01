using System;
using System.Globalization;

namespace consoleAppTeste
{
    internal class Program
    {
        enum OrderStatus { PendingPayment, Processing, Shipped, Delivered , Received }
        static void Main(string[] args)
        {
            /*
             string palavras = Console.ReadLine();
             string[] vetor = palavras.Split(' ');
             for (int i = 0; i <= vetor.Length-1; i++)
             {
                 Console.WriteLine(vetor[i]);
             }

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            byte quantQuartos = byte.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura(na mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultNome = vetor[0];
            byte idade = byte.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quantQuartos);
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */
            int x = int.Parse(Console.ReadLine());
            
            Console.ReadLine();
        }
    }
}
