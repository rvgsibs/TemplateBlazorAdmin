using TemplateBlazorAdmin.Core.Request;
using TemplateBlazorAdmin.Core.Response;

namespace TemplateBlazorAdmin.Core.Services.Interface;

public interface IAuthService
{
    Task<LoginResponse>? Login(LoginRequest loginRequest);

    Task Logout();
}
