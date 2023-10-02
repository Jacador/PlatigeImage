using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.SqlScriptPublish;
using PlatigeImage.View.Interfaces;

namespace PlatigeImage.View.Exporters
{
    public class CsvExporter<T> : IExporter<T>
    {
        private readonly string _filePath;

        public CsvExporter(string filePath)
        {
            _filePath = filePath;
        }

        public void Export(List<T> data, bool openFile)
        {
            string header = MakeHeader(typeof(T));
            File.WriteAllText(_filePath, header + Environment.NewLine);

            foreach (T item in data)
            {
                string line = GetLine(item);
                File.AppendAllText(_filePath, line + Environment.NewLine);
            }

            if (openFile && File.Exists(_filePath))
                Process.Start(_filePath);
        }

        private string MakeHeader(Type type)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var prop in type.GetProperties())
            {
                sb.Append($"{prop.Name}; ");
            }
            return FormatLine(sb.ToString());
        }

        private string GetLine(T item)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var prop in typeof(T).GetProperties())
            {
                sb.Append($"{prop.GetValue(item, null)}; ");
            }

            return FormatLine(sb.ToString());
        }

        private string FormatLine(string line)
        {
            int indexOfLasSemicolon = line.LastIndexOf(';');
            if (indexOfLasSemicolon != -1)
            {
                return line.Substring(0, indexOfLasSemicolon);
            }
            return line;
        }
    }
}
