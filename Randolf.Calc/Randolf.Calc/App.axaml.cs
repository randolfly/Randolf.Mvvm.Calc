using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Randolf.Calc.Library.ViewModels;
using Randolf.Calc.Views;
using Splat;

namespace Randolf.Calc;

public class App : Application, IEnableLogger
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        this.Log().Debug("Hello World!");
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var mainWindow = Locator.Current.GetService<MainWindow>()
                             ?? throw new Exception("Exception while create MainWindow");
            mainWindow.DataContext = Locator.Current.GetService<MainWindowViewModel>()
                                     ?? throw new Exception("Exception while create MainWindowViewModel");
            desktop.MainWindow = mainWindow;
        }

        base.OnFrameworkInitializationCompleted();
    }
}