using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Mocha
{
    internal class MochaWorkerThread
    {

        private TcpClient _client;

        public MochaWorkerThread(TcpClient client)
        {
            this._client = client;
        }

        public void Start()
        {
            NetworkStream clientStream = this._client.GetStream();
            new MochaClient(clientStream, this._client.Available);
            this._client.Close();
        }
    }
}
