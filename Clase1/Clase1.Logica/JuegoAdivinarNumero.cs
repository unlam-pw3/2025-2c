using System;

namespace Clase1.Logica;

public class JuegoAdivinarNumero
{
    private int _numeroAAdivinar;
    private int _intentos;

    public void IniciarJuego()
    {
        Random rand = new Random();
        _numeroAAdivinar = rand.Next(1, 101);
        _intentos = 0;
    }

    public int Intentos 
    {
        get { return _intentos;} 
    }

    public string EvaluarIntento(int numero)
    {

        if (numero < 1 || numero > 100)
        {
            return "Número inválido, debe estar entre 1 y 100";
        }


        _intentos++;
        int diferencia = Math.Abs(_numeroAAdivinar - numero);

        if (diferencia == 0)
            return "Correcto";
        else if (diferencia <= 5)
            return "Muy caliente";
        else if (diferencia <= 15)
            return "Caliente";
        else if (diferencia <= 30)
            return "Tibio";
        else
            return "Frio";

    }

    public int NumeroObjetivo
    {
        get { return _numeroAAdivinar; }
    }

    public void SetNumeroObjetivo(int numero)
    {
        _numeroAAdivinar = numero;
    }

}
