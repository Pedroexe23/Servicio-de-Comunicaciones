using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DAL
{
   public class MedidorDALFactory
    {
        public static IMedidor createdalMedidor()
        {
            return MedidorDAL.GetInstanciaMedidor();
        }
    }
}
