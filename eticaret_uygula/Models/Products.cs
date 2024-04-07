﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret_uygula.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name ="Ürün Adı")]
        public string? ProductName { get; set; } = string.Empty;
        [Display(Name = "Ürün Kodu")]
        public int ?ProductCode { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string? ProductDescription { get; set; } = string.Empty;
        [Display(Name = "Ürün Resmi")]
        public string? ProductPicture { get; set; } = string.Empty;
        [Display(Name = "Ürün Fiyatı")]
        public  int? ProductPrice { get; set; }
        [Display(Name = "Ürün Kategorisi")]
        public int ?CategoryId { get; set; }
        virtual public Category? Category { get; set; } //Category tablosunun tüm özelliklerini buraya dahil ettik.
        [NotMapped] //bunun amacı veri tabanına yasıtmaması
        public IFormFile? ImageUpload { get; set; } //burda bir nesne oluşturup resim alanımızı oluşturduk.


    }
}
