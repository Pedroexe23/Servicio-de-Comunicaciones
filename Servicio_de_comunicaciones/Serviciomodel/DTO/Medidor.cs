using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DTO
{
    public class Medidor
    {
        private int id;
        private int tipo; 
        private DateTime fecha;
        private int estado;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
