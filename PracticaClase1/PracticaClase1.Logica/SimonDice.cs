using System.Drawing;
namespace PracticaClase1.Logica;

public class SimonDice
{
    // Disponibilizar las 4 flechas del teclado en un arraylist, todo dentro de un atributo privado y estatico 
    private static string[] _letras = { "a", "d", "p", "w" };

    private static int _cantidadDeJuegos;

    // Atributo privado en un arraylist que guarde la secuencia de flechas
    private List<string> _secuencia;

    // Con esta sintaxis solo tengo la posibilidad de lectura para obtener la secuencia
    public List<string> Secuencia => _secuencia;

    public SimonDice()
    {
        _cantidadDeJuegos = 0;
        _secuencia = new List<string>();
    }

    public void IniciarJuego()
    {
        _cantidadDeJuegos++;
        VaciarSecuencia();
        AgregarFlechaAleatoriaALaSecuencia(_cantidadDeJuegos);
    }

    private void AgregarFlechaAleatoriaALaSecuencia(int vecesJugadas)
    {

        if (vecesJugadas >= 1 && vecesJugadas <= 4)
        {
            for (int i = 0; i < (vecesJugadas + 1); i++)
            {
                _secuencia.Add(_letras[GenerarRandom()] + " ");
            }

        }
        else if (vecesJugadas >= 5 && vecesJugadas <= 9)
        {
            for (int i = 0; i < (vecesJugadas + 1); i++)
            {
                _secuencia.Add(_letras[GenerarRandom()] + " ");
            }
        }
        else if (vecesJugadas >= 10)
        {
            for (int i = 0; i < (vecesJugadas + 1); i++)
            {
                _secuencia.Add(_letras[GenerarRandom()] + " ");
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
        _secuencia.Clear();
    }

    public string ObtenerSecuencia()
    {
        return string.Join(" ", _secuencia);
    }

    // REESCRIBIR EL CRITERIO DE VERIFICACION DE LA SECUENCIA
    public bool VerificarSecuencia(List<string> secuenciaUsuario)
    {
        if (secuenciaUsuario.Count != _secuencia.Count)
        {
            return false;
        }

        for (int i = 0; i < _secuencia.Count; i++)
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

}
