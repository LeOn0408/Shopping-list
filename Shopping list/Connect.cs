using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Shopping_list
{
    
    class Connect
    {
        private const int port = 8888;
        private const string server = "127.0.0.1";

        public string getConnect(string id)
        {
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(server, port);

                
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();
                string product = id + "%name";
                byte[] data = Encoding.UTF8.GetBytes(product);
                stream.Write(data, 0, data.Length);

                data = new byte[256];
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable); // пока данные есть в потоке

                

                // Закрываем потоки
                stream.Close();
                client.Close();
                return response.ToString();
            }
            catch
            {
                return "Не удалось подключиться";
            }
            finally
            {
                
            }
        }

    }
}
