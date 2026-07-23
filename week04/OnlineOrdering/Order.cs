using System.Collections.Generic;
using System.Text;
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
public double CalculateTotalCost()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("PACKING LABEL:");
        foreach (Product product in _products)
        {
            label.AppendLine($"- {product.GetName()} (ID: {product.GetProductId()})");
        }
        return label.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("SHIPPING LABEL:");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddress().GetFormattedAddress());
        return label.ToString().TrimEnd();
    }
}


