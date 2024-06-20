using TemplateBlazorAdmin.Request;
using TemplateBlazorAdmin.Response;

namespace TemplateBlazorAdmin.Services.Interface;

public interface ILoginService
{
    Task<LoginResponse> Login(LoginRequest loginRequest);
}
