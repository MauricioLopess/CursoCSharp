using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEstrWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ex 01
            Escreva um programa que repita a leitura de uma senha até que ela seja válida. 
            Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
            Quando a senha for informada corretamente deve ser impressa a mensagem 
            "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            int x = 0;
            while (x != 2002)
            {
                Console.Write("Insira a senha: ");
                x = int.Parse(Console.ReadLine());
                if (x != 2002)
                {
                    Console.WriteLine("Senha inválida");
                }else
                {
                    Console.WriteLine("Acesso permitido");
                }
            }

            ex 02
            Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            string[] vet;
            int x = 1, y = 1;

            while (x != 0 || y != 0)
            {
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");
                }
            }
            Console.WriteLine("Nulo");
            
            ex 03
            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.
 
            */
            int tAlcool = 0,
                tGasolina = 0,
                tDiesel = 0,
                entrada = 0;

            while (entrada != 4)
            {

                Console.Write("Entre com um valor de 0 a 4:");
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 1)
                {
                    tAlcool++;
                }
                else if (entrada == 2)
                {
                    tGasolina++;
                }
                else if (entrada == 3)
                {
                    tDiesel++;
                }
                else if (entrada == 4)
                {
                    Console.WriteLine("Fim do programa.\n");
                }
                else
                {
                    Console.WriteLine("Informe um valor correto\n");
                }
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: {0}", tAlcool);
            Console.WriteLine("Gasolina: {0}", tGasolina);
            Console.WriteLine("Diesel: {0}", tDiesel);
            Console.ReadLine();
        }
    }
}
