using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Interfaces.Common;

namespace PlatigeImage.View.Interfaces.Parameters
{
    public interface IGeneratingParametersView : IView
    {
        int Count { get; }
    }
}
