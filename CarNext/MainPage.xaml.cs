using CarNext.ViewModel;

namespace CarNext
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            BindingContext = loginViewModel;
        }

    }

}
