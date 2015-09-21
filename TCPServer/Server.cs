using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    class Server
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();

            HttpListenerContext context = listener.GetContext();

            byte[] byteArr = Encoding.ASCII.GetBytes("Hello World!");
            context.Response.OutputStream.Write(byteArr, 0, byteArr.Length);

            context.Response.Close();

            listener.Stop();
        }
    }
}
