using System.Collections.Generic;
using RedRocket.Diagnostics.Common.Providers;

namespace RedRocket.Diagnostics.Common.Configuration
{
    public interface IDiagnosticManagerConfiguration
    {
        IEnumerable<IProvider> Providers { get; set; }
    }
}