using HydroAlert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroAlert.Services
{
    internal interface ILoginRepository
    {
        Task<UserInfo> Login(string username, string password);
    }
}
