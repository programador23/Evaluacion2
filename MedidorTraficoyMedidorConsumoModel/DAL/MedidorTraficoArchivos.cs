using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidorTraficoyMedidorConsumoModel.DTO;

namespace MedidorTraficoyMedidorConsumoModel.DAL
{
    public class MedidorTraficoArchivos : IMedidorTraficoDAL
    {
        private string archivo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "traficos.txt";

        public List<MedidorTrafico> GetAll()
        {
            List<MedidorTrafico> medidorTraficos = new List<MedidorTrafico>();
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
                            MedidorTrafico m = new MedidorTrafico()
                            {
                                Id = textoArray[0],
                                Contador1 = textoArray[1]
                            };
                            medidorTraficos.Add(m);
                        }
                    } while (texto != null);
                }

            }catch(IOException ex)
            {
                medidorTraficos = null;
            }
            return medidorTraficos;
        }

        public void save(MedidorTrafico m)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(m);
                    writer.Flush();
                }

            }catch(IOException ex)
            {

            }
        }
    }
}
