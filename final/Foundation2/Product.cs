public class Product
{
    private string _nameProduct;
    private int _idProduct;
    private float _priceProduct;
    private int _quantityProduct;

    public Product(string name, int id, float price, int quantity)
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

    public float GetPriceProduct()
    {
        return _priceProduct;
    }

    public int GetQuantityProduct()
    {
        return _quantityProduct;
    }

    public float CalculateRealPrice()
    {
        return _priceProduct * _quantityProduct;
    }
}