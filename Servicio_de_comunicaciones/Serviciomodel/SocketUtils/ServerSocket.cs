using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.SocketUtils
{
   public class ServerSocket
    {

        private int puerto;
        private Socket servidor;


        public ServerSocket(int puerto)
        {
            this.puerto = puerto;
        }

        public bool Iniciar()
        {
            try
            {
                
                this.servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                

                this.servidor.Bind(new IPEndPoint(IPAddress.Any, this.puerto));
                //3. Definir cuantos clientes atendere
                this.servidor.Listen(8);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public MedidorSocket Obtenermedidor()
        {
            try
            {
                return new MedidorSocket(this.servidor.Accept());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

