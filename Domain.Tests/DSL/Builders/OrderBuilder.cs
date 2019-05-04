using System;

namespace Domain.Tests.DSL.Builders
{
	public class OrderBuilder
	{
		private Order _order;

		public OrderBuilder Dated(DateTime date)
		{
			_order = new Order(date);
			return this;
		}

		public OrderBuilder With(OrderLine orderLine)
		{
			_order.AddLine(orderLine);
			return this;
		}

		public Order Please()
		{
			return _order;
		}
	}
}