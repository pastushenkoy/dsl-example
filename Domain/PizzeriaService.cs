using System;

namespace Domain
{
	public class PizzeriaService
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IIngredientRepository _ingredientRepository;

		public PizzeriaService(IOrderRepository orderRepository, IIngredientRepository ingredientRepository)
		{
			_orderRepository = orderRepository;
			_ingredientRepository = ingredientRepository;
		}

		public bool AcceptOrder(Order order)
		{
			if (!ValidateOrder(order))
			{
				return false;
			}

			_orderRepository.Add(order);
			_ingredientRepository.ReserveIngredients(order);
			
			return true;
		}

		private bool ValidateOrder(Order order)
		{
			if (order.Total <= 0)
			{
				return false;
			}

			return true;
		}
	}
}