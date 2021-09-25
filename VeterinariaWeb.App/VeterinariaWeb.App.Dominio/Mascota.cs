using System;

namespace VeterinariaWeb.App.Dominio
{
    public class Mascota
    {
        public int id { get; set; }

        public string Nombre { get; set; }

        public string Color { get; set; }

        public Genero Genero { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Raza RazaMascota { get; set; }
    }
}
