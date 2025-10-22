using System;
using System.Collections.Generic;

namespace Clase6.EF_BusquedaTesoro.Data.Entidades;

public partial class Tesoro
{
    public int IdTesoro { get; set; }

    public string Nombre { get; set; } = null!;

    public string ImagenUrl { get; set; } = null!;

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public int? Valor { get; set; }
}
