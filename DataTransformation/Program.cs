using static DataTransformation.Helper;

var custPurQuery =
                from c in customers
                from p in c.Purchases
                select new { Name = c.Last, Purchase = p };

foreach (var cust in custPurQuery)
{
    Console.WriteLine("{0}, {1}", cust.Name, cust.Purchase);
}

var custPurEuro = from c in customers select new { Name = c.Last, Purchase = c.Price * 0.89 };

foreach (var cust in custPurEuro)
{
    Console.WriteLine("{0}, {1}", cust.Name, cust.Purchase);
}