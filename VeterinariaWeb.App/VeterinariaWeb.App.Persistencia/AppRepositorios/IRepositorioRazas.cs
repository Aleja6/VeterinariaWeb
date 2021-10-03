using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.App.Dominio;

namespace VeterinariaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRazas
    {
        IEnumerable<Raza> GetAll();

        IEnumerable<Raza> GetRazasPorFiltro(string filtro);

        Raza GetRazaPorId(int razaID);

        Raza Update(Raza razaActualizado);

        Raza Add(Raza nuevaRaza);
    }
}
