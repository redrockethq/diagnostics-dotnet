using RedRocket.Diagnostics.Common.Providers.Reports;

namespace RedRocket.Diagnostics.Common.Providers
{
    public interface IProvider
    {
        string Name { get; }
        bool IsEnabled { get; }

        IReport GetReport();
    }
}
