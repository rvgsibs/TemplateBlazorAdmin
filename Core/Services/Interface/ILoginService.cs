using TemplateBlazorAdmin.Core.Request;
using TemplateBlazorAdmin.Core.Response;

namespace TemplateBlazorAdmin.Core.Services.Interface;

public interface ILoginService
{
    Task<LoginResponse>? Login(LoginRequest loginRequest);
}
