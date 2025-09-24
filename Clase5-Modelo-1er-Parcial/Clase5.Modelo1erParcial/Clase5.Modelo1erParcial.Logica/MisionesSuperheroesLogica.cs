using Clase5.Modelo1erParcial.Entidades;

namespace Clase5.Modelo1erParcial.Logica;

public interface IMisionesSuperheroesLogica
{
    void AgregarMisionSuperheroe(Mision mision);
    List<Mision> ObtenerTodos();
}
public class MisionesSuperheroesLogica : IMisionesSuperheroesLogica
{
    private static List<Mision> _misiones = new List<Mision>();

    public void AgregarMisionSuperheroe(Mision mision)
    {
        if (mision == null)
        {
            throw new ArgumentException("Mision no debe ser null.");
        }
        mision.IdMision = _misiones.Count == 0 ? 1 : _misiones.Max(o => o.IdMision) + 1;

        mision.IndiceEficiencia = Math.Round(((double)mision.CantVillanosDerrotados * 100 / (double)mision.HorasMision),2);

        _misiones.Add(mision);
    }
    public List<Mision> ObtenerTodos()
    {
        return _misiones
            .OrderBy(o => o.IdMision)
            .ToList();
    }
}
