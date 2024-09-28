using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities
{
    public sealed class Agenda : BaseEntity
    {
        public List<Cita> Citas { get; set; }

        public List<Horario> DisponibilidadDoctor { get; set; }
    }
}
