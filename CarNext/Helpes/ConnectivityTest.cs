using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Helpes
{
    public class ConnectivityTest
    {
        public ConnectivityTest() =>
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

        ~ConnectivityTest() =>
            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;

        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess == NetworkAccess.ConstrainedInternet)
                Console.WriteLine("O acesso à Internet está disponível, mas é limitado.");

            else if (e.NetworkAccess != NetworkAccess.Internet)
                Console.WriteLine("O acesso à Internet foi perdido.");

            // Log each active connection
            Console.Write("Conexões ativas: ");

            foreach (var item in e.ConnectionProfiles)
            {
                switch (item)
                {
                    case ConnectionProfile.Bluetooth:
                        Console.Write("Bluetooth");
                        break;
                    case ConnectionProfile.Cellular:
                        Console.Write("Cell");
                        break;
                    case ConnectionProfile.Ethernet:
                        Console.Write("Ethernet");
                        break;
                    case ConnectionProfile.WiFi:
                        Console.Write("WiFi");
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine();
        }
    }
}
