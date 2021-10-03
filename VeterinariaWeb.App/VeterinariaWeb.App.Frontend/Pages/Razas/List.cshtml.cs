using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VeterinariaWeb.App.Dominio;
using VeterinariaWeb.App.Persistencia.AppRepositorios;

namespace VeterinariaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioRazas repositorioRazas;
        public IEnumerable<Raza> Razas {get;set;}

       public ListModel(IRepositorioRazas repositorioRazas)
       {
            this.repositorioRazas=repositorioRazas;
       }
       
        public void OnGet()
        {
          Razas=repositorioRazas.GetAll();

        }
    }
}
