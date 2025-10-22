using Clase6.EF_BusquedaTesoro.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Clase6.EF_BusquedaTesoro.Test;

public class TestBase
{
    protected ServiceCollection Services { get; }
    protected ServiceProvider ServiceProvider { get; private set; }

    public TestBase()
    {
        Services = new ServiceCollection();

        Services.AddEntityFrameworkInMemoryDatabase();

        Services.AddDbContext<Pw320252cBusquedaTesoroContext>((sp, options) =>
            options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .UseInternalServiceProvider(sp));

        ServiceProvider = Services.BuildServiceProvider();
    }
}
