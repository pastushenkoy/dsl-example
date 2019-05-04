namespace Domain.Tests.DSL.Builders
{
	public class OrderLineBuilder
	{
		private Product _product;
		private decimal _count;
		private decimal _price;
		
		public OrderLineBuilder Of(decimal count, Product product)
		{
			_product = product;
			_count = count;
			return this;
		}

		public OrderLineBuilder For(decimal price)
		{
			_price = price;
			return this;
		}

		public static implicit operator OrderLine(OrderLineBuilder b)
		{
			return new OrderLine(b._product, b._count, b._price);
		}
	}
}