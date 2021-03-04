using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlueApeUI.Models.Users.Requests;
using BlueApeUI.Models.Users.Responses;

namespace BlueApeUI.Contracts
{
    interface IAuthenticationRepository
    {
        public Task<UserDataResponse> Register(RegisterEntity user);
        public Task<UserDataResponse> Login(LoginEntity user);
        public Task Logout();
    }
}
