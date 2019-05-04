using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
	public class Order
	{
		public DateTime Date { get; }
		
		public decimal Total { get; private set; } = 0m;
		
		private readonly List<OrderLine> _lines  = new List<OrderLine>();

		public Order(DateTime date)
		{
			Date = date;
		}
		
		public void AddLine(OrderLine line)
		{
			_lines.Add(line);
			Total = _lines.Sum(x => x.Sum);
		}
	}
}
