using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nHow many employees are you hiring (max 5): ");
            int numofEployees = int.Parse(Console.ReadLine());
            if (numofEployees > 5)
            {
                Console.WriteLine("Employees cannot exceed 5 members. Auto setting to 5 employees...\n");
                numofEployees = 5;

            }

            string[] names = new string[numofEployees];
            int[] ages = new int[numofEployees];
            decimal[] salaries = new decimal[numofEployees];

            Console.WriteLine("-----Enter the employee details-----\n");
            for (int i = 0; i < numofEployees; i++)
            {
                Console.Write($"Enter Name of Person {i + 1}: ");
                names[i] = Console.ReadLine().Trim();
                Console.Write($"Enter Age of Person {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine().Trim());
                Console.Write($"Enter Salary of Person {i + 1}: ");
                salaries[i] = decimal.Parse(Console.ReadLine().Trim());
                Console.WriteLine();
            }

            Console.WriteLine("\n*****Displaying important information from the data.*****\n\n");
            decimal highestSalary = 0;
            string highestPayedEmployee = "";
            decimal blockSalary = 0;
            decimal averageSalary = 0;
            int oldestAge = 0;
            int youngestAge = 65;
            string oldestName = "";
            string youngestName = "";
            Console.WriteLine("-----Employee Details----");
            for (int i = 0; i < numofEployees; i++)
            {
                Console.WriteLine($"Name of Person----{i + 1}: {names[i]}");
                Console.WriteLine($"Age of Person-----{i + 1}: {ages[i]}");
                Console.WriteLine($"Salary of Person--{i + 1}: R{salaries[i]}");
                Console.WriteLine();

                blockSalary += salaries[i];
                if (salaries[i] > highestSalary)
                {
                    highestSalary = salaries[i];
                    highestPayedEmployee = names[i];
                }
                if (ages[i] > oldestAge)
                {
                    oldestName = names[i];
                    oldestAge = ages[i];

                }
                if (ages[i] < youngestAge)
                {
                    youngestName = names[i];
                    youngestAge = ages[i];
                }
                
            }
            averageSalary = blockSalary / numofEployees;
            Console.WriteLine("\n----Additional Information----");
            Console.WriteLine($"Net Salary Payment: R{blockSalary}");
            Console.WriteLine($"Average Salary PayOut: R{averageSalary} ");
            Console.WriteLine($"Highest Payed Employee: {highestPayedEmployee} (R{highestSalary})");
            Console.WriteLine($"Oldest Employee: {oldestName} ({oldestAge})");
            Console.WriteLine($"Youngest Employee: {youngestName} ({youngestAge})");
        }
    }
}
