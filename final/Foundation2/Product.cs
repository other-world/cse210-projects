public class Product
{
    private string _prodName;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string prodName, int productID, double price, int quantity)
    {
        _prodName = prodName;
        _productID = productID; 
        _price = price; 
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _prodName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public double GetProductPrice()
    {
        return _price;
    }

    public int GetProductQuantity()
    {
        return _quantity;
    }

    public double TotalProductCost()
    {
        double totalProductCost = _price * _quantity;
        return totalProductCost;
    }
}