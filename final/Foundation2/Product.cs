public class Product
{
    private string _nameProduct;
    private int _idProduct;
    private double _priceProduct;
    private int _quantityProduct;

    public Product(string name, int id, double price, int quantity)
    {
        _nameProduct = name;
        _idProduct = id;
        _priceProduct = price;
        _quantityProduct = quantity;
    }

    public string GetNameProduct()
    {
        return _nameProduct;
    }

    public int GetIDProduct()
    {
        return _idProduct;
    }

    public double GetPriceProduct()
    {
        return _priceProduct;
    }

    public int GetQuantityProduct()
    {
        return _quantityProduct;
    }

    public double CalculateRealPrice()
    {
        return _priceProduct * _quantityProduct;
    }
}