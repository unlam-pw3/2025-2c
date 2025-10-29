using Clase6.EF_BusquedaTesoro.Data.Entidades;
using Clase6.EF_BusquedaTesoro.Logica;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.EF_BusquedaTesoro.Test.Logica
{
    public class CazatesorosLogicaTest : TestBase
    {

        [Fact]
        public void AgregarTest()
        {
            Pw320252cBusquedaTesoroContext context = ServiceProvider.GetService<Pw320252cBusquedaTesoroContext>();
            ICazatesorosLogica cazatesorosLogica = new CazatesorosLogica(context);

            //Arrange
            var cazatesoro = new Cazatesoro
            {
                Nick = "Cazatesoro1",
                AvatarUrl = "http://imagen.com/cazatesoro1.jpg",

            };

            //Act
            cazatesorosLogica.AgregarCazatesoro(cazatesoro);
            var cazatesoros = cazatesorosLogica.ObtenerCazatesoros();
            //Assert
            Assert.Single(cazatesoros);
            Assert.Equal("Cazatesoro1", cazatesoros[0].Nick);

        }


        [Fact]
        public void EliminarTest()
        {
            Pw320252cBusquedaTesoroContext context = ServiceProvider.GetService<Pw320252cBusquedaTesoroContext>();
            ICazatesorosLogica cazatesorosLogica = new CazatesorosLogica(context);
            //Arrange
            var cazatesoro = new Cazatesoro
            {
                Nick = "Cazatesoro1",
                AvatarUrl = "http://imagen.com/cazatesoro1.jpg",
            };
            cazatesorosLogica.AgregarCazatesoro(cazatesoro);
            //Act
            cazatesorosLogica.EliminarCazatesoro(cazatesoro.IdCazatesoro);
            var cazatesoros = cazatesorosLogica.ObtenerCazatesoros();
            //Assert
            Assert.Empty(cazatesoros);
        }


        [Fact]
        public void ActualizarTest()
        {
            Pw320252cBusquedaTesoroContext context = ServiceProvider.GetService<Pw320252cBusquedaTesoroContext>();
            ICazatesorosLogica cazatesorosLogica = new CazatesorosLogica(context);
            //Arrange
            var cazatesoro = new Cazatesoro
            {
                Nick = "Cazatesoro1",
                AvatarUrl = "http://imagen.com/cazatesoro1.jpg",
            };
            cazatesorosLogica.AgregarCazatesoro(cazatesoro);
            //Act
            cazatesoro.Nick = "CazatesoroActualizado";
            cazatesorosLogica.ActualizarCazatesoro(cazatesoro);
            var cazatesoros = cazatesorosLogica.ObtenerCazatesoros();
            //Assert
            Assert.Single(cazatesoros);
            Assert.Equal("CazatesoroActualizado", cazatesoros[0].Nick);
        }

    }
}
