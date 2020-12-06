using PWA.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories.Interface
{
    public interface IAccounts
    {
        Task<UserToken> Login(UserLogIn userLogIn);
        Task<UserToken> Register(UserRegister userRegister);
        Task<UserToken> RenewToken();
    }
}
