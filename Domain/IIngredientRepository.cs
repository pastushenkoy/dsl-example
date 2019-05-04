namespace Domain
{
	public interface IIngredientRepository
	{
		void ReserveIngredients(Order order);
	}
}