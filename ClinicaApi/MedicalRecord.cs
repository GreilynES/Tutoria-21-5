using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string HistorialC { get; set; }
        public string Alergias { get; set; }
        public string GrupoSanguineo { get; set; }
        public User? User { get; set; }

    }
}
