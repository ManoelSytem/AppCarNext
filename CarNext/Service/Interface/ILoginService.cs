using CarNext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Service.Interface
{
    public interface ILoginService
    {
        Task<User> Login(string email, string senha);
        Task<User> Login(string numeroTelefone);
    }
}
