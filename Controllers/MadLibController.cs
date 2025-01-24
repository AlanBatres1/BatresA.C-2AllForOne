using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.C_2AllForOne.Models;
using BatresA.C_2AllForOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace BatresA.C_2AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("MadLib/{name1}/{name2}/{store}/{beverage}/{snack}/{sport}/{movie}/{restaurant}/{videogame}/{food}")]
        public string MadLib( string name1, string name2, string store, string beverage, string snack,string sport, string movie,  string restaurant, string videogame, string food)
        {
            return _madLibServices.MadLib(name1, name2, store, beverage, snack,sport, movie, restaurant, videogame, food);
        }
    }
}