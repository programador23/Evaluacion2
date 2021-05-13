using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeComunicacion
{
    public class ClienteMedidor
    {
        private Socket medidor;
        private StreamReader reader;
        private StreamWriter writer;

        public ClienteMedidor (Socket medidor)
        {
            this.medidor = medidor;
            Stream stream = new NetworkStream(this.medidor);
            this.writer = new StreamWriter(stream);
            this.reader = new StreamReader(stream);
        }

        public bool Escribir(string lecturaMedidor)
        {
            try
            {
                this.writer.WriteLine(lecturaMedidor);
                this.writer.Flush();
                return true;
            }
            catch (IOException ex)
            {
                return false;
            }

        }

        public string Leer()
        {
            try
            {
                return this.reader.ReadLine().Trim();
            }
            catch (IOException ex)
            {
                return null;
            }
        }

        public void CerrarConexion()
        {
            this.medidor.Close();
        }

    }
}
