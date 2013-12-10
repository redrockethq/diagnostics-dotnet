using RedRocket.Diagnostics.Common.Providers.Reports;

namespace RedRocket.Diagnostics.Common.Providers
{
    public abstract class AbstractProvider : IProvider
    {
        protected AbstractProvider(string name, bool isEnabled)
        {
            Name = name;
            IsEnabled = isEnabled;
        }

        public string Name { get; private set; }
        public bool IsEnabled { get; private set; }
        public abstract IReport GetReport();
    }
}