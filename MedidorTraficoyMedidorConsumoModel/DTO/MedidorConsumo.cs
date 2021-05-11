using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorTraficoyMedidorConsumoModel.DTO
{
    public class MedidorConsumo
    {
        private string id;
        private string consumo;

        public string Id { get => id; set => id = value; }
        public string Consumo { get => consumo; set => consumo = value; }

        public override string ToString()
        {
            return Id + ";" + Consumo;
        }
    }
}
