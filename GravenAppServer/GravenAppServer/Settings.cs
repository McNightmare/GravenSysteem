using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GravenAppServer
{
    class Settings
    {
        public IPAddress IP { get; set; }
        public int Port { get; set; }
        public string ServerPath { get; set; }
        public string Language { get; set; }

        public Settings()
        {
            XmlHandler xmlHndlr = new XmlHandler(@".\Config.xml");
            IP = IPAddress.Parse(xmlHndlr.GetText("ip"));
            Port = int.Parse(xmlHndlr.GetText("port"));
            Language = xmlHndlr.GetText("language");
        }
    }
}
