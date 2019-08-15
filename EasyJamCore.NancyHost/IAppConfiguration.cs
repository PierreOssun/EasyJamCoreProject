namespace EasyJamCore.NancyHost
{
    public interface IAppConfiguration
    {
        Logging Logging { get; }
        Smtp Smtp { get; }
    }
}
