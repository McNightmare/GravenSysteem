using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravenAppServer
{
    class ErrorHandler
    {
        // Language defined by Language Code
        public string Language { get { return Language; } set { while (new XmlHandler().SetText("language", Language)); } }
        private string FilePath { get; set; }
        private Settings Settings { get; set; }

        /// <summary> Default constructor. Uses the default Language and FilePath. </summary>
        public ErrorHandler()
        {
            Language = "EN";
            FilePath = @"./" + @"ErrorDefines" + Language + ".xml";
        }

        /// <summary> Custom constructor. Uses the Language to create a new FilePath. </summary>
        /// <param name="Language"> Language for creating a new FilePath. Language is defined by Langague Code. </param>
        /// <example> ErrorHandler("EN"); </example>
        public ErrorHandler(string Language)
        {
            this.Language = Language;
            FilePath = @"./" + @"ErrorDefines" + Language + ".xml";
        }

        /// <summary> Custom constructor. </summary>
        /// <param name="Language"> Language is defined by Langague Code. </param>
        /// <param name="FilePath"> FilePath must have the .xml extension. </param>
        /// <example> ErrorHandler("EN", ".//ErrorDefinesEN.xml"); </example>
        public ErrorHandler(string Language, string FilePath)
        {
            this.Language = Language;
            this.FilePath = FilePath;
        }

        /// <summary> Custom constructor. </summary>
        /// <param name="Settings"> Settings contains IP, port, Serverpath and language information. </param>
        /// <example> ErrorHandler(new Settings()); </example>
        public ErrorHandler(Settings Settings)
        {
            Language = Settings.Language;
            FilePath = @"./" + @"ErrorDefines" + Language + ".xml";
        }

        public string GetErrorMessage(string errorCode)
        {
            return new XmlHandler(FilePath).GetText(errorCode);
        }
    }
}
