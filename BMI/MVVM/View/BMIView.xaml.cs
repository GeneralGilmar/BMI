using BMI.MVVM.ViewModels;

namespace BMI.MVVM.View;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
        BindingContext = new BMIViewModel();
    }
}