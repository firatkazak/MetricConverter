using MetricConverter.MVVM.ViewModels;

namespace MetricConverter.MVVM.Views;

public partial class MenuView : ContentPage
{
    public MenuView()
    {
        InitializeComponent();
        BindingContext = new MenuViewModel();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Grid element = (Grid)sender;
        string option = ((Label)element.Children.LastOrDefault()).Text;
        ConverterView converterView = new ConverterView { BindingContext = new ConverterViewModel(option) };
        Navigation.PushAsync(converterView);
    }
}
