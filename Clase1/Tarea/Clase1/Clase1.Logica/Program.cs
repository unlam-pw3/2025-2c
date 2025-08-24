namespace Clase1.Logica;
public class JuegoAdivinarNumero
{
    private int numeroSecreto;
    public JuegoAdivinarNumero()
    {
        Random rand = new Random();
        numeroSecreto = rand.Next(1, 101);
    }

    //Para testear
    public void ElegirNumeroSecreto(int numero)
    {
        numeroSecreto = numero;
    }
    public string Adivinar(int numero)
    {
        int diferencia = Math.Abs(numero - numeroSecreto);

        if (diferencia > 30)
        {
            return "Frío";
        }
        if (diferencia >= 16 && diferencia <= 30)
        {
            return "Tibio";
        }
        if (diferencia >= 6 && diferencia <= 15)
        {
            return "Caliente";
        }
        if (diferencia <= 5 && diferencia >= 1)
        {
            return "Muy caliente";
        }
    
        return $"Adivinaste!!!";
    }
}
