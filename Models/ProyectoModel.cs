using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeProyectos.Models
{
    class ProyectoModel
    {
        public int idProyecto { set; get; }
        public string NombreProyecto { set; get; }
        public string TipoProyecto { set; get; }
        public string CiudadProyecto { set; get; }
        public DateTime FechaInicio { set; get; }
        public DateTime FechaFin { set; get; }

        public override string ToString()
        {
            return NombreProyecto;
        }
    }
}
