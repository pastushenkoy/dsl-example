using Domain.Tests.DSL.Builders;

namespace Domain.Tests.DSL.Extensions
{
	public static class ProductExtensions
	{
		public static OrderLineBuilder CountOf(this Product product, decimal count)
		{
			return Create.OrderLine.Of(count, product);
		}
	}
}