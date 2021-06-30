using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class Food
    {
        public Food()
        {
            InitFoodName();
        }

        private void InitFoodName()
        {
            TypeUniqueName = RegisterFoodName();
        }

        protected abstract string RegisterFoodName();

        public string TypeUniqueName { get; set; }
    }
}
