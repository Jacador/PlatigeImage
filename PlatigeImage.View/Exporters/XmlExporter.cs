using PlatigeImage.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlatigeImage.View.Exporters
{
    public class XmlExporter<T> : IExporter<T>
    {
        private readonly string _filePath;
        public XmlExporter(string filePath)
        {
            _filePath = filePath;
        }

        public void Export(List<T> data, bool openFile)
        {
            using TextWriter writer = new StreamWriter(_filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            serializer.Serialize(writer, data);

            if (openFile && File.Exists(_filePath))
                Process.Start(_filePath);
        }


    }
}
