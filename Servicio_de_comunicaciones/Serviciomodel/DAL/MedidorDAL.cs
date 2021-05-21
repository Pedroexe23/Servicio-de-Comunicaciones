using Serviciomodel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviciomodel.DAL
{
    public class MedidorDAL : IMedidor
    {
        static List<Medidor> medidores = new List<Medidor>() {
        new Medidor(){Id=124,Fecha=new DateTime(2020,3,12),Tipo=1, Estado=0},
        new Medidor(){Id=156,Fecha=new DateTime(2020,2,06),Tipo=0, Estado=0},
        new Medidor(){Id=193,Fecha=new DateTime(2020,4,27),Tipo=0, Estado=0},
        new Medidor(){Id=123,Fecha=new DateTime(2020,1,23),Tipo=1, Estado=0},
        new Medidor(){Id=452,Fecha=new DateTime(2020,12,6),Tipo=1, Estado=0},
        new Medidor(){Id=133,Fecha=new DateTime(2020,8,29),Tipo=0, Estado=0},
        new Medidor(){Id=165,Fecha=new DateTime(2020,7,19),Tipo=0, Estado=0},
        new Medidor(){Id=178,Fecha=new DateTime(2020,5,25),Tipo=1, Estado=0}
        };


        public MedidorDAL()
        {

        }


        private static IMedidor medidorInstancia;
        public static IMedidor GetInstanciaMedidor()
        {
            if (medidorInstancia== null )
            
                medidorInstancia = new MedidorDAL();
                return medidorInstancia;
            
           
        }
       
        public void ObtenerMedidor(Medidor m)
        {
            for (int i = 0; i < medidores.Count(); i++)
            {

                if (m.Id == medidores[i].Id)
                {
                    medidores[i].Estado = 1;
                }
            }
        }

        public List<Medidor> VerMedidor()
        {
            return medidores;
        }
    }
}
