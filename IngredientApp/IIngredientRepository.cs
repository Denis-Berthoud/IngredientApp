using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientApp
{
    public interface IIngredientRepository
    {
        void SaveSelectedIngredients(List<IIngredient> ingredients);
        List<IIngredient> LoadSelectedIngredients();
    }
}
