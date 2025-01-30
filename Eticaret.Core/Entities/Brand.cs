namespace Eticaret.Core.Entities
{
    //marka
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public bool IsActive { get; set; }

        //özel sıralamalar için
        public int OrderNo { get; set; }

        public DateTime CreateDate { get; set; }

        public IList<Product>? Products { get; set; }
    }
}
