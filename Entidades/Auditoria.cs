using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auditoria
    {
        public int Id { get; set; }
        public Empresa EmpresaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public Usuario UsuarioId { get; set; }


    }
}
