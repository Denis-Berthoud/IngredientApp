using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IngredientApp
{
    public class IngredientJsonConverter : JsonConverter<IIngredient>
    {
        public override IIngredient Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                string name = root.GetProperty("Name").GetString();

                // Return the appropriate ingredient type based on the "Name" property
                return name switch
                {
                    "Flour" => new Flour(root.GetProperty("Quantity").GetDouble()),
                    "Sugar" => new Sugar(root.GetProperty("Quantity").GetDouble()),
                    "Milk" => new Milk(root.GetProperty("Quantity").GetDouble()),
                    _ => throw new Exception("Unknown ingredient type")
                };
            }
        }

        public override void Write(Utf8JsonWriter writer, IIngredient value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Name", value.Name);
            writer.WriteNumber("Quantity", value.Quantity);
            writer.WriteString("Unit", value.Unit);
            writer.WriteEndObject();
        }
    }
}
