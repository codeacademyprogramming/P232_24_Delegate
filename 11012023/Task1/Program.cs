using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store maqsudDayininMarketi = new Store();


            for (int i = 0; i < 3; i++)
            {
                var product = CreateProduct();
                maqsudDayininMarketi.Products.Add(product);
            }

            Console.WriteLine("Istifade muddeti bitmis mehsullar:");
            foreach (var item in maqsudDayininMarketi.GetExpiredProducts())
            {
                Console.WriteLine(item);
            }


        }
        static Product CreateProduct()
        {
            Console.WriteLine("Ad:");
            string name = Console.ReadLine();
            Console.WriteLine("Qiymet:");
            string priceStr = Console.ReadLine();
            decimal price = decimal.Parse(priceStr);

            Console.WriteLine("Istehsal tarixi");
            string createdDateStr = Console.ReadLine();
            DateTime createdDate = DateTime.Parse(createdDateStr);

            Console.WriteLine("Bitme tarixi");
            string expireDateStr = Console.ReadLine();
            DateTime expireDate = DateTime.Parse(expireDateStr);

            Product product = new Product
            {
                Name = name,
                Price = price,
                ExpireDate = expireDate,
                CreatedDate = createdDate,
            };

            return product;
        }

    }
}
