namespace Clase1.Logica;

public class JuegoAhorcado
{
    private static List<string> palabras = new List<string>()
    {
        "programacion",
        "desarrollo",
        "computadora",
        "teclado",
        "raton"
    };
    //logica para juego ahorcado
    private string _palabraAAdivinar;
    private string _palabraOculta;
    private int _fallos = 0;
    private int _fallosPermitidos = 6;

    private void InicializarPalabraOculta(string palabraAAdivinar)
    {
        // Inicializamos la palabra oculta con guiones bajos
        _palabraOculta = new string('_', palabraAAdivinar.Length);
    }

    public void ElegirPalabra()
    {
        //seleccionar una palabra aleatoria
        Random rand = new Random();
        _palabraAAdivinar = palabras[rand.Next(palabras.Count)];

        InicializarPalabraOculta(_palabraAAdivinar);
    }

    public void ElegirPalabra(string palabraAAdivinar)
    {
        _palabraAAdivinar = palabraAAdivinar;
        InicializarPalabraOculta(_palabraAAdivinar);
    }

    public string ObtenerPalabraOculta()
    {
        //devolver la palabra oculta pero con espacios entre cada caracter
        //ejemplo: _ _ _ _ _ _ _ _
        string espacioEntreCaracteres = string.Join(" ", _palabraOculta.ToCharArray());
        return espacioEntreCaracteres;
    }
    public int ObtenerFallos()
    {
        return _fallos;
    }

    //existe letra en palabra
    public bool ExisteLetra(char letra)
    {
        return _palabraAAdivinar.Contains(letra);
    }

    //fallos permitidos
    public int FallosPermitidos()
    {
        return _fallosPermitidos;
    }

    //Adivinar letra
    public bool AdivinarLetra(char letra)
    {
        if (ExisteLetra(letra))
        {
            for (int i = 0; i < _palabraAAdivinar.Length; i++)
            {
                if (_palabraAAdivinar[i] == letra)
                {
                    _palabraOculta = _palabraOculta.Remove(i, 1).Insert(i, letra.ToString());
                }
            }

            return true;
        }
        else
        {
            _fallos++;
            return false;
        }
    }

    //Verificar si el juego ha terminado
    public bool JuegoTerminado()
    {
        return _fallos >= _fallosPermitidos || !_palabraOculta.Contains('_');
    }
}
