using GestionF1.Data.Entidades;
using GestionF1.Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<GestionF1Context>();
builder.Services.AddScoped<IPilotoLogica, PilotoLogica>();
builder.Services.AddScoped<IEscuderiaLogica, EscuderiaLogica>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pilotos}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
