using System;
using System.Collections.Generic;

namespace Clase6.EF_BusquedaTesoro.Data.Entidades;

public partial class Cazatesoro
{
    public int IdCazatesoro { get; set; }

    public string Nick { get; set; } = null!;

    public string? AvatarUrl { get; set; }
}
