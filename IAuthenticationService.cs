using System;
namespace AuthDemo
{
    public interface IAuthenticationService
    {
        public string Authenticate(string username, string password);
    }
}
