using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Mocha
{
    public class Mocha
    {
        public static void Listen(int port, Action callback)
        {
            callback();
            MochaListenerThread listenerThread = new MochaListenerThread(port);
            listenerThread.Start();
        }
    }
}
