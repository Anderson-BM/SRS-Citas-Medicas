using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Base;

namespace CitasMedicaApp.Domain.Entities
{
    public sealed class Paciente : BaseEntity
    {
        public int IdPaciente { get; set; } 

        public string Nombre { get; set; }  

        public string Direccion { get; set; }   

        public string Telefono { get; set; }    

        public string CorreoElectronico { get; set; }

        public string contrasena { get; set; }
    }
}
