using Bunit;
using Microsoft.Extensions.DependencyInjection;
using DevSummit.Pages;
using DevSummit.Northwind;
using DevSummit.Financial;

namespace TestDevSummit
{
	[Collection("DevSummit")]
	public class TestView_2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTreeGridModule),
				typeof(IgbPivotDataSelector),
				typeof(IgbCategoryChartModule),
				typeof(IgbPieChartModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<View_2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
