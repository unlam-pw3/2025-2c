using System.Drawing;

namespace Clase1.Logica;

public class JuegoNumero
{
    private int _numeroSecreto;
    public bool JuegoTerminado { get; private set; } = false; // estado de la partida

    public void ElegirNumeroAleatorio(int min = 1, int max = 100)
    {
        Random rand = new Random();
        _numeroSecreto = rand.Next(min, max + 1);
        JuegoTerminado = false; // reinicia al empezar
    }

    public string AdivinarNumero(int numero)
    {
        int diferencia = Math.Abs(_numeroSecreto - numero);

        if (diferencia == 0)
        {
            JuegoTerminado = true; // marcamos que terminó
            return "Ganaste!";
        }
        if (diferencia <= 5)
            return "Muy Caliente";
        if (diferencia <= 15)
            return "Caliente";
        if (diferencia <= 30)
            return "Tibio";

        return "Frío";
    }
}
