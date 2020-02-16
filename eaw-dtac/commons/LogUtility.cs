using System.Runtime.CompilerServices;
using Serilog;
[assembly: InternalsVisibleTo("eaw-dtac.test")]
namespace eaw.dtac.commons
{
    internal static class LogUtility
    {
        internal static ILogger GetLogger()
        {
#if DEBUG
            return new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .CreateLogger();
            ;
#else
            return new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();
#endif
        }
    }
}
