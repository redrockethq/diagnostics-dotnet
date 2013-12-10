using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedRocket.Diagnostics.Core.Configurations;

namespace RedRocket.Diagnostics.Core.Tests
{
    [TestClass]
    public class DiagnosticManagerTests
    {
        [TestMethod]
        public void EmptyDiagnosticManagerConfigurationIsEmptyByDefault()
        {
            var configuration = new EmptyDiagnosticManagerConfiguration();
            Assert.IsNotNull(configuration);

            var diagnosticManager = new DiagnosticManager(configuration);
            Assert.IsNotNull(diagnosticManager);
            
            Assert.IsTrue(!diagnosticManager.Providers.Any());
        }

        [TestMethod]
        public void EmptyDiagnosticManagerConfigurationReturnsEmptyDiagnosticReport()
        {
            var configuration = new EmptyDiagnosticManagerConfiguration();
            Assert.IsNotNull(configuration);

            var diagnosticManager = new DiagnosticManager(configuration);
            Assert.IsNotNull(diagnosticManager);

            Assert.IsTrue(!diagnosticManager.Providers.Any());

            var diagnosticReport = diagnosticManager.GetReports();
            Assert.IsNotNull(diagnosticReport);
            Assert.IsTrue(!diagnosticReport.Reports.Any());
        }
    }
}
