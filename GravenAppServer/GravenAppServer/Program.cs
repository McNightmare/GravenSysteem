using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GravenAppServer
{
    class Program
    {
        private static DatabaseHandler dbh;
        private static Thread MainThread;
        private static IPAddress IP;
        private static int Port;
        private static TcpListener Listener;
        private static Queue<TcpClient> ClientQueue;
        private static Settings settings;
        private static bool Running;

        static void Main(string[] args)
        {
            dbh = new DatabaseHandler("Data Source=DEV-DC01;Initial Catalog=GA_TST;Integrated Security=True");
            MainThread = Thread.CurrentThread;
            Thread listenThread = new Thread(new ThreadStart(StartListening));
            Thread queueThread = new Thread(new ThreadStart(RunQueue));
            ClientQueue = new Queue<TcpClient>();

            settings = new Settings();
            IP = settings.IP;
            Port = settings.Port;
            Listener = new TcpListener(IP, Port);

            ServerDialogue();
            
            Running = true;

            listenThread.Start();
            queueThread.Start();

            do
            {
                
            } while (!GetInput());
        }

        static void StartListening()
        {
            Listener.Start();

            while (Running)
            {
                if (Listener.Pending())
                {
                    TcpClient client = Listener.AcceptTcpClient();
                    ClientQueue.Enqueue(client);
                }
            }
            
            Listener.Stop();
        }
        
        static void RunQueue()
        {
            while (Running)
            {
                if (ClientQueue.Count > 0)
                {
                    TcpClient currentClient = ClientQueue.Dequeue();
                    
                    if (currentClient != null)
                    {
                        NetworkStream stream = currentClient.GetStream();
                        IFormatter formatter = new BinaryFormatter();
                        var info = formatter.Deserialize(stream);
                        Console.WriteLine(info);
                        currentClient.Close();
                    }
                }

                Thread.Sleep(1);
            }
        }

        static bool GetInput()
        {
            if (Console.ReadLine() == "stop")
            {
                Running = false;
                return true;
            }

            return false;
        }

        static bool ServerDialogue()
        {
            Console.WriteLine("Server application started.");

            if (IP == null)
            {
                Console.WriteLine("IPAddress is not set. Enter a new IPAddress:");

                while (!IPAddress.TryParse(Console.ReadLine(), out IP))
                {
                    Console.WriteLine("Please enter a correct IPAddress.");
                }
            }

            if (Port == 0)
            {
                Console.WriteLine("Port is not set. Enter a new port:");

                while (!int.TryParse(Console.ReadLine(), out Port) && Port <= 65535)
                {
                    Console.WriteLine("Please enter a correct port.");
                }
            }

            Console.WriteLine("Server running on IPAddress: {0}; Port: {1}", IP, Port);
            
            return false;
        }
    }
}
