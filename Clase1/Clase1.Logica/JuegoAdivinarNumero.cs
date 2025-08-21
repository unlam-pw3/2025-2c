using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Logica;

public class JuegoAdivinarNumero {

    private readonly int numeroEsperado;
    public JuegoAdivinarNumero(int numeroEsperado) => this.numeroEsperado = numeroEsperado;

    public string RealizarIntento(int numeroIndicado)
    {
        int diferencia = numeroEsperado - numeroIndicado;
        if (diferencia == 0)
            return "ACIERTO";
        if (diferencia <= 5)
            return "MUY CALIENTE";
        if (diferencia <= 15)
            return "CALIENTE";
        return diferencia <= 30 ? "TIBIO" : "FRIO";
    }
}
