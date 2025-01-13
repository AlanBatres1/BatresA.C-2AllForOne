using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.C_2AllForOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace BatresA.C_2AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;
        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices){
            _askingQuestionsServices = askingQuestionsServices;
        }

        [HttpGet]
        [Route("AskingQuestions/{name}/{time}")]
        public List<string> GreetPersonList(string name, int time)
        {
            return _askingQuestionsServices.AskingQuestions(name, time);
        }

    }
}