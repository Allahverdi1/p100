using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal class RestaurantManager:IRestaurantManager
    {
        public List<Order> orders = new List<Order>();
        public List<Order> Orders { get; }

        List<Order> IRestaurantManager.orders => throw new NotImplementedException();

        public void AddOrder(int no,int totalAmount,DateTime date)
        {
           
        }

        public Order GetOrderByNo(int? no)
        {
            return orders.Find(Order => Order.No.Contains(int?));
            throw new NotImplementedException();
        }

        public void RemoveOrder(int? no)
        {
      
                var result = orders.Find(Order => Order.No == no);
                if (no == null)
                {
                    throw new NullReferenceException("null-dir");
                }
                orders.Remove(result);
              
        }

    }
}
