

using TemplateBlazorAdmin.Request;
using TemplateBlazorAdmin.Response;

namespace TemplateBlazorAdmin.Services.Autenticacao.Interface;

public interface IAuthService
{
    Task<LoginResponse> Login(LoginRequest loginRequest);

    Task Logout();
}
