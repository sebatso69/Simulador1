using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class Persona : LayerSuperType
    {
        [NotMapped]
        public string RutStr { get; set; }
        public int? Rut { get; set; }
        public string Dv { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string EdadReferencia { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Fono { get; set; }
        public string Nacionalidad { get; set; }
    }
}
