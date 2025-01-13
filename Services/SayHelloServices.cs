using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class SayHelloServices
    {
        public string SayHello(string Name)
        {
            return $"Hello, {Name} Nice to Meet You!";
        }
    }
}