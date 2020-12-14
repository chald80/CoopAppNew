﻿using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        List<Order> GetAllOrders();
        List<Order> FilterOrder(string crtiteria);
       
        //Order GetOrder(int OrderID);

    }
}
