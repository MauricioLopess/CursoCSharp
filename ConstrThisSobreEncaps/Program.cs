﻿using System;
using System.Globalization;
namespace ConstrThisSobreEncaps
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        
             ex final
            Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, 
            o nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. 
            Este valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro
            a depositar no momento de abrir sua conta, o depósito inicial não será feito e o 
            saldo inicial da conta será, naturalmente, zero.

            Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
            o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
            exemplo).

            Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
            isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
            realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
            suficiente para realizar o saque e/ou pagar a taxa.

            Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
            informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
            mostrando os dados da conta após cada operação.

             */
            double valor = 0;
            Console.Write("Digite o número da conta: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Deseja depositar um valor inicial?(s/n) ");
            char opc = char.Parse(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria(id, nome);
            if (opc == 's')
            {
                Console.Write("Digite o valor inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Depositar(valor);
                Console.WriteLine($"\nDados: \n{conta}\n");
            }
            else
            {
                Console.WriteLine($"\nDados: \n{conta}\n");
            }

            Console.Write("Digite um valor para deposito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valor);
            Console.WriteLine($"\nDados atualizados: \n{conta}\n");

            Console.Write("Digite um valor para sacar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor);
            Console.WriteLine($"\nDados atualizados: \n{conta}\n");


            Console.ReadLine();
        }
    }
}