using GestionF1.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GestionF1.Logica;

public interface IPilotoLogica
{
    void AgregarPiloto(Piloto piloto);
    void EliminarPiloto(int idPiloto);
    List<Piloto> ObtnenerTodosLosPilotos();
    List<Piloto> ObtenerPilotosPorEscuderia(int idEscuderia);
}

public class PilotoLogica : IPilotoLogica
{
    private GestionF1Context _context { get; set; }
    public PilotoLogica(GestionF1Context context)
    {
        _context = context;
    }
    public void AgregarPiloto(Piloto piloto)
    {
        _context.Pilotos.Add(piloto);
        _context.SaveChanges();
    }

    public void EliminarPiloto(int idPiloto)
    {
        var piloto = _context.Pilotos.Find(idPiloto);
        if (piloto != null)
        {
            piloto.Eliminado = true;
            _context.SaveChanges();
        }
    }

    public List<Piloto> ObtnenerTodosLosPilotos()
    {
        return _context.Pilotos
            .Include(p=> p.IdEscuderiaNavigation)
            .Where(p => !p.Eliminado)
            .ToList();
    }

    public List<Piloto> ObtenerPilotosPorEscuderia(int idEscuderia)
    {
        return _context.Pilotos
            .Include(p=> p.IdEscuderiaNavigation)
            .Where(p => p.IdEscuderia == idEscuderia && 
                    !p.Eliminado)
            .ToList();
    }



}
