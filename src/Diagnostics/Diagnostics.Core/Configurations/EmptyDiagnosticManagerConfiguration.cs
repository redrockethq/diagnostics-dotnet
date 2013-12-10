using System.Collections.Generic;
using System.Linq;
using RedRocket.Diagnostics.Common.Configuration;
using RedRocket.Diagnostics.Common.Providers;

namespace RedRocket.Diagnostics.Core.Configurations
{
    public class EmptyDiagnosticManagerConfiguration : IDiagnosticManagerConfiguration
    {
        public IEnumerable<IProvider> Providers { get; set; }

        public EmptyDiagnosticManagerConfiguration()
        {
            Providers = Enumerable.Empty<IProvider>();
        }
    }
}