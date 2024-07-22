using Bunit;
using Microsoft.Extensions.DependencyInjection;
using DevSummit.Pages;
using DevSummit.Financial;

namespace TestDevSummit
{
	[Collection("DevSummit")]
	public class TestView_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
