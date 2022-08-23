using System.ComponentModel.DataAnnotations;

namespace SP_Express_v1.ModelViews
{
    /// <summary>LOGIN</summary>
    public class LoginViewModel
    {
        /// <summary> </summary>
        [Required(ErrorMessage = "ВВЕДИТЕ EMAIL")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EMAIL")]
        public string? Email { get; set; }


        /// <summary> </summary>
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
