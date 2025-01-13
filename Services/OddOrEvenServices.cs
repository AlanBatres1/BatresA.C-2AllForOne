using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} is even";
            }
            else
            {
                return $"{number} is odd";
            }
        }
    }
}