// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Security.Cryptography.X509Certificates;

namespace EjercicioNumOculto.Logica;
public class JuegoAdivinarNumero
{
    private int _numeroMinimo = 1;
    private int _numeroMaximo = 100;

    public int GetNumeroRandom()
    {
        Random numRandom = new Random();
        return numRandom.Next(_numeroMinimo, _numeroMaximo);
    }

    public string IndicaCercaniaAlUsuario(int _numUsuario, int _numRandom)
    {
        int diferencia = Math.Abs(_numUsuario - _numRandom);

        if (diferencia > 30) return "Frío";

        if (diferencia >= 16 && diferencia <= 30) return "Tibio";

        if (diferencia >= 6 && diferencia <= 15) return "Caliente";

        if (diferencia <= 5 && diferencia >= 1) return "Muy caliente";

        return "Numero invalido";

    }

    public bool JuegoTerminado(int _numRandom, int _numUsuario)
    {
        if (_numUsuario == _numRandom)
        {
            return true;
        }
        return false;
    }
}
