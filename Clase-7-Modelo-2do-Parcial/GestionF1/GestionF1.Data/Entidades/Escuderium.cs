using System;
using System.Collections.Generic;

namespace GestionF1.Data.Entidades;

public partial class Escuderium
{
    public int IdEscuderia { get; set; }

    public string NombreEscuderia { get; set; } = null!;

    public virtual ICollection<Piloto> Pilotos { get; set; } = new List<Piloto>();
}
