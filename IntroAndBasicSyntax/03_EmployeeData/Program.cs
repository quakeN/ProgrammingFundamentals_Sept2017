using System;

namespace _03_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());

            var digits = employeeID.ToString().Length;
            var eID = "Employee ID: ";

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            switch (digits)
            {
                case 1:
                    Console.WriteLine("{0}0000000{1}", eID, employeeID);
                    break;
                case 2:
                    Console.WriteLine("{0}000000{1}", eID, employeeID);
                    break;
                case 3:
                    Console.WriteLine("{0}00000{1}", eID, employeeID);
                    break;
                case 4:
                    Console.WriteLine("{0}0000{1}", eID, employeeID);
                    break;
                case 5:
                    Console.WriteLine("{0}000{1}", eID, employeeID);
                    break;
                case 6:
                    Console.WriteLine("{0}00{1}", eID, employeeID);
                    break;
                case 7:
                    Console.WriteLine("{0}0{1}", eID, employeeID);
                    break;
                case 8:
                    Console.WriteLine("{0}{1}", eID, employeeID);
                    break;
            }
           
            Console.WriteLine("Salary: {0:f2}", salary);
        }
    }
}
