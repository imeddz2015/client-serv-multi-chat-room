using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SimpleServerCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 1111;

            if(File.Exists("1111.txt")){
                port = 1111;
            }
            else if (File.Exists("2222.txt"))
            {
                port = 2222;
            }
            else if (File.Exists("3333.txt"))
            {
                port = 3333;
            }
            else if (File.Exists("4444.txt"))
            {
                port = 4444;
            }

            SimpleServer _simpleServer = new SimpleServer("127.0.0.1", port);

            _simpleServer.Start();

            _simpleServer.Stop();
        }
    }
}
