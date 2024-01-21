using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Mocha
{
    internal class MochaClient
    {
        public MochaClient(NetworkStream clientStream, int clientAvailable)
        {
            string clientHeader;

            byte[] streamBytes = new byte[clientAvailable];
            clientStream.Read(streamBytes, 0, streamBytes.Length);
        
            clientHeader = Encoding.UTF8.GetString(streamBytes);

           
            byte[] response = Encoding.UTF8.GetBytes("HTTP/1.1 200 OK\r\n" +
                "Content-Type: text/html\r\n\r\n" +
                "<h1>Hello, from Mocha!</h1>");

            clientStream.Write(response, 0, response.Length);
        }


    }
}
