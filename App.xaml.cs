using MetricConverter.MVVM.Views;

namespace MetricConverter;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MenuView());
    }
}
