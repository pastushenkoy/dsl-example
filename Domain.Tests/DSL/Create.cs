using Domain.Tests.DSL.Builders;

namespace Domain.Tests.DSL
{
	public static class Create
	{
		public static ProductBuilder Product(string name) => new ProductBuilder(name);

		public static OrderBuilder Order => new OrderBuilder();

		public static OrderLineBuilder OrderLine => new OrderLineBuilder();
		
		public static PizzeriaServiceBuilder PizzeriaService => new PizzeriaServiceBuilder();
	}
}