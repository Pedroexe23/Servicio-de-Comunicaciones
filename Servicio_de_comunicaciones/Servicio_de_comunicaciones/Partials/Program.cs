using Serviciomodel.DAO;
using Serviciomodel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_de_comunicaciones
{
    public partial class Program
    {
        static MensajeDAO dao = new MensajeDAO();


        public static void Revisarlecturas()
        {
            bool continuar = true;
            while (continuar == true)
            {
                Console.Clear();
                Mensaje m = new Mensaje();
                List<Mensaje> mensajes = dao.obtenerMensaje();
                if (mensajes == null)
                {
                    Console.WriteLine("No hay peticiones");
                }
                else
                {
                    for (int i = 0; i < mensajes.Count; i++)
                    {

                        Console.WriteLine("Fecha:{0} | numero_medidor:{1} | tipo: {2} ", mensajes[i].Fecha, mensajes[i].Nro_medidor, mensajes[i].Tipo);
                        Console.WriteLine("seleccione  comando\n " +
                            "si tiene consulta presione h");
                        switch (Console.ReadLine().ToLower().Trim())
                        {
                            case "h":
                                Console.WriteLine("Wait para la actualizacion\n" +
                                    "error comando de peticion erroneo");
                                break;
                            case "wait":
                                
                                m.Nro_medidor = mensajes[i].Nro_medidor;
                                m.Fecha = mensajes[i].Fecha;
                                m.Tipo = mensajes[i].Tipo;
                                m.Comando = "wait";

                                break;
                            case "error":
                                
                                m.Nro_medidor = mensajes[i].Nro_medidor;
                                m.Fecha = mensajes[i].Fecha;
                                m.Tipo = mensajes[i].Tipo;
                                m.Comando = "error";
                                break;
                            default:
                                Console.WriteLine("ERROR de comando ingrese nuevamente");
                                break;
                        }

                    }
                }



            }

        }

        public static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Bienvenido Usuario\n" +
                "cuales sin sus ordenes seleccione un numero\n" +
                "4. revisar lecturas\n " +
                "0. salir  ");
            string n = Console.ReadLine();
            switch (n)
            {

                case "4":
                    Revisarlecturas();
                    break;
                case "0":
                    continuar = false;
                    return continuar;

                default:
                    Console.WriteLine("ingrese  nuevamente ");

                    break;
            }

            return continuar;

        }


    }
}
