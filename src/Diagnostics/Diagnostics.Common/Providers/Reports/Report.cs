namespace RedRocket.Diagnostics.Common.Providers.Reports
{
    public interface IReport
    {

    }

    public interface IReport<TResult> : IReport
    {
        TResult Result { get; set; }
    }

    public abstract class AbstractReport<TResult> : IReport<TResult>
    {
        public abstract TResult Result { get; set; }
    }
}
