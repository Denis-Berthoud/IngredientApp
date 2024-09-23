using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApp
{
    public class Sugar : Ingredient
    {
        public Sugar(double quantity) : base("Sugar", quantity, "grams") { }
    }
}

