using Task1;

List<Product> products = new List<Product>
{
    new Product { ProductId = 1, Name = "Samsung TV", Price = 1500, ShopId = 1 },
    new Product { ProductId = 1, Name = "Samsung TV", Price = 1500, ShopId = 1 },
    new Product { ProductId = 2, Name = "Lenovo Thinkbook", Price = 3000, ShopId = 2 },
    new Product { ProductId = 3, Name = "Razer Mouse", Price = 200, ShopId = 1 },
    new Product { ProductId = 4, Name = "Airpods 3", Price = 500, ShopId = 3 }
};

List<Product> products2 = new List<Product>
{
    new Product { ProductId = 1, Name = "Samsung TV", Price = 1500, ShopId = 1 },
    new Product { ProductId = 2, Name = "Lenovo Thinkbook", Price = 3000, ShopId = 2 },
    new Product { ProductId = 3, Name = "Aula Mouse", Price = 100, ShopId = 2 },
    new Product { ProductId = 4, Name = "Airpods Pro", Price = 900, ShopId = 2 }
};

List<Shop> shops = new List<Shop>
{
    new Shop { ShopId = 1, Name = "Zoommer", Location = "Tbilisi" },
    new Shop { ShopId = 2, Name = "Elit Electronics", Location = "Kutaisi" },
    new Shop { ShopId = 3, Name = "Ispace", Location = "Batumi" }
};

List<Shop> shops2 = new List<Shop>
{
    new Shop { ShopId = 1, Name = "AppleCity", Location = "Tbilisi" },
    new Shop { ShopId = 2, Name = "Elit Electronics", Location = "Kutaisi" },
    new Shop { ShopId = 3, Name = "Ispace", Location = "Batumi" }
};

// Union method
var unionMethod = products.Select(p => p.Name).Union(products2.Select(p => p.Name));

Console.WriteLine("Union:");
foreach (var item in unionMethod)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Union query
var unionQuery = (from shop in shops select shop.Name)
                  .Concat(from shop in shops2 select shop.Name).Distinct();

Console.WriteLine("Union Query:");
foreach (var shop in unionQuery)
{
    Console.WriteLine(shop);
}
Console.WriteLine();

// Join method
var joinMethod = products.Join(shops, x => x.ShopId, x => x.ShopId, (e, d) => new
{
    e.Name,
    ShopName = d.Name
});

Console.WriteLine("Join Method:");
foreach (var item in joinMethod)
{
    Console.WriteLine($"Product - {item.Name}, Shop - {item.ShopName}");
}
Console.WriteLine();

// Join query
var joinQuery = from product in products
                join shop in shops on product.ShopId equals shop.ShopId
                select 
                new { product.Name, product.Price, ShopName = shop.Name, shop.Location };

Console.WriteLine("Join Query:");
foreach (var item in joinQuery)
{
    Console.WriteLine($"Product - {item.Name}, Price - {item.Price}, Shop - {item.ShopName}, Location - {item.Location}");
}
Console.WriteLine();

// Group join method
var groupJoinMethod = shops.GroupJoin(products, shop => shop.ShopId, product => product.ShopId,
    (shop, productsGroup) => new { Shop = shop, Products = productsGroup });

Console.WriteLine("Group Join Method:");
foreach (var shopWithProducts in groupJoinMethod)
{
    Console.WriteLine($"Shop: {shopWithProducts.Shop.Name}, Location: {shopWithProducts.Shop.Location}");
    foreach (var product in shopWithProducts.Products)
    {
        Console.WriteLine($"- Product: {product.Name}, Price: {product.Price}");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Group join query


// Group by method
var groupByMethod = products.GroupBy(product => product.ShopId);

Console.WriteLine("Group By Method:");
foreach (var group in groupByMethod)
{
    Console.WriteLine($"Shop ID: {group.Key}");
    foreach (var product in group)
    {
        Console.WriteLine($"- Product: {product.Name}, Price: {product.Price}");
    }
}
Console.WriteLine();

// Group by query
var groupByQuery = from product in products
                   group product by product.ShopId into newTable
                   select newTable;

Console.WriteLine("Group By Query:");
foreach( var product in groupByQuery)
{
    Console.WriteLine("ShopId: " + product.Key);
    foreach(var item in product)
    {
        Console.WriteLine($"Product - {item.Name}, ShopId - {item.ShopId}");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Group by multiple properties method
var groupByMultipleResult = shops.GroupBy(shop => new { shop.Location, shop.Name });

Console.WriteLine("Group By Multiple Properties:");
foreach (var group in groupByMultipleResult)
{
    Console.WriteLine($"Location: {group.Key.Location}, Shop Name: {group.Key.Name}");
    foreach (var shop in group)
    {
        Console.WriteLine($"- Shop ID: {shop.ShopId}");
    }
}
Console.WriteLine();

// Group by multiple properties query
var groupByMultipleQuery = from product in products
                           group product by new
                           {
                               product.ShopId,
                               product.Name
                           } into newTable
                           select newTable;

Console.WriteLine("Group By Multiple Properties Query:");
foreach (var group in groupByMultipleQuery)
{
    Console.WriteLine($"Location: {group.Key.Name}, Shop Name: {group.Key.ShopId}");
    foreach (var product in group)
    {
        Console.WriteLine($"- Product: {product.Name}, Price: {product.Price}");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Group by + aggregate methods
var groupByWithAggregateResult = products
            .GroupBy(product => product.ShopId)
            .Select(group => new { ShopId = group.Key, TotalPrice = group.Sum(product => product.Price) });

Console.WriteLine("Group By + Aggregate Methods:");
foreach (var group in groupByWithAggregateResult)
{
    Console.WriteLine($"Shop ID: {group.ShopId}, Total Price: {group.TotalPrice}");
}
Console.WriteLine();

// Group by + aggregate methods query
var groupByWithAggregateResultQuery = from product in products
                                      group product by product.ShopId into newTable
                                      select new
                                      {
                                          newTable.Key,
                                          TotalPrice = newTable.Sum(p => p.Price)
                                      };

Console.WriteLine("Group By + Aggregate Methods Query:");
foreach (var group in groupByWithAggregateResultQuery)
{
    Console.WriteLine($"Shop ID: {group.Key}, Total Price: {group.TotalPrice}");
}
Console.WriteLine();

Console.ReadKey();