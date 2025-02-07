using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string numberInput)
        {

            if (!int.TryParse(numberInput, out int number))
            {
                return "Please enter a valid integer.";
            }
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