using kursach.DBManager.Models.UserModels;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Blazored.LocalStorage;

namespace kursach.utils
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private ILocalStorageService _localStorage;
        public CustomAuthStateProvider(ILocalStorageService localStorage) {
            _localStorage = localStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());

            try
            {
                var user = await _localStorage.GetItemAsync<User>("user");

                if (user != null)
                {
                    var identity = new ClaimsIdentity(
                        new[]
                        {
                            new Claim(ClaimTypes.Name, user.Login),
                            new Claim(ClaimTypes.Role, user.RightType),
                            new Claim(ClaimTypes.Email, user.Email),
                        }, "CustomApiKeyAuth"
                    );

                    state = new AuthenticationState(new ClaimsPrincipal(identity));                    
                }
                Console.WriteLine("authtorized");
            } catch (Exception ex) {
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
        }
    }
}
