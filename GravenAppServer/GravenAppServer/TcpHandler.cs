using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GravenAppServer
{
    class TcpHandler
    {
        public IPAddress IP { get { return IP; } set { listener = new TcpListener(value, Port); } }
        public int Port { get { return Port; } set { listener = new TcpListener(IP, value); } }
        public Settings Settings;
        
        private TcpListener listener;
        private bool listening;

        public TcpHandler(Settings Settings)
        {
            IP = Settings.IP;
            Port = Settings.Port;
            this.Settings = Settings;
            
            listener = new TcpListener(IP, Port);
        }

        void StartListening(ref Queue<TcpClient> Queue)
        {
            Queue<TcpClient> _Queue = Queue;
            Thread thread = new Thread(() => 
            {
                listener.Start();
                listening = true;

                while (listening)
                {
                    if (listener.Pending())
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        _Queue.Enqueue(client);
                    }
                }

                listener.Stop();
            });

            thread.Start();
            thread.Join();
            
        }

        void StopListening()
        {
            listening = false;
        }
    }
}
