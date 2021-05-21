using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.SocketUtils
{
    public class MedidorSocket
    {
        private Socket coMedidor;
        private StreamReader reader;
        private StreamWriter writer;

        public MedidorSocket(Socket coMedidor)
        {
            this.coMedidor = coMedidor;
            Stream stream = new NetworkStream(this.coMedidor);
            this.writer = new StreamWriter(stream);
            this.reader = new StreamReader(stream);
        }

        public bool Escribir(String mensaje)
        {
            try
            {
                this.writer.WriteLine(mensaje);
                this.writer.Flush();
                return true;
            }
            catch (IOException ex)
            {
                return false;
            }
        }

        public string Leer()
        {
            try
            {
                return this.reader.ReadLine().Trim();
            }
            catch (IOException ex)
            {
                return null;
            }
        }

        public void CerrarConexion()
        {
            this.coMedidor.Close();
        }

    }
}
