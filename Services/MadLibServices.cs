using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.C_2AllForOne.Models;

namespace BatresA.C_2AllForOne.Services
{
    public class MadLibServices
    {
        public string MadLib( string name1, string name2, string store, string beverage, string snack, string sport, string movie, string restaurant, string videogame,  string food)
{
    return $"{name1} and {name2} were bored one day so they decided to walk to {store}. Once they got to {store} they were really thirsty and hungry so they decide buy a {beverage} and some {snack}. After they were refreshed they decide to go play some {sport}. After they played they decided to watch {movie} at the theater across the street. Once they finished the movie they were really hungry because they didn't buy any snacks at the theater, so they decided to eat at {restaurant}. They were so full they couldn't walk, so they decided to call {name1}'s mother for a ride back home. Once they got to {name1}'s house they played {videogame}. While they were playing for hours {name1}'s mom made them some {food}. They really changed the boring day into something fun.";
}
    }
}