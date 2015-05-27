using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GravenAppServer
{
    class XmlHandler
    {
        private string DefaultPath { get { return ""; } }
        public string FilePath { get; set; }

        public XmlHandler()
        {
            FilePath = DefaultPath;
        }

        public XmlHandler(string FilePath)
        {
            this.FilePath = FilePath;
        }

        public string GetText(string NodeName)
        {
            string result = null;

            try
            {
                XmlReader rdr = XmlReader.Create(FilePath);

                while (rdr.Read())
                {
                    if (rdr.Name == NodeName)
                    {
                        result = rdr.ReadInnerXml();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }

        public bool SetText(string NodeName, string Value)
        {
            return false;
        }
    }
}
