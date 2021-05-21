using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DTO
{
    public class MConsumo : Medidor
    {
       
        private double kwhConsumidos;

        
        public double KwhConsumidos {
            get => kwhConsumidos;
            set => kwhConsumidos = value;
        }
       

        private double obtenerKwhConsumido()
        {
            kwhConsumidos += kwhConsumidos;
            return kwhConsumidos;
        }

        
    }
}
