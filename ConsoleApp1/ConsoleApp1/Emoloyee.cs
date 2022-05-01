using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Emoloyee : Iperson
    {
        private int _id;

        public static int Id;

        private int _age;

        public string Name { get; set; }

        private int _salary;

        public Emoloyee(string name, int age, int salary)
        {
            _id = ++Id;
            Name = name;
            Salary = salary;
            Age = age;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }

        public string Showinfo()
        {
            return $"Name:{Name}\nAge:{Age}\nSalary:{Salary}";
        }

        public override string ToString()
        {
            return Showinfo();
        }
    }
}
