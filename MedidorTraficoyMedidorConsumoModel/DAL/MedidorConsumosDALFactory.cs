using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorTraficoyMedidorConsumoModel.DAL
{
   public class MedidorConsumosDALFactory
    {
        public static IMedidorConsumosDAL createDal()
        {
            return MedidorConsumosArchivos.GetIntancia();
        }
    }
}
