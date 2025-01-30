namespace Eticaret.Core.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price {get; set; }
        public string? ProductCode { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }

        //ana sayfada gösterilsin 
        public bool IsHome { get; set; }

        //bağlı olduğu üst kategori
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        //bağlı olduğu marka
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }

        //özel sıralamalar için
        public int OrderNo { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
