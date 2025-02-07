using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.C_2AllForOne.Services
{
    public class RestaurantPickerServices
    {
        public string RestaurantPicker(string foodType)
        {
            Random rng = new Random();
            string option = "";

            if (foodType != "Fast Food" && foodType != "Mexican" && foodType != "Chinese")
            {
                return "Please enter the correct category (Fast Food) (Mexican) (Chinese)";
            }

            if (foodType == "Fast Food")
            {
                switch (rng.Next(10)) // Generates a number between 0 and 9
                {
                    case 0:
                        option = "McDonald's";
                        break;
                    case 1:
                        option = "Wendy's";
                        break;
                    case 2:
                        option = "Burger King";
                        break;
                    case 3:
                        option = "Taco Bell";
                        break;
                    case 4:
                        option = "Jack in the Box";
                        break;
                    case 5:
                        option = "In-N-Out Burger";
                        break;
                    case 6:
                        option = "Raising Canes";
                        break;
                    case 7:
                        option = "Chick-fil-A";
                        break;
                    case 8:
                        option = "KFC";
                        break;
                    case 9:
                        option = "Subway";
                        break;
                    default:
                        option = "McDonald's"; // Fallback option
                        break;
                }
            }
            else if (foodType == "Mexican")
            {
                switch (rng.Next(10)) // Generates a number between 0 and 9
                {
                    case 0:
                        option = "Tacos Chapala";
                        break;
                    case 1:
                        option = "Tepa Taqueria";
                        break;
                    case 2:
                        option = "El Grullito";
                        break;
                    case 3:
                        option = "El Torito";
                        break;
                    case 4:
                        option = "Arroyo's Cafe";
                        break;
                    case 5:
                        option = "El Mayita";
                        break;
                    case 6:
                        option = "Birrialandia";
                        break;
                    case 7:
                        option = "Gallo's Taco Truck";
                        break;
                    case 8:
                        option = "Carolina's Grill Taqueria";
                        break;
                    case 9:
                        option = "Tequileros Taqueria";
                        break;
                    default:
                        option = "Tacos Chapala"; // Fallback option
                        break;
                }
            }
            else if (foodType == "Chinese")
            {
                switch (rng.Next(10)) // Generates a number between 0 and 9
                {
                    case 0:
                        option = "China Village Restaurant";
                        break;
                    case 1:
                        option = "Far East Restaurant";
                        break;
                    case 2:
                        option = "China Express";
                        break;
                    case 3:
                        option = "Panda Express";
                        break;
                    case 4:
                        option = "Louie's Chinese Restaurant";
                        break;
                    case 5:
                        option = "The Chopstick";
                        break;
                    case 6:
                        option = "New Yen Ching Restaurant";
                        break;
                    case 7:
                        option = "Sherman's 2 Chinese Buffet";
                        break;
                    case 8:
                        option = "New Shanghai Restaurant";
                        break;
                    case 9:
                        option = "M kitchen Buffet";
                        break;
                    default:
                        option = "China Village Restaurant"; // Fallback option
                        break;
                }
            }

            return option;
        }
    }

}

