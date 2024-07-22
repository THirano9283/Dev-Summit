using Bunit;
using Microsoft.Extensions.DependencyInjection;
using DevSummit.Pages;
using DevSummit.DataSource1;

namespace TestDevSummit
{
	[Collection("DevSummit")]
	public class TestView_3
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule),
				typeof(IgbDataGridToolbarModule),
				typeof(IgbActionStripModule));
			ctx.Services.AddScoped<IDataSource1Service>(sp => new MockDataSource1Service());
			var componentUnderTest = ctx.RenderComponent<View_3>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
