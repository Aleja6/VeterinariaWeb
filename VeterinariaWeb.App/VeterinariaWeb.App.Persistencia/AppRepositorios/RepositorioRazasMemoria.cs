using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaWeb.App.Dominio;

namespace VeterinariaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioRazasMemoria : IRepositorioRazas
    {
        List<Raza> razas;

        public RepositorioRazasMemoria()
        {
            razas =
                new List<Raza>()
                {
                    new Raza { Id = 1, Nombre = "Pastor Aleman" },
                    new Raza { Id = 2, Nombre = "Pomerania" },
                    new Raza { Id = 3, Nombre = "Poodle" }
                };
        }

        public Raza Add(Raza nuevaRaza)
        {
            nuevaRaza.Id = razas.Max(r => r.Id) + 1;
            razas.Add (nuevaRaza);
            return nuevaRaza;
        }

        public IEnumerable<Raza> GetAll()
        {
            return razas;
        }

        public Raza GetRazaPorId(int razaId)
        {
            return razas.SingleOrDefault(s => s.Id == razaId);
        }

        public IEnumerable<Raza> GetRazasPorFiltro(string filtro = null)
        {
            var razas = GetAll();
            if (razas != null)
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    razas = razas.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return razas;
        }

        public Raza Update(Raza razaActualizado)
        {
            var raza = razas.SingleOrDefault(r => r.Id == razaActualizado.Id);
            if (raza != null)
            {
                raza.Nombre = razaActualizado.Nombre;
            }
            return raza;
        }
    }
}
