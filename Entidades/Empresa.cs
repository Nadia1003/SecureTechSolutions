using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa //mi cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string? Descripcion { get; set; }
        public string ContactoNombre { get; set; }
        public string ContactoTelefono { get; set; }
        public string ContactoMail { get; set; }
        public string Telefono { get; set; }
        public int Cuit { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }
    }
}
