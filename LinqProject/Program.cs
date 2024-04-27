List<Category> categories = new List<Category>
{
    new Category{CategoryId=1,CategoryName="Bilgisayar"},
    new Category{CategoryId=2,CategoryName ="Telefon" }
};

List<Product> products = new List<Product>
{
    new Product{ ProductId=1,CategoryId=1, ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=5},
    new Product{ ProductId=2,CategoryId=1, ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram", UnitPrice=8000,UnitsInStock=3},
    new Product{ ProductId=3,CategoryId=1, ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram", UnitPrice=6000,UnitsInStock=2},
    new Product{ ProductId=4,CategoryId=2, ProductName="Samsung Laptop",QuantityPerUnit="4 GB Ram", UnitPrice=5000,UnitsInStock=15},
    new Product{ ProductId=5,CategoryId=2, ProductName="Apple Laptop",QuantityPerUnit="4 GB Ram", UnitPrice=8000,UnitsInStock=0}
};
Console.WriteLine("Algorithmic..................."); 
foreach (var product in products)
{
    if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
    {
        Console.WriteLine(product.ProductName);
    }

}
Console.WriteLine("Linq.............................");
var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}


GetProducts(products);
List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredProducts = new List<Product>();
    foreach (var product in products)                              //Her bir ürünü gez
    {
        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)  //O anki ürünüm bu şartlara uyuyorsa 
        {
            filteredProducts.Add(product);                         //Onu listeye ekle
                                            //Şarta uyanların hepsini önce bir listeye eklemek lazım
        }

    }

    return filteredProducts;       //İşin bitince filtrelenmiş ürünleri döndür

}

List<Product> GetProductsLinq (List<Product> products)
{
    return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();  //Buradaki where FOREACH sağlıyor
}                                          //Where fonksiyonu(method u) bizim listemiz için şartlara göre bir döngü de oluşturuyor, 
                                           //Şarta uyanların her birini yeni listeye atıyor
class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}