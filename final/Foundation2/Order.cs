using System;


public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackingList()
    {
        string list = "Order Packing List:\n";
        foreach (Product product in _products)
        {
            list += $"{product.GetPackingList()}\n";
        }
        return list;
    }
    public string GetShippingLabel()
    {
        return $"Order Shipping Label:\n{_customer.GetShippingLabel()}";
    }
    public string GetBill()
    {
        double total = this.GetTotal();
        if (_customer.IsInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return $"Order Total: ${total}\n";
    }

    private double GetTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }
        return total;
    }
}