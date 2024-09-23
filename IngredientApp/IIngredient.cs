using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApp
{
    public interface IIngredient
    {
        string Name { get; }
        double Quantity { get; }
        string Unit { get; }

        void DisplayInfo();
    }
}
