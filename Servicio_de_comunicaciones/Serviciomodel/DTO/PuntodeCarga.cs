using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DTO
{
    public class PuntodeCarga
    {
        private int id;
        private int tipo;
        private int capmax;
        DateTime fechaVen;

        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Capmax { get => capmax; set => capmax = value; }
        public DateTime FechaVen { get => fechaVen; set => fechaVen = value; }
    }
}
