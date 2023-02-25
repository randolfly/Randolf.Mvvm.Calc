using Avalonia;
using Randolf.Calc.Views;
using Splat;

namespace Randolf.Calc;

public static class ServiceBootStrap
{
    /// <summary>
    ///     register the app views
    /// </summary>
    public static void RegisterAppViews()
    {
        Locator.CurrentMutable.RegisterLazySingleton(() => new MainWindow());
    }

    /// <summary>
    ///     register the views in app with fluent paradigm
    /// </summary>
    /// <param name="appBuilder">AppBuilder in Program.cs</param>
    /// <returns></returns>
    public static AppBuilder RegisterAppViews(this AppBuilder appBuilder)
    {
        RegisterAppViews();
        return appBuilder;
    }
}