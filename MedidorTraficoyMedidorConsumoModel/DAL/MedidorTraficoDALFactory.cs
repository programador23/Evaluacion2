﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorTraficoyMedidorConsumoModel.DAL
{
    public class MedidorTraficoDALFactory
    {
        public static IMedidorTraficoDAL createDal()
        {
            return MedidorTraficoArchivos.GetInstancia();
        }
    }
}
