using Serviciomodel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DAL
{
    public interface IFolio
    {
        void RegistrarLectura(Folio l);
        List<Folio> ObtenerTrafico();
        List<Folio> ObtenerConsumo();

    }
}