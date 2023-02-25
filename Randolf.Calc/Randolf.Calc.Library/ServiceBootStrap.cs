using Avalonia;
using Randolf.Calc.Library.ViewModels;
using Splat;

namespace Randolf.Calc.Library;

public static class ServiceBootStrap
{
    /// <summary>
    ///     register the services in library
    /// </summary>
    public static void RegisterLibraryServices()
    {
        // config log service
        var logger = new DebugLogger { Level = LogLevel.Info };
        Locator.CurrentMutable.RegisterConstant(logger, typeof(ILogger));

        // config view model
        Locator.CurrentMutable.RegisterLazySingleton(() => new MainWindowViewModel());
    }

    /// <summary>
    ///     register service in library with fluent paradigm
    /// </summary>
    /// <param name="appBuilder">AppBuilder in Program.cs</param>
    /// <returns></returns>
    public static AppBuilder RegisterLibraryServices(this AppBuilder appBuilder)
    {
        RegisterLibraryServices();
        return appBuilder;
    }
}