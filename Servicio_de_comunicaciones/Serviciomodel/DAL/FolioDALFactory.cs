using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DAL
{
    public class FolioDALFactory
    {
        public static IFolio createDafolio()
        {
            return FolioDALArchivo.GetinstanciaFolio();
        }
    }
}
