using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DTO
{
    public class MTrafico: Medidor
    {
        private int cantAuto;

        public int CantAuto { get => cantAuto; set => cantAuto = value; }

        public void obtenerCantAuto()
        {
            CantAuto += CantAuto;
        }
    }
}
