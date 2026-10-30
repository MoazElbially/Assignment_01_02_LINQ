namespace Assignment_01_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment_1_LINQ

            #region Question 1

            //var result = Source.ProductList
            //    .Where(p => p.Category == "Seafood");

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Question 2

            //var result = Source.ProductList
            //             .Select(p => p.ProductName);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Question 3 

            //var result = Source.ProductList
            //             .OrderBy(p => p.UnitPrice);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Question 4 

            //var result = Source.ProductList
            //            .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 20);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Question 5

            //var result = Source.ProductList
            //            .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            //}

            #endregion

            #region Question 6

            //var result = Source.ProductList
            //             .Select(p => new
            //             {
            //                 Name = p.ProductName,
            //                 Price = p.UnitPrice,
            //                 StockStatus = p.UnitsInStock > 0 ? "In Stock" : "Out of Stock"
            //             });
            //foreach (var p in result)
            //{
            //    Console.WriteLine($" Name: {p.Name} - Price: {p.Price:C2} - StockStatus: {p.StockStatus}");
            //}

            #endregion

            #region Question 7

            //var result = Source.ProductList
            //            .Select((p, index) => new
            //            {
            //                Position = index + 1,
            //                Name = p.ProductName
            //            });

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.Position}. {p.Name}");
            //}

            #endregion

            #region Question 8 

            //var result = Source.ProductList
            //            .OrderBy(p => p.Category)
            //            .ThenByDescending(p => p.UnitPrice);

            //foreach (var p in result)
            //{
            //    Console.WriteLine( $"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Question 9 

            //var result = Source.ProductList
            //            .Where(p => p.Category == "Beverages")
            //            .OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            //}

            #endregion

            #region Question 10

            //var result = from c in Source.CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //                   select new
            //                   {
            //                       c.CustomerID,
            //                       o.OrderDate
            //                   };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.CustomerID} - {item.OrderDate}");
            //}

            #endregion

            #region Question 11

            //var result =Source.ProductList
            //            .Select((p, index) => new
            //            {
            //                Position = index + 1,
            //                ProductName = p.ProductName
            //            });

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.Position}. {p.ProductName}");
            //}

            #endregion

            #region Question 12

            //string[] Arr ={"aPPLE","AbAcUs","bRaNCH","BlUeBeRrY","ClOvEr","cHeRry"};

            //var result = Arr.OrderBy(x => x.Length)
            //            .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Assignment_2_LINQ

            #region Question 1

            //var result =Source.ProductList
            //            .OrderByDescending(p => p.UnitPrice)
            //            .Take(3);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Question 2

            //var result = Source .ProductList
            //             .Skip(5)
            //             .Take(5);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} ");
            //}

            #endregion

            #region Question 3

            //var result = Source.ProductList
            //            .OrderBy(p => p.UnitPrice)
            //            .TakeWhile(p => p.UnitPrice < 25);
            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            #endregion

            #region Question 4

            //var result =Source .ProductList
            //             .Where(p => p.Category == "Seafood")
            //             .All(p => p.UnitsInStock > 0);
            //Console.WriteLine(result);

            #endregion

            #region Question 5

            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);

            #endregion

            #region Question 6

            //var result =Source .ProductList
            //            .GroupBy(p => p.Category);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()} products");
            //}


            #endregion

            #region Question 7

            //var result =Source.ProductList
            //            .GroupBy(p => p.Category)   
            //            .Select(g => new
            //            {
            //                Category = g.Key,
            //                ProductNames = g.Select(p => p.ProductName)
            //            });
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.ProductNames)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}


            #endregion

            #region Question 8

            //var result =Source .ProductList
            //            .GroupBy(p => p.Category)
            //            .Where(g => g.Count() > 3)
            //            .Select(g => g.Key);
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}


            #endregion

            #region Question 9

            //var result =from c in Source .CustomerList
            //            group c by c.Country into g
            //            select new
            //            {
            //                Country = g.Key,
            //                Count = g.Count(),
            //                TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //            };

            //foreach (var item in result)
            //{
            //    Console.WriteLine( $"{item.Country} - Count: {item.Count} - Total: {item.TotalOrderValue}");
            //}


            #endregion

            #region Question 10

            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);

            #endregion

            #region Question 11

            //var cheapest =Source.ProductList.Min(p => p.UnitPrice);
            //var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest Price: {cheapest}");
            //Console.WriteLine($"Expensive Price: {mostExpensive}");


            #endregion

            #region Question 12

            //var result =Source .ProductList 
            //            .Select(p => p.Category)
            //            .Distinct();
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}


            #endregion

            #region Question 13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            //foreach (var id in result)
            //{
            //    Console.WriteLine(id);
            //}

            #endregion

            #region Question 14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(
            //    list2,
            //    StringComparer.OrdinalIgnoreCase
            //);
            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}

            #endregion

            #region Question 15

            //Dictionary<int, Product> productDictionary =Source.ProductList .ToDictionary(p => p.ProductID);
            //if (productDictionary.TryGetValue(18, out Product product))
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found");
            //}

            #endregion

            #region Question 16

            //var result = Source.ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result.ProductName);

            #endregion

            #region Question 17

            //var result =Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //if (result != null)
            //{
            //    Console.WriteLine(result.ProductName);
            //}
            //else
            //{
            //    Console.WriteLine("No product found");
            //}

            #endregion

            #region Question 18

            //var result = Enumerable.Range(1, 10)
            //            .Select(i => $"7 x {i} = {7 * i}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Question 19

            //var result = Enumerable.Range(1, 30)
            //             .Where(n => n % 2 == 0);
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Question 20

            //var result =Source.ProductList
            //            .Take(3)
            //            .Select(p => p.ProductName)
            //            .Concat(
            //                Source.CustomerList     
            //                    .Take(3)
            //                    .Select(c => c.CustomerName)
            //            );
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Question 21

            //var result = Source.ProductList
            //            .Zip(
            //                Source.CustomerList,
            //                (p, c) => $"{p.ProductName} sold to {c.CustomerName}"
            //            );
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

        }
    }
}
