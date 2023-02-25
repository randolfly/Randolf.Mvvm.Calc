using Avalonia.ReactiveUI;
using Randolf.Calc.Library.ViewModels;
using ReactiveUI;
using Splat;

namespace Randolf.Calc.Views;

[SingleInstanceView]
public partial class MainWindow : ReactiveWindow<MainWindowViewModel>, IEnableLogger
{
    public MainWindow()
    {
        InitializeComponent();
    }
}