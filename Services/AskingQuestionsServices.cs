using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class AskingQuestionsServices
    {
        public List<string> AskingQuestionsList = new();

    public List<string> AskingQuestions(string name, string timeInput)
    {
        if (!int.TryParse(timeInput, out int time))
        {
            AskingQuestionsList.Add("Please enter a valid integer for the time.");
            return AskingQuestionsList;
        }
        
        if (time < 1 || time > 12)
        {
            AskingQuestionsList.Add("Please enter a valid hour between 1 and 12.");
        }
        else
        {
            AskingQuestionsList.Add($"Good Morning {name}! You have woken at around {time}:00");
        }

        return AskingQuestionsList;
    }
    }
}