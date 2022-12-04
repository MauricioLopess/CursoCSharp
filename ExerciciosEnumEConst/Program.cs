using System;
using System.Globalization;
using ExerciciosEnumEConst.ex01.Entities;
using ExerciciosEnumEConst.ex01.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosEnumEConst.ex02.Entities;
using ExerciciosEnumEConst.ex03.Entities;
using ExerciciosEnumEConst.ex03.Entities.Enums;

namespace ExerciciosEnumEConst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ex01
             *Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). 
             *Depois, solicitar do usuário um mês e mostrar qual foi o salário do 
             *funcionário nesse mês
            Console.Write("Enter your department: ");
            string tempDepart = Console.ReadLine();
            Console.WriteLine("Now, your information");
            Console.Write("Name: ");
            string tempName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel tempWLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel),Console.ReadLine());
            Console.Write("Base salary: ");
            double tempBSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(tempDepart);
            Worker Worker = new Worker(tempName, tempWLevel, tempBSalary, department);

            Console.Write("How many contracts? ");
            int cont = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cont; i++)
            {
                Console.WriteLine($"Enter the #{i} contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valphour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract (date, valphour, hour);
                Worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string my = Console.ReadLine();
            int month = int.Parse(my.Substring(0, 2));
            int year = int.Parse(my.Substring(3));

            Console.WriteLine("Name : " + Worker.Name);
            Console.WriteLine("Department: " + Worker.Department.Name);
            Console.WriteLine($"Income for {year}/{month}: R$ {Worker.Income(year, month).ToString(CultureInfo.InvariantCulture)}");
             *
             * ex02
             * Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do terminal
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12);
            p1.AddComment(c1);
            p1.AddComment(c2);
            Console.WriteLine(p1);
             *
             * ex03
             * Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
            sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser
            o instante do sistema: DateTime.Now
             */
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string cName = Console.ReadLine();

            Console.Write("Email: ");
            string cEmail = Console.ReadLine();

            Console.Write("Birth date: ");
            DateTime cDate = DateTime.Parse(Console.ReadLine());
            Client Client = new Client(cName, cEmail, cDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus oStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus),Console.ReadLine());

            Console.Write("How many itens to this order? ");
            int iOrder = int.Parse(Console.ReadLine());

            DateTime mOrder = DateTime.Now();
            Order Ord = new Order(mOrder, oStatus);

            for (int i = 1; i <= iOrder; i++)
            {
                Console.WriteLine();
                Console.Write($"Enter #{i} product data");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();

                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(pName, pPrice);
                OrderItem OItem = new OrderItem(pQuantity, product);
                Ord.AddItem(OItem);
            }
            
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine($"Order moment: {mOrder}\n" +
                $"Order status: {oStatus}");
            Console.WriteLine($"Client: {Client}");
            Console.WriteLine("Order items: ");
            foreach (Order o in Ord)
            {
                Console.WriteLine(Ord);
            }
            Console.ReadLine();
        }
    }
}
