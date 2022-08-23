using System.ComponentModel.DataAnnotations;

namespace SP_Express_v1.ModelViews
{
  /// <summary>
  /// Регистрация физ.Лица
  /// </summary>
  public class RegisterViewModel
  {
    /// <summary>Email </summary>
    [Required]
    [Display(Name = "Email")]
    public string? Email { get; set; }

    /// <summary>Телефон</summary>
    [Required]
    [Phone]
    [Display(Name = "Телефон")]
    public string? PhoneNumber { get; set; }

    // /// <summary>Телефон</summary>
    [Display(Name = "ФИО")]
    public string? FIO { get; set; }

    /// <summary>Пароль </summary>
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string? Password { get; set; }

    /// <summary>Подтвердить пароль </summary>
    [Required]
    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
    [DataType(DataType.Password)]
    [Display(Name = "Подтвердить пароль")]
    public string? PasswordConfirm { get; set; }
  }
}
