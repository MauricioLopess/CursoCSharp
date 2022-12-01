using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioLista;

namespace ExerciciosLista
{
    internal class Program
    {
        /*
         * ex 01
        Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
        N funcionários. Não deve haver repetição de id.
        Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
        Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
        mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
        conforme exemplos.
        Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
        ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
        aumento por porcentagem dada.
        */
        static void Main(string[] args)
        {
            List<Employee> employess = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int quantFunc = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < quantFunc; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employess.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id will have a salary increased: ");
            int id2 = int.Parse(Console.ReadLine());
            if (id2 != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                int index = employess.FindIndex(x => x.Id == id2);
                employess[index].IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.ReadLine();


        }
    }
}
