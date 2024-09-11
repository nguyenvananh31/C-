using Products;

class Program
{
    static void Main(string[] args)
    {
        // Khai báo và khởi tạo mảng sản phẩm
        ListProducts[] products = new ListProducts[]
        {
            new ListProducts("Laptop", new string[] { "laptop1.jpg", "laptop2.jpg" }, 1500, "High performance laptop", 10),
            new ListProducts("Smartphone", new string[] { "smartphone1.jpg" }, 800, "Latest model smartphone", 20),
            new ListProducts("Headphones", new string[] { "headphones1.jpg", "headphones2.jpg" }, 50, "Noise-cancelling headphones", 50)
        };

        // Duyệt qua mảng sản phẩm và in thông tin
        foreach (var product in products)
        {
            product.ProductsInit();
            Console.WriteLine(); // Thêm dòng trống giữa các sản phẩm
        }
    }
}