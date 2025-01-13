using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class AskingQuestionsServices
    {
        public List<string> AskingQuestionsList = new();
        public List<string> AskingQuestions(string name, int time)
        {
            if (time > 12 || time == 0)
            {
                AskingQuestionsList.Add("Please Enter a Hour 1-12");
            }
            else
            {
                AskingQuestionsList.Add($"Good Morning {name}! You have woken at around {time}:00");
            }
            return AskingQuestionsList;
        }
    }
}