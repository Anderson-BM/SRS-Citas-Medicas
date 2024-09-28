using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities
{
    public sealed class Horario : BaseEntity
    {
        public int dia { get; set; }    

        public DateTime HoraInicio { get; set; }

        public DateTime HoraFin { get; set; }
    }
}
