using UnitTests.Shop;
using UnitTests.Shop.Shop;

var prod1 = new MyProduct(10, "product1");
var prod2 = new MyProduct(1, "product2");
var prod3 = new MyProduct(5, "product3");
var prod4 = new MyProduct(7, "product4");
var prod5 = new MyProduct(2, "product5");
var prod6 = new MyProduct(3, "product6");
var prod7 = new MyProduct(4, "product7");

var productsList = new MyShop(prod1, prod2, prod3, prod4, prod5, prod6, prod7);

var mostExpensiveProduct = productsList.GetMostExpensiveProduct();
Console.WriteLine($"Самый дорогой продукт: {mostExpensiveProduct}");

var sortedList = productsList.SortProductByPrice();
Console.WriteLine();
MyShop.PrintMyProductsList(sortedList);
