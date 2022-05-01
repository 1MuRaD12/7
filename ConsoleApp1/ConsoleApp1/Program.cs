using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Emoloyee emoloyee = new Emoloyee("murad",20,2500);
            Emoloyee emoloyee2 = new Emoloyee("murad",20,2500);

            Department department = new Department("hold", 1);

            //Console.WriteLine(department.EmployeeLimit);
            department.AddEmployee(emoloyee);
            department.AddEmployee(emoloyee2);

            foreach (var item in department.employees)
            {
                Console.WriteLine(item.Showinfo());
            }
        }
    }
}
