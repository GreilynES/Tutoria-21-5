using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class User
    {
        public int Id { get; set; }

        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }

        //relationship
        public Clinic? Clinic { get; set; }
        public MedicalRecord? MedicalRecord { get; set; }
    }
}
