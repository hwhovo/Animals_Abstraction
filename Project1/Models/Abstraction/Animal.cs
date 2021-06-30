using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class Animal : IBreathable, IMoveable, IEatable
    {
        public Animal()
        {
            InitAvailableFoods();
        }

        protected Food[] AvailableFoods { get; set; }
        

        public abstract void Breath();
        protected abstract Food[] RegisterAvailableFoods();
        public abstract void Move(Coordinate coordinate);


        public virtual void Eat(Food food)
        {
            var canEat = false;

            foreach (var item in AvailableFoods)
            {
                if (food.TypeUniqueName == item.TypeUniqueName)
                {
                    canEat = true;
                    break;
                }
            }

            if (canEat)
            {
                Console.WriteLine("Thanks very tasty!");
            }
            else
            {
                throw new Exception("Can't eat this kind of the food");
            }
        }

        protected void InitAvailableFoods()
        {
            AvailableFoods = RegisterAvailableFoods();
        }
    }
}
