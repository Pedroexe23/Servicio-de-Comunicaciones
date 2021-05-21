using Serviciomodel.SocketUtils;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Servicio_de_comunicaciones.hilo
{
   public  class HiloServer
    {
        private int puerto;
        private ServerSocket Server;
         public HiloServer(int puerto)
        {
            this.puerto = puerto;
        }
        public void Ejecutar()
        {
            Server= new ServerSocket(puerto);
            Console.WriteLine("iniciando server en Puerto {0}", puerto);
            if (Server.Iniciar())
            {
                Console.WriteLine("Servidor iniciado");
                while (true)
                {
                    Console.WriteLine("Experando Clientes..");
                    MedidorSocket medidorSocket = Server.Obtenermedidor();
                }
            }

        }



    }
}
