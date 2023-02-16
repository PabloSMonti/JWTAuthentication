using Authenticator.Models;
using Authenticator.Models.Interfaces;
using System.Net;

namespace Authenticator.Tools
{
    public class CredentialValidator : IValidator<UserCredential>
    {
        public static bool IsValid(UserCredential credential)
        { 
            return !(credential is null || string.IsNullOrEmpty(credential.UserName) || string.IsNullOrEmpty(credential.Password));
        }
    }
}
