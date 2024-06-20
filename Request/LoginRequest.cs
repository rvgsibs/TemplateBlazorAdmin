using System.ComponentModel.DataAnnotations;

namespace TemplateBlazorAdmin.Request;

public class LoginRequest
{
    [Required(ErrorMessage = "Informe o usuário")]
    public string? Usuario { get; set; }
    [Required(ErrorMessage = "Informe a senha")]
    public string? Senha { get; set; }

}
