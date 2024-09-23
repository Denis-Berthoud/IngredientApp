using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApp
{
    public class Flour : Ingredient
    {
        public Flour(double quantity) : base("Flour", quantity, "grams") { }
    }
}
