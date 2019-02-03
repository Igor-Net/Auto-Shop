using System.Collections.Generic;
using AutoShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop.Data
{
  public interface IAutoRepository
  {
    IEnumerable<Product> GetAllProducts();
    IEnumerable<Product> GetProductsByCategory(string category);

    IEnumerable<Order> GetAllOrders(bool includeItems);
    IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
    Order GetOrderById(string username, int id);
    void AddOrder(Order newOrder);

    bool SaveAll();
    void AddEntity(object model);
  }
}