using System.Collections.Generic;
using RedRocket.Diagnostics.Common.Providers;
using RedRocket.Diagnostics.Common.Providers.Reports;

namespace RedRocket.Diagnostics.Common
{
    public interface IDiagnosticManager
    {
        IEnumerable<IProvider> Providers { get; }
        IDiagnosticReport GetReports();
    }
}