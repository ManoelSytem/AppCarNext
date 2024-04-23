using CarNext.Model;
using CarNext.Service;
using CarNext.Service.Interface;
using CarNext.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using System.ComponentModel;


namespace CarNext.ViewModel
{

    public partial class LoginViewModel : ObservableObject, INotifyPropertyChanged
    {
        #region Picker
        [ObservableProperty] private List<ObjectConstant> listPrefixo;
        #endregion

        [ObservableProperty]  private string numeroTelefone;

        [ObservableProperty] private string email;

        [ObservableProperty]  private string senha;


        public event PropertyChangedEventHandler PropertyChanged;

        private bool activityIndicatorIsRunning;

        //Forma Generica clássica sem tollkit
        public bool ActivityIndicatorIsRunning
        {
            get
            {
                return activityIndicatorIsRunning;
            }


            set
            {
                if (activityIndicatorIsRunning != value)
                {
                    activityIndicatorIsRunning = value;
                    var args = new PropertyChangedEventArgs(nameof(ActivityIndicatorIsRunning));
                    PropertyChanged?.Invoke(this, args);
                }
            }
        }

        readonly ILoginService loginService;


        public LoginViewModel(ILoginService loginService) 
        {
            this.loginService = loginService;
        }

        public List<ObjectConstant> ObterListPrefixo()
        {
            return ConstanteService.ObterListPrefixo().OrderBy(c => c.Value).ToList();
        }


        [RelayCommand]
        public async void Login()
        {
            try
            {
                var pemisaoResult = await CheckAndRequestLocationPermission();

                ActivityIndicatorIsRunning = true;

                NetworkAccess accessType = Connectivity.Current.NetworkAccess;

                if (accessType == NetworkAccess.Internet)  //A conexão com a internet está disponível
                { 
                    if (!string.IsNullOrWhiteSpace(numeroTelefone))
                    {
                        await Shell.Current.GoToAsync("///main");

                        //User user = await loginService.Login(numeroTelefone);
                        //if (user == null)
                        //{
                        //    await Shell.Current.DisplayAlert("Error", "código SMS não verificado", "Ok");
                        //    return;
                        //}
                        //if (Preferences.ContainsKey(nameof(user.Id)))
                        //{
                        //    Preferences.Remove(nameof(user.Id));
                        //}
                        //string userDetails = JsonConvert.SerializeObject(user);
                        //Preferences.Set(nameof(user.Id), userDetails);
                        //await Shell.Current.GoToAsync(nameof(HomeSheel));
                    }
                    else
                    {
                        ActivityIndicatorIsRunning = false;
                        await Shell.Current.DisplayAlert("Error", "informe o número telefone", "Ok");
                        return;
                    }
                }
                else
                {
                    ActivityIndicatorIsRunning = false;
                    await Shell.Current.DisplayAlert("Error", "No Internet Access", "Ok");
                    return;
                }

            }
            catch (Exception ex)
            {
                ActivityIndicatorIsRunning = false;
                await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
                return;
            }


        }      public async Task<PermissionStatus> CheckAndRequestLocationPermission()
        {
            PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status == PermissionStatus.Granted)
                return status;

            if (status == PermissionStatus.Denied && DeviceInfo.Platform == DevicePlatform.iOS)
            {
                // Prompt the user to turn on in settings
                // On iOS once a permission has been denied it may not be requested again from the application
                return status;
            }

            if (Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>())
            {
                // Prompt the user with additional information as to why the permission is needed
            }

            status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

            return status;
        }

  

    }

}
