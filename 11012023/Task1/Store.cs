using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Store
    {
        public List<Product> Products = new List<Product>();

        public List<Product> GetExpiredProducts()
        {
            List<Product> expiredProducts = new List<Product>();
            foreach (var item in Products)
            {
                if(item.ExpireDate.Date<DateTime.Now.Date)
                    expiredProducts.Add(item);
            }

            return expiredProducts;
        }

    }
}
