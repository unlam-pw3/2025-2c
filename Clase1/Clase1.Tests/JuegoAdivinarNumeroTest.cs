using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase1.Logica;

namespace Clase1.Tests;

public class JuegoAdivinarNumeroTest
{
    [Theory]
    [InlineData(5,5, "ACIERTO")]
    [InlineData(50, 5, "FRIO")]
    [InlineData(50, 34, "TIBIO")]
    [InlineData(50, 38, "CALIENTE")]
    [InlineData(50, 48, "MUY CALIENTE")]
    public void SiUnJugadorRealizaIntentoQueSeLeMuestreElMensajeAdecuado(int numeroEsperado, int numeroIndicado, string mensajeEsperado)
    {
        JuegoAdivinarNumero juego = new JuegoAdivinarNumero(numeroEsperado);

        string acierto = juego.RealizarIntento(numeroIndicado);

        Assert.Equal(mensajeEsperado,acierto);
    }

}
