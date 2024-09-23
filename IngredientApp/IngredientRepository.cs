using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IngredientApp
{
    public class IngredientRepository : IIngredientRepository
    {
        private const string FilePath = "ingredients.json";

        public void SaveSelectedIngredients(List<IIngredient> ingredients)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new IngredientJsonConverter() } // Add custom converter here
            };
            var json = JsonSerializer.Serialize(ingredients, options);
            File.WriteAllText(FilePath, json);
        }

        public List<IIngredient> LoadSelectedIngredients()
        {
            if (!File.Exists(FilePath)) return new List<IIngredient>();

            var json = File.ReadAllText(FilePath);
            var options = new JsonSerializerOptions
            {
                Converters = { new IngredientJsonConverter() } // Add custom converter here
            };

            // Deserialize the JSON into a list of IIngredient
            return JsonSerializer.Deserialize<List<IIngredient>>(json, options);
        }
    }
}
