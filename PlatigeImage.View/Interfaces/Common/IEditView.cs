using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.Interfaces.Common
{
    public interface IEditView : IView
    {
        int EditItemId { get; set; }
    }
}
