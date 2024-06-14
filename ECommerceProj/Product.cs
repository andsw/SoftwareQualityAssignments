using System;
namespace ECommerceProj
{
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public Product(int id, string name, decimal price, int stock)
    {
      this.Id = id;
      this.Name = name;
      this.Price = price;
      this.Stock = stock;
    }

    // Methods to increase and decrease stock
    public void IncreaseStock(int amt)
    {
      if (amt < 0)
      {
        throw new ArgumentException("Amount to increase cannot be negative.");
      }
      Stock += amt;
    }

    public void DecreaseStock(int amt)
    {
      if (amt < 0)
      {
        throw new ArgumentException("Amount to decrease cannot be negative.");
      }
      if (amt > Stock)
      {
        throw new InvalidOperationException("Cannot decrease stock below zero.");
      }
      Stock -= amt;
    }
  }
}

