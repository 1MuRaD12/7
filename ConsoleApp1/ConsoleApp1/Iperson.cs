using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Iperson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Showinfo();
    }
}
