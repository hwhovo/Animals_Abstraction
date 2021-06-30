using Project1.Models.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models.Implementations
{
    public class FastFood
    {
        FoodWithPrise[] AvailabeFoods = new FoodWithPrise[]
            {
                new FoodWithPrise{ Amount = 100, Food = new Ribs() },
                new FoodWithPrise{ Amount = 110, Food = new Shawarma() },
                new FoodWithPrise{ Amount = 170, Food = new Kebab() },
            };

        public Address address { get; set; } = new Address()
        {
            coordinate = new Coordinate(1, 4, 5)
        };
        public void Enter(IEatable eatable)
        {

        }

        public FoodWithPrise BuyFood(string foodName)
        {
            var foodFound = false;
            FoodWithPrise foodWithPrise = null;
            foreach (var item in AvailabeFoods)
            {
                if(item.Food.TypeUniqueName == foodName)
                {
                    foodFound = true;
                    foodWithPrise = item;
                }
            }

            if (!foodFound)
            {
                throw new Exception("Food not found");
            }

            return foodWithPrise;
        }
    }

    public class FoodWithPrise
    {
        public Food Food { get; set; }
        public decimal Amount { get; set; }
    }

}
