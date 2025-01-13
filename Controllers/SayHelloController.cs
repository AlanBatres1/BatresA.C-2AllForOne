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
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;
        public SayHelloController(SayHelloServices sayHelloServices){
            _sayHelloServices = sayHelloServices;
        }
        [HttpGet]
        [Route("SayHello/{Name}")]
        public string SayHello(string Name)
        {
        return  _sayHelloServices.SayHello(Name);
        }
    }
}