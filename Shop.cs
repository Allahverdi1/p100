using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Shop
    {
        List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public List<Order> FilterOrderByPrice(int minPrice, int maxPrice)
        {
            return orders.FindAll(filter => filter.TotalPrice > minPrice && filter.TotalPrice < maxPrice);
        }
        public void RemoveOrderByNo(string no)
        {
            if (!string.IsNullOrWhiteSpace(no))
            {
                throw new NullReferenceException("Null-dır");
            }
            var result = orders.Find(r => r.No == no);
            if (no == null)
            {
                throw new NullReferenceException("Null-dir");
            }
            orders.Remove(result);
        }


            
        
    }
}
