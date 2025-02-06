﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        [Display(Name = "Fiyat")]
        public decimal Price {get; set; }
        [Display(Name = "Ürün Kodu")]
        public string? ProductCode { get; set; }
        [Display(Name = "Stok")]
        public int Stock { get; set; }
        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }

        //ana sayfada gösterilsin 
        [Display(Name = "Anasayfada Göster")]
        public bool IsHome { get; set; }

        //bağlı olduğu üst kategori
        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public Category? Category { get; set; }

        //bağlı olduğu marka
        [Display(Name = "Marka")]
        public int? BrandId { get; set; }
        [Display(Name = "Marka")]
        public Brand? Brand { get; set; }

        //özel sıralamalar için
        [Display(Name = "Sıra No")]
        public int OrderNo { get; set; }
        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }
    }
}
