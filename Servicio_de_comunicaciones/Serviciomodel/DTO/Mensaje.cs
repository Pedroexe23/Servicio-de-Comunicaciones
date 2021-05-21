using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DTO
{
    public class Mensaje
    {
        private string fecha;
        private string nro_medidor;
        private string tipo;
        private string comando;

        public string Fecha { get => fecha; set => fecha = value; }
        public string Nro_medidor { get => nro_medidor; set => nro_medidor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Comando { get => comando; set => comando = value; }
    }
}
