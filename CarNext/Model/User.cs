using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "Manoel";
        public string Email { get; set; }
        public string Password { get; set; }
        public string NumeroTelefone { get; set; }
        public static string ShortName { get; set; } = "Neto Oliveira";
        public static string UserImage { get; set; } = "https://scontent-mia3-2.xx.fbcdn.net/v/t1.0-9/57362570_10156634295133705_7801257937938153472_o.jpg?_nc_cat=104&_nc_oc=AQlXs_zO9Fsm05j4UqrYNKx_-qJbDbApKw-XDRVQDJbee3YtvnBF1ooLD5K0wXC6-T8&_nc_ht=scontent-mia3-2.xx&oh=669fdf03be02f80cec61123de02e5175&oe=5D797C46";
        public static double Rating { get; set; } = 4.79;
    }
}
