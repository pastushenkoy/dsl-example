namespace Domain 
{
	public class OrderLine
	{
		public OrderLine(Product product, decimal qty, decimal price)
		{
			Product = product;
			Qty = qty;
			Price = price;
			Sum = Qty * Price;
		}
		
		public Product Product { get; }

		public decimal Qty { get; }

		public decimal Price { get; }
		
		public decimal Sum { get; }
	}
}