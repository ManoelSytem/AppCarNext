using CarNext.Service.Interface;
using CarNext.ViewModel;

namespace CarNext.CustomControl {
   
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhonePicker : ContentView
{
        private ILoginService iloginService;

    public PhonePicker()
	{
        InitializeComponent();
        buttondropdow.Clicked += buttonDropdow_Clicked;

            var loginViewModel = new LoginViewModel(iloginService);

            var listPrefixo = new List<string>();

            this.ItemsSource = loginViewModel.ObterListPrefixo();
     }

    private void buttonDropdow_Clicked(object sender, EventArgs e)
    {
        borderlessPicker1.Focus();
    }

    public BorderlessPicker Picker { get => borderlessPicker1; set => borderlessPicker1 = value; }

    public string Title { get => borderlessPicker1.Title; set => borderlessPicker1.Title = value; }

    public System.Collections.IList ItemsSource { get => borderlessPicker1.ItemsSource; set => borderlessPicker1.ItemsSource = value; }
    
    public BindingBase ItemDisplay { get => borderlessPicker1.ItemDisplayBinding; set => borderlessPicker1.ItemDisplayBinding = value; }


    }

}