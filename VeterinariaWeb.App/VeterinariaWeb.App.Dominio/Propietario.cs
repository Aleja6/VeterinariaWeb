using System;

namespace VeterinariaWeb.App.Dominio
{
    public class Propietario
    {
        public int Id { get; set; }

        public string TipoIdentificacion { get; set; }

        public int NumeroIdentificacion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }
    }
}
