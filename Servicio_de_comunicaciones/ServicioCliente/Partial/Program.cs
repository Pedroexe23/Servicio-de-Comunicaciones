using Serviciomodel.DAL;
using Serviciomodel.DAO;
using Serviciomodel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioCliente
{
    public partial class Program
    {
        static MensajeDAO dao = new MensajeDAO();
        static MedidorDAL dal = new MedidorDAL();

        static void ingresar_lectura()
        {
            List<Mensaje> mensajes = dao.obtenerMensaje();
            List<Medidor> medidores = dal.VerMedidor();
            for (int i = 0; i < medidores.Count; i++)
            {
                if (medidores[i].Tipo == 0)
                {
                    Console.WriteLine("id de medidor:{0} tipo: Trafico", medidores[i]);
                }
                else
                {
                    Console.WriteLine("id de medidor:{0} tipo: Consumo", medidores[i]);
                }


            }

            Console.WriteLine("Seleccione el numero de la id ");
            string id = Console.ReadLine().Trim();
            string tipo="";
            Console.WriteLine("Seleccione un numero para su tipo de medidor\n" +
                " 1. trafico\n" +
                " 2. consumo");

            switch (Console.ReadLine().Trim())
            {
                case "1":
                    tipo = "trafico";
                    break;
                case "2":
                    tipo = "consumo";
                    break;
                default:
                    Console.WriteLine("ingrese el numero nuevamente");
                    break;
            }
            Console.WriteLine("ingrese Año");
            string anio =Console.ReadLine().Trim();
            int dia=0, mes=0;
            string fecha;
            Console.WriteLine("ingrese el numero de mes");
            try
            {
                mes = Convert.ToInt32(Console.ReadLine().Trim());
            }
            catch (Exception)
            {
                Console.WriteLine("ingrese nuevamente");
                
            }
            Console.WriteLine("ingrese el numero del dia");
            try
            {
                dia = Convert.ToInt32(Console.ReadLine().Trim());
            }
            catch (Exception)
            {
                Console.WriteLine("ingrese nuevamente");

            }
             fecha= anio + "-" + mes.ToString() + "-" + dia.ToString();
            Mensaje m = new Mensaje() {
                Nro_medidor = id,
                Tipo = tipo,
                Fecha = fecha
            };
            int r=0;
            for (int i = 0; i ==30; i++)
            {
                if (r>=1)
                {
                    break;
                }
                else
                {
                    int j = 0;
                    Console.WriteLine(i + ":" + j);


                    for (j = 0; j == 60; j++)
                    {
                        Console.WriteLine(i + ":" + j);

                    }
                    for (int o = 0; o < mensajes.Count; o++)
                    {
                        if (m.Fecha == mensajes[o].Fecha && m.Fecha == mensajes[o].Fecha && mensajes[o].Comando == "wait")
                        {
                            r = 1;
                            m.Comando = mensajes[o].Comando;
                        }
                        else if (m.Fecha == mensajes[o].Fecha && m.Fecha == mensajes[o].Fecha && mensajes[o].Comando == "error")
                        {
                            r = 1;
                            m.Comando = mensajes[o].Comando;
                        }
                        else
                        {
                            m.Comando = "error";
                        }

                    }
                }
             
            }

            if (m.Comando=="wait")
            {
                string valor;
                int valorI=0;
                do
                {
                    Console.WriteLine("ingrese el valor");
                    valor = Console.ReadLine().Trim();
                    try
                    {
                        valorI = Convert.ToInt32(valor);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ingrese el valor por numero");
                        
                    }
                } while (valor==string.Empty || valorI > 1000 || valorI<0);

                Console.WriteLine("ingrese el numero del estado/n " +
                    "-1. Error de lectura" +
                    " 0. OK" +
                    " 1. punto de carga lleno" +
                    " 2. Requiere mantencion preventiva");
                string estado;

                switch (Console.ReadLine())
                {
                    case "-1":
                        estado = "-1";
                        break;
                    case "0":
                        estado = "0";
                        break;
                    case "1":
                        estado = "1";
                        break;
                    case "2":
                        estado = "2";
                        break;
                    default:
                        Console.WriteLine("ingrese nuevamente");
                        break;
                }

               


            }
            else
            {

            }



        }

        static bool menu()
        {
            bool continuar = true;
            Console.WriteLine("Bienvenido Usuario\n" +
                "cuales sin sus ordenes seleccione un numero\n" +
                "1. ingresar Lectura\n" +
                "0. salir  ");
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    ingresar_lectura();
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
