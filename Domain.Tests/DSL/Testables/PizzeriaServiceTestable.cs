using Moq;

namespace Domain.Tests.DSL.Testables
{
	public class PizzeriaServiceTestable : PizzeriaService
	{
		private readonly Mock<IOrderRepository> _orderRepositoryMock;
		private readonly Mock<IIngredientRepository> _ingredientRepositoryMock;

		public PizzeriaServiceTestable(Mock<IOrderRepository> orderRepositoryMock, Mock<IIngredientRepository> ingredientRepositoryMock) 
			: base(orderRepositoryMock.Object, ingredientRepositoryMock.Object)
		{
			_orderRepositoryMock = orderRepositoryMock;
			_ingredientRepositoryMock = ingredientRepositoryMock;
		}

		public void VerifyAddWasCalledWith(Order order)
		{
			_orderRepositoryMock.Verify(r => r.Add(order), Times.Once);
		}

		public void VerifyReserveIngredientsWasCalledWith(Order order)
		{
			_ingredientRepositoryMock.Verify(r => r.ReserveIngredients(order), Times.Once);

		}
	}
}