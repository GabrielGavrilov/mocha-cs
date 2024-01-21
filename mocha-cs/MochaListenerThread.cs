using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mocha
{
    internal class MochaListenerThread   {

        private int _port;
        private TcpListener _server;
        
        public MochaListenerThread(int port)
        {
            this._port = port;
            this._server = new TcpListener(port);
        }

        public void Start()
        {
            this._server.Start();
            while(true)
            {
                TcpClient client = this._server.AcceptTcpClient();
                MochaWorkerThread workerThread = new MochaWorkerThread(client); 
                workerThread.Start();
            }
        }
    }
}
