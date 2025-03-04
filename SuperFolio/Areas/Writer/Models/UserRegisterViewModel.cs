using System.ComponentModel.DataAnnotations;

namespace SuperFolio.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullancı adını girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresini girin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen görsel url girin")]
        public string ImageUrl { get; set; }
    }
}
