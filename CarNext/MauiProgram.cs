using CarNext.CustomControl;
using CarNext.Platforms;
using CarNext.Service;
using CarNext.Service.Interface;
using CarNext.View;
using CarNext.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PanCardView;

namespace CarNext
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>().UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).UseMauiMaps().UseCardsView();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            Microsoft.Maui.Handlers.ElementHandler.ElementMapper.AppendToMapping("Classic", (handler, view) =>
            {
                if (view is CustomEntry)
                {
                    CustomEntryMapper.Map(handler, view);
                }
            });

            //route
            Routing.RegisterRoute(nameof(InicioPage), typeof(InicioPage));

            //Pages
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<RecursoPage>();
            builder.Services.AddTransient<MapPesquisaPage>();
            builder.Services.AddTransient<PesquisarRotaPage>();



            // ViewModels
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<RecursoViewModel>();
            builder.Services.AddTransient<GoogleViewModel>();


            //Service 
            // Services
            builder.Services.AddTransient<ILoginService, LoginService>();
            builder.Services.AddTransient<IGoogleMapsApiService, GoogleMapsApiService>();

            return builder.Build();
        }
    }
}
