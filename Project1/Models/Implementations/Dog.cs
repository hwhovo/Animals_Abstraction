using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models.Implementations
{
    public class Dog : LandAnimal
    {
        public override void Breath()
        {
            Console.WriteLine("Dog is breathing!");
        }

        public override void Move(Coordinate coordinate)
        {
            Console.WriteLine($"Dog is running to {coordinate}");
        }

        protected override Food[] RegisterAvailableFoods()
        {
            return new Food[]
            {
                new Ribs(),
                new Shawarma(),
                new Kebab()
            };
        }
    }
}
