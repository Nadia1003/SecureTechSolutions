using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evidencia
    {
        public int Id { get; set; }
        public string UrlArchivo { get; set; }
        public string Descripcion { get; set; }
        public Hallazgo Hallazgo { get; set; }
    }
}
