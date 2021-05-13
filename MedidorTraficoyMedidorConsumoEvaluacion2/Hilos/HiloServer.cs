using ServicioDeComunicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorTraficoyMedidorConsumoEvaluacion2.Hilos
{
    class HiloServer
  
    {
        
        private int puerto;
        private ServerSocket server;
        public HiloServer (int puerto)
        {
            this.puerto = puerto;
        }
        public void Ejecutar()
        {
            server = new ServerSocket(puerto);
            Console.WriteLine("Conexion Iniciada{0}", puerto);
            if (server.Iniciar())
            {
                Console.WriteLine("Server Iniciado");
                while (true)
                {
                    Console.WriteLine("Esperando");
                    ClienteMedidor clienteMedidor = server.ObtenerCliente();
                }
            }
        }

    }
}
