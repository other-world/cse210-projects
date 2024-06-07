public class Order
{
    private List<Product> _orders = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
        {
            _customer = customer;
        }
    public void AddProduct(Product product)
    {
        _orders.Add(product);
    }

    //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
    public double TotalCost()
    {
        double shippingCost;
        double totalCost;
        if (_customer.usCustomer())
        {
            shippingCost = 5.00;
        }
        else
        {
            shippingCost = 35.00;
        }
        totalCost = shippingCost + TotalOrderCost();
        return totalCost;
    }
    public double TotalOrderCost()
    {
        double ShippingTotal = 0;
        foreach (Product p in _orders)
        {
            ShippingTotal += p.TotalProductCost();
        }
        return ShippingTotal;
    }
    public void GetPackingLabel()
    {
        //Console.WriteLine($"Product Name, Product ID");
        foreach (Product p in _orders)
        {
            Console.WriteLine($"{p.GetProductName()}, {p.GetProductID()}");
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetCustomerAddress());
    }
}