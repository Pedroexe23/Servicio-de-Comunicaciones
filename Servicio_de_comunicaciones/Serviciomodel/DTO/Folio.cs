using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DTO
{
     public class Folio
    {
        private DateTime fecha;
        private String valor;
        private int tipo;
        private int estado;
        private int id_medidor;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Valor { get => valor; set => valor = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Id_medidor { get => id_medidor; set => id_medidor = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
