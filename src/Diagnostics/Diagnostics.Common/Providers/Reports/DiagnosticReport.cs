using System.Collections.Generic;
using System.Linq;
using RedRocket.Diagnostics.Common.Providers.Reports;

namespace RedRocket.Diagnostics.Common.Providers.Reports
{
    public interface IDiagnosticReport
    {
        IEnumerable<IReport> Reports { get; set; }
    }

    public class DiagnosticReport : IDiagnosticReport
    {
        public IEnumerable<IReport> Reports { get; set; }

        public DiagnosticReport()
        {
            Reports = Enumerable.Empty<IReport>();
        }

        public DiagnosticReport(IEnumerable<IReport> reports)
        {
            Reports = reports;
        }
    }
}