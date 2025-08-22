using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Logica;

public class JuegoAdivinarNumero {

    private int numeroEsperado;
    public bool gana;
    public JuegoAdivinarNumero(int numeroEsperado) { 
        this.numeroEsperado = numeroEsperado;
        this.gana = false;
    }

    public JuegoAdivinarNumero() { 
    }

    public void NuevaRonda()
    {
        Random random = new Random();
        this.numeroEsperado = random.Next(1, 100);
        this.gana = false;
    }

    public string RealizarIntento(int numeroIndicado)
    {
        int diferencia = numeroEsperado - numeroIndicado;
        if (diferencia == 0)
        {
            this.gana = true;
            return "ACIERTO";
        }
        if (diferencia <= 5)
            return "MUY CALIENTE";
        if (diferencia <= 15)
            return "CALIENTE";
        return diferencia <= 30 ? "TIBIO" : "FRIO";
    }

    public bool AdivinaElNumero()
    {
        return this.gana;
    }
}
