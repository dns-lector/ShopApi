namespace ShopApi.Data
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public String Slug { get; set; } = null!;
        public String Name { get; set; } = null!;
        public String Description { get; set; } = null!;
        public String ImageUrl { get; set; } = null!;
        public Int32 PriceCent { get; set; }
        public Boolean IsActive { get; set; } = true;
    }
}
