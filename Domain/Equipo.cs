using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Eq { get; set; }
        public string ServiceTag { get; set; }
        public Categoria_Equipo CategoriaEquipo { get; set; }
        public bool Disponible { get; set; }
    }
}
