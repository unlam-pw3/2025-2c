using System.Drawing;

namespace Clase1.Logica;

public class JuegoAdivinarNumero
{
    private int _numeroObjetivo;
    private int _intentos;

    public void IniciarJuego()
    {
        Random random = new Random();
        _numeroObjetivo = random.Next(1, 101);
        _intentos = 0;
    }

    public int ObtenerIntentos()
    {
        return _intentos;
    }

    public string IntentarAdivinar(int numero)
    {
        _intentos++;
        int diferencia = Math.Abs(_numeroObjetivo - numero);

        if (numero == _numeroObjetivo)
            return "¡Correcto! Adivinaste el número.";

        if (diferencia > 30)
            return "Frío";
        if (diferencia >= 16)
            return "Tibio";
        if (diferencia >= 6)
            return "Caliente";
        return "Muy caliente";
    }

    public bool JuegoTerminado(int numero)
    {
        return numero == _numeroObjetivo;
    }

    // Para pruebas unitarias
    public void SetNumeroObjetivo(int numero)
    {
        _numeroObjetivo = numero;
    }

    public int ObtenerNumeroObjetivo()
    {
        return _numeroObjetivo;
    }
     
}