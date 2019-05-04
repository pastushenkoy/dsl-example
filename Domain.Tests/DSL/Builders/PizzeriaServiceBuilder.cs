using Domain.Tests.DSL.Testables;
using Moq;

namespace Domain.Tests.DSL.Builders
{
	public class PizzeriaServiceBuilder
	{
		public PizzeriaServiceTestable Please()
		{
			var orderRepositoryMock = new Mock<IOrderRepository>();
			var ingredientsRepositoryMock = new Mock<IIngredientRepository>();

			return new PizzeriaServiceTestable(orderRepositoryMock, ingredientsRepositoryMock);
		}
	}
}