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
    public class EditModel : PageModel
    {
        private readonly IRepositorioRazas repositorioRazas;

        [BindProperty]
        public Raza Raza { get; set; }

        public EditModel(IRepositorioRazas repositorioRazas)
        {
            this.repositorioRazas = repositorioRazas;
        }

        public IActionResult OnGet(int? razaId)
        {
            if (razaId.HasValue)
            {
                Raza = repositorioRazas.GetRazaPorId(razaId.Value);
            }
            else
            {
                Raza = new Raza();
            }
            if (Raza == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Raza.Id>0)
            {
                Raza = repositorioRazas.Update(Raza);
            }
            else
            {
                repositorioRazas.Add(Raza);
            }
            return Page();
        }
    }
}
