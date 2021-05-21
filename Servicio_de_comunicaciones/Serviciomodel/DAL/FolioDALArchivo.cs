using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serviciomodel.DTO;

namespace Serviciomodel.DAL
{
    public class FolioDALArchivo : IFolio
    { 
        private FolioDALArchivo()
        {

        }
        private static IFolio instancia;
        public static IFolio GetinstanciaFolio()
        {
            if (instancia == null)
                instancia = new FolioDALArchivo();
            return instancia; 
        }
    
        private string ArchivoConsumo = Directory.GetCurrentDirectory()
            + Path.DirectorySeparatorChar + " consumos.txt";

        private string ArchivoTrafico = Directory.GetCurrentDirectory()
            + Path.DirectorySeparatorChar + " trafico.txt";


        public List<Folio> ObtenerConsumo()
        {
            List<Folio> lecturas = new List<Folio>();
            
            try
            {
                using (StreamReader reader = new StreamReader(ArchivoConsumo))
                {
                    string texto = null;
                    do
                    {
                        texto = reader.ReadLine();
                        if (texto!=null)
                        {
                            string[] textoArray = texto.Split(';');
                            
                                Folio l = new Folio()
                                {
                                    Fecha = Convert.ToDateTime(textoArray[0]),
                                    Valor = textoArray[1],
                                    Tipo = Convert.ToInt32(textoArray[2]),
                                    Estado = Convert.ToInt32(textoArray[3]),
                                    Id_medidor= Convert.ToInt32(textoArray[4])

                                };
                                lecturas.Add(l);
                            
                        }

                    } while (texto!=null);

                }

            }
            catch (IOException e)
            {
                lecturas = null;
            }
            return lecturas;
        }

        public List<Folio> ObtenerTrafico()
        {
            throw new NotImplementedException();
        }

        

        public void RegistrarLectura(Folio l)
        {
            if (l.Tipo==0)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(ArchivoConsumo, true))
                    {
                        writer.WriteLine(l);
                        writer.Flush();
                    }
                }
                catch (IOException)
                {

                    throw;
                }
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(ArchivoTrafico, true))
                    {
                        writer.WriteLine(l);
                        writer.Flush();
                    }
                }
                catch (IOException)
                {

                    throw;
                }
            }
        }
    }
}
