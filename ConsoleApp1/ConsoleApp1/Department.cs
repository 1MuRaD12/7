using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Department
    {
        public string Name { get; set; }

        public int EmployeeLimit { get; set; }

        public Emoloyee[] employees = new Emoloyee[0];

        public Department(string name,int employeelimit)
        {
            Name = name;
            EmployeeLimit = employeelimit;
        }

        public void AddEmployee(Emoloyee emoloyee)
        {
            if (employees.Length <= EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length + 1] = emoloyee;
            }
            else
            {
                throw new CapacityLimitException("limiti asmisiz!!!");
            }
        }
        public Emoloyee this[int indexer]
        {
            get
            {
                return employees[indexer];
            }
            set
            {
                employees[indexer] = value;
            }
        }

        public void Showinfo()
        {
            Console.WriteLine($"Name:{Name}\nEmployeelimit:{EmployeeLimit}\n");
        }
    }
}
