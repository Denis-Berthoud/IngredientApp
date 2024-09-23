using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApp
{
    public class Ingredient : IIngredient
    {
        public string Name { get; private set; }
        public double Quantity { get; private set; }
        public string Unit { get; private set; }

        protected Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Quantity} {Unit} of {Name}");
        }
    }
}
