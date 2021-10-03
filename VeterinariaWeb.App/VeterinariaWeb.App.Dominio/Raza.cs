using System;
using System.ComponentModel.DataAnnotations;

namespace VeterinariaWeb.App.Dominio
{
    public class Raza
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        
        public string Nombre { get; set; }
    }
}
