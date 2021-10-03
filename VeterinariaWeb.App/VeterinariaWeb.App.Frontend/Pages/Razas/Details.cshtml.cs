using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VeterinariaWeb.App.Persistencia.AppRepositorios;
using VeterinariaWeb.App.Dominio;

namespace VeterinariaWeb.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioRazas repositorioRazas;

        public Raza Raza {get; set;}

        public DetailsModel(IRepositorioRazas repositorioRazas)
        {
            this.repositorioRazas = repositorioRazas;
        }

        public IActionResult OnGet(int razaId)
        {
            Raza = repositorioRazas.GetRazaPorId(razaId);
            if(Raza==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
