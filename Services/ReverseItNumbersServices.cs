using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class ReverseItNumbersServices
    {
        public List<string> reversedNum = new();
        bool validCheck = false;
        int toNum;
        string reversedNumber = string.Empty;
        public List<string> ReversedItNumbers(string number)
        {
            validCheck = int.TryParse(number, out toNum);
            if (number.Length > 10)
            {
                reversedNum.Add("Input only 10 or less characters");
                return reversedNum;
            }
            else if (validCheck == false)
            {
                reversedNum.Add("Only enter Numbers");
                return reversedNum;
            }
            else
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    reversedNumber += number[i];
                }
            }
            reversedNum.Add($"{reversedNumber}");
            return reversedNum;
        }
    }
}