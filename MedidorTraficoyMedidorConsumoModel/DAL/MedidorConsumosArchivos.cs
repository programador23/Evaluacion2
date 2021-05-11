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
        private string archivo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "consumos.txt";
        public List<MedidorConsumo> GetAll()
        {
            List<MedidorConsumo> medidorconsumos = new List<MedidorConsumo>();


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
