using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.C_2AllForOne.Models;

namespace BatresA.C_2AllForOne.Services
{
    public class MadLibServices
    {
        public string MadLib(MadLibModel madLibModel)
        {
            return $"{madLibModel.name1} and {madLibModel.name2} were bored one day so they decided to walk to {madLibModel.store}. Once they got to {madLibModel.store} they were really thirsty and hungry so they decide buy a {madLibModel.beverage} and some {madLibModel.snack}. After they were refreshed they decide to go play some {madLibModel.sport}. After they played they decided to watch {madLibModel.movie} at the theater across the street. Once they finished the movie they were really hungry because they didn't buy any snacks at the theater, so they decided to eat at {madLibModel.restaurant}. They were so full they couldn't walk, so they decided to call {madLibModel.name1}'s mother for a ride back home. Once they got to {madLibModel.name1}'s house they played {madLibModel.videogame}. While they were playing for hours {madLibModel.name1}'s mom made them some {madLibModel.food}. They really changed the boring day into something fun.";
        }
    }
}