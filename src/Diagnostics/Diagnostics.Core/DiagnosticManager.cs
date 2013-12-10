using System.Collections.Generic;
using System.Linq;
using RedRocket.Diagnostics.Common;
using RedRocket.Diagnostics.Common.Configuration;
using RedRocket.Diagnostics.Common.Providers;
using RedRocket.Diagnostics.Common.Providers.Reports;

namespace RedRocket.Diagnostics.Core
{
    public class DiagnosticManager : IDiagnosticManager
    {
        public IEnumerable<IProvider> Providers { get; private set; }

        public IDiagnosticReport GetReports()
        {
            return BuildDiagnosticReport(Providers);
        }

        public DiagnosticManager(IDiagnosticManagerConfiguration diagnosticManagerConfiguration)
        {
            Providers = diagnosticManagerConfiguration.Providers;
        }

        IDiagnosticReport BuildDiagnosticReport(IEnumerable<IProvider> providers)
        {
            var reports = providers.Select(provider => provider.GetReport()).ToList();
            return new DiagnosticReport(reports);
        }

    }
}