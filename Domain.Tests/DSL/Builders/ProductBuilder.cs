namespace Domain.Tests.DSL.Builders
{
	public class ProductBuilder
	{
		private Product _product;

		public ProductBuilder(string name)
		{
			_product = new Product(name);
		}

		public ProductBuilder Containing(Ingredient ingredient)
		{
			_product.AddIngredient(ingredient);
			return this;
		}

		public Product Please()
		{
			return _product;
		}
	}
}