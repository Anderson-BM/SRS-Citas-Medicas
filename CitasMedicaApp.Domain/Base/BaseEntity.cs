using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicaApp.Domain.Base
{
    public abstract class BaseEntity
    {
        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public int? UsuarioModificacion { get; set; }

        public bool Estatus { get; set; }

    }
}
