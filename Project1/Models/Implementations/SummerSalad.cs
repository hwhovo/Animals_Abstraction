using Project1.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models.Implementations
{
    public class SummerSalad : VegeterianFood
    {
        protected override string RegisterFoodName()
        {
            return "SummerSalad";
        }
    }
}
