using Serviciomodel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DAO
{
    class PuntoCargaDAO
    {
        List<PuntodeCarga> puntodecargas = new List<PuntodeCarga>();
        public void Lectura_Temporal(PuntodeCarga p )
        {
            puntodecargas.Add(p);
        }
        public List<PuntodeCarga> GetPuntodeCargas()
        {
            return puntodecargas ;
        }
        public void eliminacion(PuntodeCarga p)
        {

            puntodecargas.Remove(p);

        }
        public void ActualizarPCarga(PuntodeCarga p)
        {
            List<PuntodeCarga> actualizar = GetPuntodeCargas();
            for (int i = 0; i < actualizar.Count(); i++)
            {
                if (actualizar[i].Id==p.Id)
                {
                    actualizar[i].Capmax = p.Capmax;
                    actualizar[i].FechaVen = p.FechaVen;
                }
                else
                {
                    Console.WriteLine("punto de carga no encontrado");
                }
            }


        }
    }
}
