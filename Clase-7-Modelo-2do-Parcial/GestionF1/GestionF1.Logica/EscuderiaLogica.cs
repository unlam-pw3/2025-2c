using GestionF1.Data.Entidades;

namespace GestionF1.Logica;

public interface IEscuderiaLogica
{
    List<Escuderium> ObtenerEscuderias();
}

public class EscuderiaLogica : IEscuderiaLogica
{
    private GestionF1Context _context { get; set; }
    public EscuderiaLogica(GestionF1Context context)
    {
        _context = context;
    }
    public List<Escuderium> ObtenerEscuderias()
    {
        return _context.Escuderia
            .OrderBy(o => o.NombreEscuderia)
            .ToList();
    }
}

