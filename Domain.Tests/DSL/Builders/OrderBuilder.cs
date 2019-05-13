using System;
using System.Collections.Generic;

namespace Domain.Tests.DSL.Builders
{
	public class OrderBuilder
	{
		private DateTime _date;
		private readonly List<OrderLine> _lines = new List<OrderLine>();
		
		public OrderBuilder Dated(DateTime date)
		{
			_date = date;
			return this;
		}

		public OrderBuilder With(OrderLine orderLine)
		{
			_lines.Add(orderLine);
			return this;
		}

		public Order Please()
		{
			var order = new Order(_date);
			foreach (var line in _lines)
			{
				order.AddLine(line);
			}
			
			return order;
		}
	}
}