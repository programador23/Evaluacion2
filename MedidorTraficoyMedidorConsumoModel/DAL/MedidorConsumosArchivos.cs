using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidorTraficoyMedidorConsumoModel.DTO;

namespace MedidorTraficoyMedidorConsumoModel.DAL
{
    public class MedidorConsumosArchivos : IMedidorConsumosDAL
    {
        private MedidorConsumosArchivos()
        {

        }
        private static IMedidorConsumosDAL instancia;

        public static IMedidorConsumosDAL GetIntancia()
        {
            if(instancia == null)
            {
                instancia = new MedidorConsumosArchivos();
            }
            return instancia;
        }

        private string archivo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "consumos.txt";
        public List<MedidorConsumo> GetAll()
        {
        
            List<MedidorConsumo> medidorconsumos = new List<MedidorConsumo>();
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    string texto = null;
                    do
                    {
                        texto = reader.ReadLine();
                        if (texto != null)
                        {
                            string[] textoArray = texto.Split(';');
                            MedidorConsumo m = new MedidorConsumo()
                            {
                                Id = textoArray[0],
                                Consumo = textoArray[1]
                            };
                            medidorconsumos.Add(m);
                        }
                    } while (texto != null);
                }

            }catch (IOException ex)
            {
                medidorconsumos = null;
            }

            return medidorconsumos;
        }

        public void savecosumos(MedidorConsumo m)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(m);
                    writer.Flush();
                }

            }
            catch (IOException ex)
            {

            }
        }
    }
}
