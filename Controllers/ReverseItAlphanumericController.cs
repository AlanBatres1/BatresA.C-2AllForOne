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
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericServices _reverseItAlphanumericServices;
        public ReverseItAlphanumericController(ReverseItAlphanumericServices reverseItAlphanumericServices)
        {
            _reverseItAlphanumericServices = reverseItAlphanumericServices;
        }
        [HttpGet]
        [Route("ReverseItAlphanumeric/{Input}")]
        public List<string> ReverItAlphanumeric(string Input)
        {
            return _reverseItAlphanumericServices.ReversItAlphanumeric(Input);
        }
    }
}