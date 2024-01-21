using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocha
{
    class Program : Mocha
    {
        public static void Main(string[] args)
        {
            Listen(3000, ()=>
            {
                Console.WriteLine("Mocha server is up and running.");
            });
        }
    }
}