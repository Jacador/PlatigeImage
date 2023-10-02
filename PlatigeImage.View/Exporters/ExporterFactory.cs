using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Interfaces;

namespace PlatigeImage.View.Exporters
{
    public static class ExporterFactory
    {
        public static IExporter<T>? CreateExporter<T>(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            switch (extension.ToUpper())
            {
                case "CSV":
                    return new CsvExporter<T>(filePath);
                case "XML":
                    return new XmlExporter<T>(filePath);
            }

            return null;
        }
    }
}
