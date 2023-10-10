namespace UnitTests.Shop.Shop
{
    public class MyProduct
    {
        public int Price { get; set; }
        public string Title { get; set; }

        public MyProduct(int price, string title)
        {
            Price = price;
            Title = title;  

        }

        public override string ToString()
        {
            return $"Название = {Title}, Цена = {Price}";
        }

    }
}
