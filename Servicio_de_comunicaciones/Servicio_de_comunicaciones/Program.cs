using Servicio_de_comunicaciones.hilo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Servicio_de_comunicaciones
{
    partial class Program
    {
        /*private static void Timer_elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);


        }*/
        static void Main(string[] args)
        {
            // Timer timers = new Timer(1000);
            //timers.Elapsed += Timer_elapsed;
            //timers.Start();
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            HiloServer hilosserver = new HiloServer(puerto);
            Thread t = new Thread(new ThreadStart(hilosserver.Ejecutar));
            t.IsBackground = true;
            t.Start();
            while (Menu()) ;
        }
    }
}
