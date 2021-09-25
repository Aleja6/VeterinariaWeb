using System;

namespace VeterinariaWeb.App.Dominio
{
    public class HistorialClinico
    {
        public int Id { get; set; }

        public DateTime Fecha_Apertura { get; set; }

        public Propietario Propietario_Historial { get; set; }

        public Mascota Mascota_Historial { get; set; }

        public Empresa Empresa_Historial { get; set; }
    }
}
