using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Interfaces.Common;

namespace PlatigeImage.View.Interfaces
{
    public interface IConnectDatabaseWizard : IView
    {
        string ServerName { get; }
        string Login { get; }
        string Password { get; }
        bool TrustedConnection { get; }
        string DatabaseName { get; }
    }
}
