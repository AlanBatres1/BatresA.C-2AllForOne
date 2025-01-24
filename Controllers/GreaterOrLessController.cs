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
    public class GreaterOrLessController : ControllerBase
    {
        private readonly GreaterOrLessServices _greaterOrLessServices;

        public GreaterOrLessController(GreaterOrLessServices greaterOrLessServices){
            _greaterOrLessServices = greaterOrLessServices;
        }

        [HttpGet]
        [Route("GreaterOrLess/{num1}/{num2}")]

        public string GreaterOrLess(string num1, string num2){
            return _greaterOrLessServices.GreaterOrLess(num1, num2);
        }
    }
}