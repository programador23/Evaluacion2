using MedidorTraficoyMedidorConsumoModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorTraficoyMedidorConsumoModel.DAL
{
    public interface IMedidorTraficoDAL
    {
        void save(MedidorTrafico m);

        List<MedidorTrafico> GetAll();
    }
}
