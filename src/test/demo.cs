namespace Products
{
    public class ListProducts
    {
        // Thuộc tính
        public string Name { get; set; }

        public string[] Images { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }


        //phuong thucw

        public ListProducts(string name, string[] images, int price, string description, int quantity)
        {
            Name = name;
            Images = images;
            Price = price;
            Description = description;
            Quantity = quantity;
        }

        public void ProductsInit()
        {
            Console.WriteLine($"Name: {Name}, Images: {Images}, Price: {Price}, Description: {Description}, Quantity:{Quantity}");
            if (Images != null && Images.Length > 0)
            {
                Console.WriteLine("Images:");
                foreach (var image in Images)
                {
                    Console.WriteLine($"- {image}");
                }
            }
            else
            {
                Console.WriteLine("No images available.");
            }
        }
    }
}