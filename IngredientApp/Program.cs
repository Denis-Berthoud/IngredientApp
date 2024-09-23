namespace IngredientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IIngredientRepository repository = new IngredientRepository();
            var selectedIngredients = repository.LoadSelectedIngredients();

            Console.WriteLine("Previously selected ingredients:");
            DisplayIngredients(selectedIngredients);

            var availableIngredients = new List<IIngredient>
            {
                new Flour(500),
                new Sugar(200),
                new Milk(300)
            };

            Console.WriteLine("\nAvailable ingredients:");
            DisplayIngredients(availableIngredients);

            Console.WriteLine("\nSelect an ingredient by number (or press 0 to quit):");

            while (true)
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) break;

                if (choice <= availableIngredients.Count)
                {
                    selectedIngredients.Add(availableIngredients[choice - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }

            repository.SaveSelectedIngredients(selectedIngredients);
            Console.WriteLine("\nYour selected ingredients have been saved!");
        }

        static void DisplayIngredients(List<IIngredient> ingredients)
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine($"{i + 1}: ");
                ingredients[i].DisplayInfo();
            }
        }
    }
}
