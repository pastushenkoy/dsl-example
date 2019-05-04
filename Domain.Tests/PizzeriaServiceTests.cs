using System;
using Domain.Tests.DSL;
using Domain.Tests.DSL.Extensions;
using Moq;
using Xunit;

namespace Domain.Tests
{
	public class PizzeriaServiceTests
	{
		[Fact]
		public void AcceptOrder_Successful()
		{
			var ingredient1 = new Ingredient("Ingredient1");
			var ingredient2 = new Ingredient("Ingredient2");
			var ingredient3 = new Ingredient("Ingredient3");
			
			var order = new Order(DateTime.Now);
			
			var product1 = new Product("Pizza1");
			product1.AddIngredient(ingredient1);
			product1.AddIngredient(ingredient2);
			
			var orderLine1 = new OrderLine(product1, 1, 500);
			order.AddLine(orderLine1);

			var product2 = new Product("Pepperoni");
			product2.AddIngredient(ingredient1);
			product2.AddIngredient(ingredient3);
			
			var orderLine2 = new OrderLine(product2, 1, 650);
			order.AddLine(orderLine2);

			var orderRepositoryMock = new Mock<IOrderRepository>();
			var ingredientsRepositoryMock = new Mock<IIngredientRepository>();

			var service = new PizzeriaService(orderRepositoryMock.Object, ingredientsRepositoryMock.Object);
			
			service.AcceptOrder(order);
			
			orderRepositoryMock.Verify(r => r.Add(order), Times.Once);
			ingredientsRepositoryMock.Verify(r => r.ReserveIngredients(order), Times.Once);
		}
		
		[Fact]
		public void WhenAcceptOrder_AddIsCalled()
		{
			var order = Create.Order
				.Dated(3.May(2019))
				.With(Pizza.Pepperoni.CountOf(1).For(500))
				.With(Pizza.Margarita.CountOf(1).For(650))
				.Please();
			
			var service = Create.PizzeriaService.Please();

			service.AcceptOrder(order);
			
			service.VerifyAddWasCalledWith(order);
		}
		
		[Fact]
		public void WhenAcceptOrder_ReserveIngredientsIsCalled()
		{
			var order = Create.Order
				.Dated(3.May(2019))
				.With(Pizza.Pepperoni.CountOf(1).For(500))
				.With(Pizza.Margarita.CountOf(1).For(650))
				.Please();
			
			var service = Create.PizzeriaService.Please();

			service.AcceptOrder(order);
			
			service.VerifyReserveIngredientsWasCalledWith(order);
		}
	}
}
