using System.Drawing;

namespace TareaClase1.Logica;

public class AdivinarNumero
{
    private int _numeroMinimo = 1;
    private int _numeroMaximo = 100;

    public int ObtenerNumeroRandom()
    {
        Random random = new Random();
        return random.Next(_numeroMinimo, _numeroMaximo);
    }

    public string DeterminarDiferencia(int _numeroRandom, int _numeroIngresado)
    {
        int diferencia = Math.Abs(_numeroRandom - _numeroIngresado);
        if(diferencia > 30)
        {
            return "FRIO";
        } else if (diferencia >= 16 && diferencia <= 30)
        {
            return "TIBIO";
        } else if (diferencia >= 6 && diferencia <= 15)
        {
            return "CALIENTE";
        } else if (diferencia <= 5 && diferencia >= 1)
        {
            return "MUY CALIENTE";
        } else
        {
            return "EL NUMERO INGRESADO ES EL CORRECTO";
        }
    }

    public Boolean FinalizoElJuego(int _numeroRandom, int _numeroIngresado)
    {
        if(_numeroRandom == _numeroIngresado)
        {
            return true;
        }    
        return false;
    }
}
