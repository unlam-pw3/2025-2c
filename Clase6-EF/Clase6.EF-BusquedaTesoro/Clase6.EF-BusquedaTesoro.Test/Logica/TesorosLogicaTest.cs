using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase6.EF_BusquedaTesoro.Data.Entidades;
using Clase6.EF_BusquedaTesoro.Logica;
using Microsoft.Extensions.DependencyInjection;

namespace Clase6.EF_BusquedaTesoro.Test.Logica;

public class TesorosLogicaTest : TestBase
{
    [Fact]
    public void AgregarTest()
    {
        Pw320252cBusquedaTesoroContext context = ServiceProvider.GetService<Pw320252cBusquedaTesoroContext>();
        ITesorosLogica tesorosLogica = new TesorosLogica(context);

        //Arrange
        var tesoro = new Data.Entidades.Tesoro
        {
            Nombre = "Tesoro1",
            Valor = 1000,
            ImagenUrl = "http://imagen.com/tesoro1.jpg",
            Latitud = 10.0M,
            Longitud = 20.0M
        };
        //Act
        tesorosLogica.AgregarTesoro(tesoro);
        var tesoros = tesorosLogica.ObtenerTesoros();

        //Assert
        Assert.Single(tesoros);
        Assert.Equal("Tesoro1", tesoros[0].Nombre);
    }

    //Eliminar
    [Fact] 
    public void EliminarTest()
    {
        Pw320252cBusquedaTesoroContext context = ServiceProvider.GetService<Pw320252cBusquedaTesoroContext>();
        ITesorosLogica tesorosLogica = new TesorosLogica(context);
        //Arrange
        var tesoro = new Data.Entidades.Tesoro
        {
            Nombre = "Tesoro1",
            Valor = 1000,
            ImagenUrl = "http://imagen.com/tesoro1.jpg",
            Latitud = 10.0M,
            Longitud = 20.0M
        };
        tesorosLogica.AgregarTesoro(tesoro);
        //Act
        tesorosLogica.EliminarTesoro(tesoro.IdTesoro);
        var tesoros = tesorosLogica.ObtenerTesoros();
        //Assert
        Assert.Empty(tesoros);
    }

    //actualizar
    [Fact]
    public void ActualizarTest()
    {
        Pw320252cBusquedaTesoroContext context = ServiceProvider.GetService<Pw320252cBusquedaTesoroContext>();
        ITesorosLogica tesorosLogica = new TesorosLogica(context);
        //Arrange
        var tesoro = new Data.Entidades.Tesoro
        {
            Nombre = "Tesoro1",
            Valor = 1000,
            ImagenUrl = "http://imagen.com/tesoro1.jpg",
            Latitud = 10.0M,
            Longitud = 20.0M
        };
        tesorosLogica.AgregarTesoro(tesoro);
        //Act
        tesoro.Nombre = "TesoroActualizado";
        tesorosLogica.ActualizarTesoro(tesoro);
        var tesoroActualizado = tesorosLogica.ObtenerTesoroPorId(tesoro.IdTesoro);
        //Assert
        Assert.Equal("TesoroActualizado", tesoroActualizado.Nombre);
    }
}