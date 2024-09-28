using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities
{
    public sealed class Cita : BaseEntity
    {
        public int IdCita { get; set; }

        public Paciente Paciente { get; set; }

        public Doctor Doctor { get; set; }

        public DateTime FechaHora { get; set; } 

        public string Estado  { get; set; } 
    }
}
