using Clase6.EF_BusquedaTesoro.Data.Entidades;

namespace Clase6.EF_BusquedaTesoro.Logica;

public interface ITesorosLogica
{
    void AgregarTesoro(Tesoro tesoro);
    void EliminarTesoro(int idTesoro);
    List<Tesoro> ObtenerTesoros();

    Tesoro ObtenerTesoroPorId(int idTesoro);
    void ActualizarTesoro(Tesoro tesoro);
}
public class TesorosLogica : ITesorosLogica
{
    private readonly Pw320252cBusquedaTesoroContext _context;
    public TesorosLogica(Pw320252cBusquedaTesoroContext context)
    {
        _context = context;
    }
    public void AgregarTesoro(Tesoro tesoro)
    {
        _context.Tesoros.Add(tesoro);
        _context.SaveChanges();
    }
    public void EliminarTesoro(int idTesoro)
    {
        var tesoro = _context.Tesoros.Find(idTesoro);
        if (tesoro != null)
        {
            _context.Tesoros.Remove(tesoro);
            _context.SaveChanges();
        }
    }
    public List<Tesoro> ObtenerTesoros()
    {
        return _context.Tesoros.ToList();
    }

    public Tesoro ObtenerTesoroPorId(int idTesoro)
    {
        return _context.Tesoros.Find(idTesoro);
    }
    public void ActualizarTesoro(Tesoro tesoro)
    {
        _context.Tesoros.Update(tesoro);
        _context.SaveChanges();
    }
}

