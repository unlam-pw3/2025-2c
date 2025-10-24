using System.Drawing;
using System.Threading;
namespace PracticaClase1.Logica;

public class SimonDice
{
    // Disponibilizar las 4 flechas del teclado en un arraylist, todo dentro de un atributo privado y estatico 
    private static string[] _letras = { "a", "d", "p", "w" };

    private int _cantidadDeJuegos;

    public int CantidadDeJuegos => _cantidadDeJuegos;

    // Atributo privado en un arraylist que guarde la secuencia de flechas
    private string _secuencia;


    public SimonDice()
    {
        _cantidadDeJuegos = 0;
        _secuencia = String.Empty;
    }

    public void IniciarJuego()
    {
        _cantidadDeJuegos++;
        VaciarSecuencia();
        AgregarFlechaAleatoriaALaSecuencia(_cantidadDeJuegos);
    }

    public string ObtenerSecuencia()
    {
        return this._secuencia;
    }

    public bool VerificarSecuencia(string secuenciaUsuario)
    {
        if (secuenciaUsuario.Length != _secuencia.Length)
        {
            return false;
        }

        for (int i = 0; i < _secuencia.Length; i++)
        {
            if (secuenciaUsuario[i] != _secuencia[i])
            {
                return false;
            }
        }

        return true;
    }

    public void ReiniciarJuego()
    {
        _cantidadDeJuegos = 0;
        VaciarSecuencia();
    }

    public void MostrarSecuenciaConPausa(int segundos)
    {
        foreach (char c in _secuencia)
        {

            Console.WriteLine(c);
            Thread.Sleep((int)(segundos * 1000));
        }
        Console.Clear();
    }

    private void AgregarFlechaAleatoriaALaSecuencia(int vecesJugadas)
    {

        if (vecesJugadas >= 1 && vecesJugadas <= 4)
        {
            for (int i = 0; i < (vecesJugadas + 1); i++)
            {
                _secuencia += _letras[GenerarRandom()];
            }

        }
        else if (vecesJugadas >= 5 && vecesJugadas <= 9)
        {
            for (int i = 0; i < (vecesJugadas + 1); i++)
            {
                _secuencia += _letras[GenerarRandom()];
            }
        }
        else if (vecesJugadas >= 10)
        {
            for (int i = 0; i < (vecesJugadas + 1); i++)
            {
                _secuencia += _letras[GenerarRandom()];
            }


        }
    }


    private int GenerarRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_letras.Length);
        return index;
    }


    private void VaciarSecuencia()
    {
        _secuencia = String.Empty;
    }


}
