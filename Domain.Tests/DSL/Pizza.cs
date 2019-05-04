namespace Domain.Tests.DSL
{
	public static class Pizza
	{
		public static Product Pepperoni => Create.Product("Pepperoni")
			.Containing(Ingredients.Dough)
			.Containing(Ingredients.Pepperoni)
			.Please();
		
		public static Product Margarita => Create.Product("Margarita")
			.Containing(Ingredients.Dough)
			.Containing(Ingredients.Mozzarella)
			.Please();
	}
}