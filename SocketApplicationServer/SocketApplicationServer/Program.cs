using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace SocketApplicationServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(System.Net.IPAddress.Any,6969);
            // initializes variable and value for TcpListener class library

            int reqCnt = 0;            
            // count of requests

            TcpClient clientSocket = default(TcpClient);            
            // set to null

            serverSocket.Start();            
            // start the socket of server

            Console.WriteLine("ROOT: Server has started.");
            clientSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine("ROOT: Accepting connection from client.");
            reqCnt = 0;

            while ((true))
            {
                try
                {
                    reqCnt += 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[10025];
                    networkStream.Read(bytesFrom,0,(int)clientSocket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine("ROOT: Data from client - " + dataFromClient);
                    string serverResponse = "Last message from client " + dataFromClient;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine("ROOT: " +serverResponse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine("ROOT: End");
            Console.ReadLine();
        }
    }
}
