using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message)
        {
            
        }
    }
}
