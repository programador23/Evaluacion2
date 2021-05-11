using MedidorTraficoyMedidorConsumoModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorTraficoyMedidorConsumoModel.DAL
{
    public interface IMedidorConsumosDAL
    {
        void savecosumos(MedidorConsumo m);

        List<MedidorConsumo> GetAll();
    }
}
