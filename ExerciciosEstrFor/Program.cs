using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEstrFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ex 01
           
            Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, 
            um valor por linha, inclusive o X, se for o caso.
            Console.Write("Entre com um valor: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= x; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine("-- {0} --", i);
                }
            }

            ex 02
            Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            

            Console.Write("Digite a quantidade de valores: ");
            int n = int.Parse(Console.ReadLine());
            int c_in = 0,
                c_out = 0;
            
            for(int i = 0; i <= n-1; i++)
            {
                int entrada = int.Parse(Console.ReadLine());
                if (entrada >= 10 && entrada <= 20)
                {
                    c_in++;
                }
                else
                {
                    c_out++;
                }
            }
            Console.Write($"{c_in} in\n{c_out} out");
            
             ex 03
            Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
            Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
            Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que 
            o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
             
            int[] resultado = { };
            Console.Write("Insira a quantia que você quer repetir: ");
            int testes = int.Parse(Console.ReadLine());
            for (int i = 0; i < testes - 1; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                resultado[i] = int.Parse(vet[i]);
                Console.WriteLine(resultado[i]);
            } -->Continuar


             */
            Console.ReadLine();

        }
    }
}
