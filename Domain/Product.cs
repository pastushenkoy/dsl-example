using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public string Name { get; }
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Product(string name)
        {
            Name = name;
        }

        public void AddIngredient(Ingredient ingredient1)
        {
            _ingredients.Add(ingredient1);
        }
    }
}