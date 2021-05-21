using Serviciomodel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DAO
{
    public class MensajeDAO
    {
        List<Mensaje> mensajes = new List<Mensaje>();
         public void agregarmensaje(Mensaje m)
        {
            mensajes.Add(m);
        }
        public List<Mensaje> obtenerMensaje()
        {
            return mensajes;
        }
        public void borrarMensaje(Mensaje m)
        {
            mensajes.Remove(m);

        }
         public void editarmensaje(Mensaje m)
        {
            List<Mensaje> Mensajes = obtenerMensaje();

            for (int i = 0; i < Mensajes.Count; i++)
            {
                if (Mensajes[i].Nro_medidor.Equals(m.Nro_medidor))
                {
                    Mensajes[i].Comando = m.Comando;
                }
            }

        }
            
    }
}
