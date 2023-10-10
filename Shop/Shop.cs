using UnitTests.Shop.Product;

namespace UnitTests.Shop
{
    public class MyShop
    {
        public List<MyProduct> Products { get; set; }

        public MyShop(params MyProduct[] products)
        {
            Products = new List<MyProduct>();
            foreach (var product in products)
                Products.Add(product);
        }

        // Метод должен вернуть отсортированный по возрастанию по цене список продуктов

        public List<MyProduct> SortProductByPrice()
        {
            return Products.OrderByDescending(x => x.Price).ToList();
        }

        // Метод должен вернуть самый дорогой продукт

        public MyProduct GetMostExpensiveProduct()
        {
            return SortProductByPrice()[0];
        }

        public static void PrintMyProductsList(List<MyProduct> products)
        {

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

        }
    }

}

