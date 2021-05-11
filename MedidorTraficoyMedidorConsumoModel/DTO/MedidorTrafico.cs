using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorTraficoyMedidorConsumoModel.DTO
{
    public class MedidorTrafico
    {
        private string id;
        private string Contador;

        public string  Id { get => id; set => id = value; }
        public string Contador1 { get => Contador; set => Contador = value; }

        public override string ToString()
        {
            return Id + ";" + Contador1;
        }

    }
}
