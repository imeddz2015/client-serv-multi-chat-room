using Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SimpleServerCS
{
    class SimpleServer
    {


        TcpListener _tcpListener;
        static List<Client> clients = new List<Client>();

        public SimpleServer(string ipAddress, int port)
        {
            IPAddress ip = IPAddress.Parse(ipAddress);
            _tcpListener = new TcpListener(ip, port);
        }

        public void Start()
        {
            _tcpListener.Start();

            Console.WriteLine("Listening...");

            while (true)
            {
                Socket socket = _tcpListener.AcceptSocket();

                Client client;
                //==================================================================================
                if (clients.Count < 5)
                {
                    client = new Client(socket, null);

                }
                else
                {
                    client = new Client(socket, "This room don't accept new users , please try after a while ");
                   
                }

                clients.Add(client);
                client.Start();
                //==================================================================================
            }

        }

        public void Stop()
        {
            foreach (Client c in clients)
            {
                c.Stop();

            }

            _tcpListener.Stop();
        }

        public static void SocketMethod(Client fromClient, string firstMssageToClient)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Socket socket = fromClient.Socket;
            NetworkStream stream = fromClient.Stream;
            BinaryReader reader = fromClient.Reader;

            //==================================================================================
            if (firstMssageToClient == null)
            {//==================================================================================

                fromClient.SendText(fromClient, "Successfully Connected");

                try
                {
                    Console.WriteLine(" start loop");
                    // Read the number of incoming bytes
                    int noOfIncomingBytes;
                    while ((noOfIncomingBytes = reader.ReadInt32()) != 0)
                    {
                        // Read the bytes for noOfIncomingBytes amount
                        byte[] bytes = reader.ReadBytes(noOfIncomingBytes);

                        //Store the bytes in a MemoryStream
                        MemoryStream memoryStream = new MemoryStream(bytes);

                        Packet packet = formatter.Deserialize(memoryStream) as Packet;

                        switch (packet.type)
                        {
                            case PacketType.NICKNAME:
                                // Cast the packet to the correct packet type and read the data
                                string nickName = ((NickNamePacket)packet).nickName;

                                // Set the clients NickName
                                fromClient.SetNickName(nickName);
                                break;

                            case PacketType.CHATMESSAGE:
                                // Cast the packet to the correct packet type and read the data
                                string message = ((ChatMessagePacket)packet).message;

                                // Write the message out to the server console window
                                Console.WriteLine("[" + fromClient.NickName + "] " + message);

                                // Forward this packet on to all client
                                foreach (Client c in clients)
                                {
                                    // Construct a new packet which includes the nickname
                                    c.SendText(fromClient, message);
                                }
                                break;
                        }


                    } 

                     
                }

                catch (Exception e)
                {   //==================================================================================
                    clients.Remove(fromClient);
                    Console.WriteLine(" client disconnected !");
                    fromClient.Stop();
                    //==================================================================================
                }
                finally
                {
                    fromClient.Stop(); 
                }
            }//==================================================================================
            else
            {
                fromClient.SendText(fromClient, "Room is busy : " + firstMssageToClient + "exitCode:#!254!$");
                
                try{
                     
                // Read the number of incoming bytes
                int noOfIncomingBytes;
                while ((noOfIncomingBytes = reader.ReadInt32()) != 0)
                {
                 // Read the bytes for noOfIncomingBytes amount
                 byte[] bytes = reader.ReadBytes(noOfIncomingBytes); 

                }  

                }

                catch (Exception e)
                {
                    clients.Remove(fromClient);
                    Console.WriteLine(" client refused !");
                    fromClient.Stop();
                }

            }//==================================================================================

        }


    }
}
