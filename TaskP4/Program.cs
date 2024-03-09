using System;
using System.Collections.Generic;
using static Task4.Employee;

namespace Task4
{
    public delegate bool FilterDelegate<in T>(T value); 
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  decimal baseSalary {  get; set; }
        public decimal bonus { get; set; }
        public  decimal taxRate { get; set; }


         public decimal CalcNetSalary()
         {
           decimal totalSalary=baseSalary+bonus;

           decimal taxAmount=totalSalary*taxRate;

           decimal netSalary = totalSalary - taxAmount;

            return netSalary;
         }

        public class Report
        {
            public void ProcessEmployee<T>(IEnumerable<T>  employees, string title, FilterDelegate<T> predicate) where T : Employee
            {
                Console.WriteLine(title);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");

                foreach (var emp in employees)
                {
                    if (predicate(emp))
                    {
                        Console.WriteLine($" Name : {emp.Name} | BaseSalary = {emp.baseSalary.ToString("C")} | NetSalary = {emp.CalcNetSalary().ToString("C")} | Bouns = {emp.bonus.ToString("C")}  ");
                    }
                }
                Console.WriteLine("\n\n");
            }
        }



    }
    class Program
    {
        static void Main()
        {
            var Employees=new List<Employee>();

            for (int i = 1; i <= 20; i++)
            {

                Random random = new Random();
                Employees.Add(new Employee()
                {
                    Id = i,
                    Name = $"Empolyee [{i}]",
                    baseSalary = random.Next(5000, 10000),
                    bonus = random.Next(500, 1000),
                    taxRate =.2m

                });
                
            }
            Report report = new Report();
            report.ProcessEmployee(Employees, "Employees whose salary is more than 7000", x => x.CalcNetSalary() > 7000 );
            report.ProcessEmployee(Employees, "Employees whose bouns is more than 800", x => x.bonus > 800);

        }
    }
    }



