using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
		public int Id { get; set; }
		public string Username { get; set; }
		public string Mail { get; set; }
		public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? NumIntentos { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? UltimoLogin { get; set; }
        public Rol Rol { get; set; }
        public Empresa Empresa { get; set; }
    }
}
