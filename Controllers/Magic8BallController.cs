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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;
        public Magic8BallController(Magic8BallServices magic8BallServices)
        {
        _magic8BallServices = magic8BallServices;
        }

        [HttpGet]
        [Route("Magic8Ball/{question}")]

        public string Magic8Ball(string question)
        {
            return _magic8BallServices.Magic8Ball(question);
        }
    }
}