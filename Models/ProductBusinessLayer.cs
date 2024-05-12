namespace Project.Models
{
    public class ProductBusinessLayer
    {
        private List<Product> products;
        public ProductBusinessLayer()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 0, Name = "Iphone 11", Price = 22000, 
            Description = "The iPhone 11 is a smartphone designed and manufactured by Apple Inc. It features a 6.1-inch Liquid Retina display, equipped with the powerful A13 Bionic chip for smooth performance and enhanced efficiency.", Image = "ph1.png" });
            products.Add(new Product() { Id = 1, Name = "Iphone 6", Price = 4000, 
            Description = "Affordable smartphone developed by Apple Inc. It features a 4.7-inch Retina HD display and is powered by the Apple A8 chip, offering smooth performance and efficient multitasking", Image = "ph2.webp" });
            products.Add(new Product() { Id = 2, Name = "Wired phone", Price = 2000,
            Description = "landline telephone, is a communication device that connects to a telephone network via physical wires", Image = "ph3.webp" });
            products.Add(new Product() { Id = 3, Name = "Nokia54", Price = 3500,
            Description = "One of the most iconic old Nokia phones is the Nokia 3310, released in the year 2000. It gained legendary status for its durability, long battery life, and simple yet functional design", Image = "ph4.jfif" });
        }

        public List<Product> GetProducts() 
        {
         return products;
        }
    }
}
