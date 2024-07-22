using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DevSummit;
using DevSummit.Financial;
using DevSummit.Northwind;
using DevSummit.DataSource1;
using IgniteUI.Blazor.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();


builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
builder.Services.AddScoped<IDataSource1Service, DataSource1Service>();
RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbTreeGridModule),
        typeof(IgbPivotDataSelector),
        typeof(IgbPieChartModule),
        typeof(IgbGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbActionStripModule)
    );
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
