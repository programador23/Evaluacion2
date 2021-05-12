using MedidorTraficoyMedidorConsumoModel.DAL;
using MedidorTraficoyMedidorConsumoModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MedidorTraficoyMedidorConsumoEvaluacion2
{
   public class Program
    {
        static IMedidorConsumosDAL dalconsumo = MedidorConsumosDALFactory.createDal();
        static void MostrarMedidorConsumos()
        {
            List<MedidorConsumo> medidorConsumos = dalconsumo.GetAll();
            medidorConsumos.ForEach(m =>
            {
                Console.WriteLine("ID:{0} Consumo:{1}", m.Id, m.Consumo);
            });
            
        }

        static IMedidorTraficoDAL daltrafico = MedidorTraficoDALFactory.createDal();
        static void MostrarMedidorTrafico()
        {
            List<MedidorTrafico> medidorTraficos = daltrafico.GetAll();
            medidorTraficos.ForEach(m =>
            {
                Console.WriteLine("ID:{0} Contador:{1}", m.Id, m.Contador1);
            });
        }


        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Mostrar Medidor de Trafico");
            Console.WriteLine("2. Mostrar Medidor de Consumo");
            Console.WriteLine("3. Mostrar Medidor de Trafico Y Medidor de Consumi");
            Console.WriteLine("0. Salir");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1":
                    MostrarMedidorTrafico();
                    break;
                case "2":
                    MostrarMedidorConsumos();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Debe Seleccionar Una Opcion que Corresponda");
                    break;
            }
            return continuar;


        }
    }

    private static void Main(string[] args)
    {
        while (Menu()) ;
    }
}