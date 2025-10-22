using Clase6.EF_BusquedaTesoro.Data.Entidades;
using Clase6.EF_BusquedaTesoro.Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // This registers ITempDataDictionaryFactory and other MVC services

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<Pw320252cBusquedaTesoroContext>();
builder.Services.AddScoped<ITesorosLogica, TesorosLogica>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tesoros}/{action=Lista}/{id?}");

app.Run();
