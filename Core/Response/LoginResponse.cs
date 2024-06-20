namespace TemplateBlazorAdmin.Core.Response;

public class LoginResponse
{
    public string? Error { get; set; }
    public string Token { get; set; } = string.Empty;
    public string Expiration { get; set; } = string.Empty;
    public string NomeUsuario { get; set; } = string.Empty;
}
