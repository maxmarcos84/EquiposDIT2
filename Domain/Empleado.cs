using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Igg { get; set; }
        public bool EsAdmin { get; set; }
        public bool Activo { get; set; }
        public Empresa Empresa { get; set; }
    }
}
