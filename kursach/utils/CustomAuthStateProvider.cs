using kursach.DBManager.Models.UserModels;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace kursach.utils
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly User _user;
        public CustomAuthStateProvider(User user) {
            _user = user;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());

            if(_user != null)
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, _user.Login),
                    new Claim(ClaimTypes.Role, _user.RightType),
                    new Claim(ClaimTypes.Email, _user.Email),
                });

                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
        }
    }
}
