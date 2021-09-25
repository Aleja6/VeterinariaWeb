using System;

namespace VeterinariaWeb.App.Dominio
{
    public class DetalleHistorial
    {
        public int Id { get; set; }

        public HistorialClinico HistDetalleHist { get; set; }

        public Visita VisitaDetalleHist { get; set; }
    }
}
