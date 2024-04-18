namespace ShopApi.Models
{
    public class ProductFormModel
    {
        public Guid CategoryId { get; set; }
        public String Slug { get; set; } = null!;
        public String Name { get; set; } = null!;
        public String Description { get; set; } = null!;
        public IFormFile Image { get; set; } = null!;
        public Double Price { get; set; }
    }
}
