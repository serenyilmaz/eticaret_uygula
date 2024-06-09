using System.ComponentModel.DataAnnotations;

namespace eticaret_uygula.Dto
{
    public class AppUserRegisterDto
    {
        [Display(Name ="Adınız")] //Display ingilizce kelimeyi türkçeye çevirir.
        [Required(ErrorMessage ="Adınızı Boş Geçemezsiniz")] //required zorunlu alan demek.
        public string FirstName { get; set; }
        [Display(Name ="Soyadınızı Giriniz")]
        [Required(ErrorMessage ="Soyadınızı Boş Geçemezsiniz")]
        public string LastName { get; set; }
        [Display(Name = "Kullanıcı Adını Giriniz")]
        [Required(ErrorMessage = "Kullanıcı Adını Boş Geçemezsiniz")]
        public string UserName { get; set; }
        [Display(Name = "Şehri Giriniz")]
        [Required(ErrorMessage = "Şehir Adını Boş Geçemezsiniz")]
        public string City { get; set; }
        [Display(Name = "Email Giriniz")]
        [Required(ErrorMessage = "Email Boş Geçemezsiniz")]
        public string Email { get; set; }
        [Display(Name = "Telefon Giriniz")]
        [Required(ErrorMessage = "Telefon Boş Geçemezsiniz")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Şifrenizi Giriniz")]
        [Required(ErrorMessage = "Şifreyi Boş Geçemezsiniz")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }  
    }
}
