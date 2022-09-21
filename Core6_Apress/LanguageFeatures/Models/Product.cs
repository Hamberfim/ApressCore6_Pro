namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public static Product?[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275m
            };

            Product lifeJacket = new Product
            {
                Name = "Life Jacket",
                Price = 48.95m
            };

            Product paddle = new Product
            {
                Name = "Paddle",
                Price = 56.95m
            };

            return new Product?[] { kayak, lifeJacket, paddle };
        }
    }
}
