using MetricConverter.MVVM.ViewModels;

namespace MetricConverter.MVVM.Views;

public partial class ConverterView : ContentPage
{
    public ConverterView()
    {
        InitializeComponent();
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        ConverterViewModel viewModel = (ConverterViewModel)BindingContext;
        viewModel.Convert();
    }
}
