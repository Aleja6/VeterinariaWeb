using System;

namespace VeterinariaWeb.App.Dominio
{
    public class Veterinario
    {
        public int Id { get; set; }

        public string Tipo_Identificacion { get; set; }

        public int Numero_Identificacion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int Telefono { get; set; }

        public int Tarjeta_profesional { get; set; }
    }
}
