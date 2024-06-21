using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using TemplateBlazorAdmin.Core.Request;
using TemplateBlazorAdmin.Core.Response;
using TemplateBlazorAdmin.Core.Services.Interface;

namespace TemplateBlazorAdmin.Core.Services;

public class AuthService : IAuthService
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly ILocalStorageService _localStorage;
    private readonly ILoginService _loginService;

    public AuthService(ILoginService loginService,
        AuthenticationStateProvider authenticationStateProvider,
        ILocalStorageService localStorage)
    {
        _loginService = loginService;
        _authenticationStateProvider = authenticationStateProvider;
        _localStorage = localStorage;
    }

    public async Task<LoginResponse>? Login(LoginRequest loginRequest)
    {
        var result = await _loginService.Login(loginRequest);

        if (result is null)
            return null;


        await _localStorage.SetItemAsync("authToken", result.Token);
        await _localStorage.SetItemAsync("tokenExpiration", result.Expiration);
        await _localStorage.SetItemAsync("nomeUsuario", result.NomeUsuario);

        ((ApiAuthenticationStateProvider)_authenticationStateProvider)
                            .MarkUserAsAuthenticated(result.NomeUsuario);

        //httpClient.DefaultRequestHeaders.Authorization =
        //            new AuthenticationHeaderValue("bearer",
        //                                             loginResult.Token);

        return result;
    }

    public async Task Logout()
    {
        await _localStorage.RemoveItemAsync("authToken");

        ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
        //httpClient.DefaultRequestHeaders.Authorization = null;
    }
}
