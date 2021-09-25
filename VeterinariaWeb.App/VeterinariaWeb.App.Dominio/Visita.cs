using System;

namespace VeterinariaWeb.App.Dominio
{
    public class Visita
    {
        public int Id { get; set; }

        public DateTime FechaHora { get; set; }

        public int Temperatura { get; set; }

        public int Peso { get; set; }

        public int FrecuenciaRespiratoria { get; set; }

        public int FrecuenciaCardiaca { get; set; }

        public string EstadoAnimo { get; set; }

        public string Recomendaciones { get; set; }

        public Veterinario VeterinarioVisita { get; set; }
    }
}
