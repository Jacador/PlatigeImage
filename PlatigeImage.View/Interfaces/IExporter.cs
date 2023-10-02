using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.Interfaces
{
    public interface IExporter<T>
    {
        void Export(List<T> data, bool openFile);
    }
}
