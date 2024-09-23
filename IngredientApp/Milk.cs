using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApp
{
    public class Milk : Ingredient
    {
        public Milk(double quantity) : base("Milk", quantity, "ml") { }
    }
}
