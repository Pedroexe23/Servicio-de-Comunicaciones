using Serviciomodel.DAL;
using Serviciomodel.SocketUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioCliente.Hilo
{
    class HiloMedidor
    {
        private MedidorSocket medidorSocket;
        private IFolio foliodal = FolioDALFactory.createDafolio();

        public HiloMedidor(MedidorSocket medidorSocket)
        {
            this.medidorSocket = medidorSocket;
        }
        public void ejecutar()
        {

        }

    }
}
