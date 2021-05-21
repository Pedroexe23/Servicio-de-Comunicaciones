using Serviciomodel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DAL
{
     public interface IMedidor
    {
        void ObtenerMedidor(Medidor m );
        List<Medidor> VerMedidor();   

    }
}
