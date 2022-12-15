using System;
using System.Collections.Generic;
using HerencaPolemorfismoExFx.Entities;
using System.Globalization;

namespace HerencaPolemorfismoExFx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee {i+1} data:"); //usando interploração
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //fazendo o teste se o funcionario
                if (ch == 'y' || ch == 'Y')  // aspas simples significa tipo char
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //chamando a list
                    list.Add(new OutSourceEmployee(name, hour, valuePerHour, additionalCharge));    //fazendo um Upcasting

                }
                else 
                {

                    list.Add(new Employee(name, hour, valuePerHour));

                }

                Console.WriteLine();

            }

            //exibindo os dados
            Console.WriteLine();

            Console.WriteLine("Payments: ");

            //fazendo um foreach para percorrer tudo
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + ". $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
