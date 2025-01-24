using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class GreaterOrLessServices
    {
        public string GreaterOrLess(string num1, string num2)
        {
            int firstNumber;
            int secondNumber;
            bool validFirstNumber = int.TryParse(num1, out firstNumber);
            bool validSecondNumber = int.TryParse(num2, out secondNumber);

            if(validFirstNumber == false || validSecondNumber == false)
            {
                return "Make sure you are typing integer numbers.";
            }
            else
            {
                if(firstNumber > secondNumber) {
                    return $"{firstNumber} is greater than {secondNumber}.";
                } else if(firstNumber < secondNumber) {
                    return $"{firstNumber} is less than {secondNumber}.";
                } else {
                    return $"{firstNumber} is equal to {secondNumber}.";
                }
            }
        }
    }
}