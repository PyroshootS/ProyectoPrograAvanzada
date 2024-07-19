using System.ComponentModel.DataAnnotations;

public class LoginViewModel
{
    [Required(ErrorMessage = "El campo Email es obligatorio")]
    [EmailAddress(ErrorMessage = "El formato del Email no es válido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "El campo Contraseña es obligatorio")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Recordarme")]
    public bool RememberMe { get; set; }
}