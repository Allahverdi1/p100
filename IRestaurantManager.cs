using Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal interface IRestaurantManager
    {
        public List<Order> orders { get; }
        public void AddOrder(int no, int totalAmount, DateTime date);
        public void GetOrderByNo(int? no);
        public void RemoveOrder(int? no);
       
        
    }
}
