using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class Add2NumsServices
    {
        public string Add2Nums(string num1, string num2)
        {
            if (!int.TryParse(num1, out int firstNumber) || !int.TryParse(num2, out int secondNumber))
            {
                return "Enter integers";
            }
            int sum = firstNumber + secondNumber;
            return sum.ToString();
        }
    }
}