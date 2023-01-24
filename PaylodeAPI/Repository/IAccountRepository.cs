using JWT_Practice.Models;
using Microsoft.AspNetCore.Identity;

namespace JWT_Practice.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SingInModel singInModel);
    }
}
