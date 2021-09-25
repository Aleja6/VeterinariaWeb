using System;

namespace VeterinariaWeb.App.Dominio
{
    public class Empresa
    {
        public int Id { get; set; }

        public int Nit { get; set; }

        public string RazonSocial { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public string CorreoElectronico { get; set; }
    }
}
