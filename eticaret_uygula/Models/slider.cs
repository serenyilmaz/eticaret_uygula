using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret_uygula.Models
{
    public class slider//burda yaptığımız şey bire çoklu ilişki var yani bir tablo içerisine bir CategoryId olabilir ama bir Category tablosu birden fazla ürün değeri barındırabilir.
    {
        [Key]
        public  int SliderId { get; set; }//Slider demek resimlere efekli geçiş sağlayan görsel bir uygulamadır.Resimlerden herhangi bir resme tıkladığı zaman o resme ait sayfaya kolaylıkla geçiş yapmasını da sağlar.
        public string ?SliderName { get; set; } = string.Empty;
        public string? Heeader1 { get; set; } = string.Empty;
        public string ?Heeader2 { get; set; } = string.Empty;
        public string? Context { get; set; } = string.Empty;//İçerik ekleme.
        public string ?SliderImage { get; set; } = string.Empty;
        [NotMapped]//bunun amacı veri tabanına yasıtmaması.
        public IFormFile? ImageUpload { get; set; }//verimiz veritabanına işlendi.
    }
}
