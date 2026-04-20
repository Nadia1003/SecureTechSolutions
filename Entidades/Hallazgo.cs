using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hallazgo
    {
        //problemas detectados en una inspección/auditoría
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string NivelRiesgo { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
        public DateTime FechaDeteccion { get; set; }
        public DateTime FechaCierre { get; set; }
        public string Observacion { get; set; }
        public string Sector { get; set; }
        public Usuario Usuario { get; set; } //Resaponsable
        public Auditoria Auditoria { get; set; }
        public List<Evidencia> ListaEvidencia { get; set; }
        
    }
}
