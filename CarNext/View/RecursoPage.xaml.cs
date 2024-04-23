using CarNext.ViewModel;

namespace CarNext.View;

public partial class RecursoPage : ContentPage
{
	public RecursoPage(RecursoViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

    }
}