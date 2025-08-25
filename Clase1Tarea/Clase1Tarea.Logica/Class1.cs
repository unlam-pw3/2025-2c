namespace Clase1Tarea.Logica;

public class JuegoAdivinar
{
    private int numeroSecreto;
    private int intentos = 0;
    private int intentosPermitidos = 6;

    public JuegoAdivinar()
    {
        Random random = new Random();
        numeroSecreto = random.Next(1, 101);
    }

    public JuegoAdivinar(int numero) // Constructor para pruebas
    {
        numeroSecreto = numero;
    }

    public string EvaluarIntento(int intento)
    {
        intentos++;
        int diferencia = Math.Abs(numeroSecreto - intento);

        string feedback = ObtenerFeedback(diferencia);

        if (diferencia == 0 || !PuedeSeguirIntentando())
        {
            return feedback;
        }

        string proximidad = ObtenerProximidad(intento);

        return $"{feedback}, intenta un número {proximidad}.";
    }

    public bool PuedeSeguirIntentando()
    {
        return intentos < intentosPermitidos;
    }

    private string ObtenerFeedback(int diferencia)
    {
        if (!PuedeSeguirIntentando())
        {
            return $"Se acabaron los intentos. ¡Suerte la próxima! El número era {numeroSecreto}.";
        }

        if (diferencia == 0) return "¡Felicitaciones, ganaste!";
        if (diferencia <= 5) return "Muy caliente";
        if (diferencia <= 15) return "Caliente";
        if (diferencia <= 30) return "Tibio";
        return "Frío";
    }

    public string ObtenerProximidad(int intento)
    {
        if (intento < numeroSecreto) return "más alto";
        return "más bajo";
    }

    public int IntentosRestantes()
    {
        return intentosPermitidos - intentos;
    }

    public bool EsNumeroCorrecto(int intento)
    {
        return intento == numeroSecreto;
    }

}
